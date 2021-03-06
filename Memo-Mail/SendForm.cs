﻿/*
This file is part of the Memo-Mail Source Code.  

Memo-Mail is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Memo-Mail is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Memo-Mail. If not, see <http://www.gnu.org/licenses/gpl.html>.

The complete source code can be found at <https://github.com/Nepochal/Memo-Mail>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace Nepochal.MemoMail
{
  public partial class SendForm : Form
  {

    #region Delegates

    private delegate void ErrorWhileSendingDelegate();
    private delegate void CloseProgramDelegate();

    #endregion

    #region Member Variables

    private Config mcConfig;
    bool mbPushedEnter;

    string msHeader;
    string msMessage;

    Thread mtMailSender;

    #endregion

    #region ctors

    public SendForm(Config pcConfig)
    {
      InitializeComponent();
      mcConfig = pcConfig;
      Location = mcConfig.LocationSendForm;
      Width = mcConfig.WidthSendForm;
      Height = mcConfig.HeightSendForm;
    }

    #endregion

    #region Designer Methods

    private void SendForm_Load(object sender, EventArgs e)
    {
      textBoxHeader.Text = mcConfig.Header;
      TopMost = mcConfig.SendFormForeground;
      if (mcConfig.Clipboard2Mail && Clipboard.ContainsText())
        textBoxMessage.Text = string.Format("{0}{1}", Clipboard.GetText(), Environment.NewLine);

      //hide subject-textbox and resize message-textbox when auto-use-default-header-option is set
      if (mcConfig.AlwaysUseDefaultheader)
      {
        textBoxHeader.Visible = false;
        textBoxMessage.Location = new Point(textBoxMessage.Location.X, textBoxMessage.Location.Y - textBoxHeader.Height);
        textBoxMessage.Height += textBoxHeader.Height;
      }
      Common.AdjustForm(this);
    }

    private void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Enter)
        mbPushedEnter = false;

      switch (e.KeyCode)
      {
        //ENTER + ENTER: Send message
        case Keys.Enter:
          if (!mcConfig.SendMailOnDoubleEnter)
            break;
          if (mbPushedEnter)
            SendMessage();
          else
            mbPushedEnter = true;
          break;

        //CTRL + A: Select all
        case Keys.A:
          if (e.Control)
          {
            textBoxMessage.SelectionStart = 0;
            textBoxMessage.SelectionLength = textBoxMessage.Text.Length;
          }
          break;
      }
    }

    private void buttonSend_Click(object sender, EventArgs e)
    {
      SendMessage();
    }

    #region MenuStrip

    private void ToolStripMenuItemSendMail_Click(object sender, EventArgs e)
    {
      SendMessage();
    }

    private void ToolStripMenuItemConfiguration_Click(object sender, EventArgs e)
    {
      ConfigurationForm lcConfiguration = new ConfigurationForm(mcConfig);
      lcConfiguration.ShowDialog(this);
      mcConfig = lcConfiguration.Config;
      TopMost = mcConfig.SendFormForeground;
    }

    private void ToolStripMenuItemConfigWizard_Click(object sender, EventArgs e)
    {
      ConfigWizard.Wizard lwWizard = new ConfigWizard.Wizard();
      if (lwWizard.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        mcConfig = lwWizard.Config;
    }

    private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ToolStripMenuItemShortcuts_Click(object sender, EventArgs e)
    {
      ShowHelp();
    }

    private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
    {
      About laAbout = new About("Memo-Mail", Program.msVersion);
      laAbout.ShowDialog(this);
    }

    #endregion

    private void SendForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (WindowState != FormWindowState.Minimized)
      {
        mcConfig.LocationSendForm = Location;
        mcConfig.WidthSendForm = Width;
        mcConfig.HeightSendForm = Height;
      }

      byte[] lbKey = Common.CreateKey();
      Config.SaveConfig(mcConfig, lbKey);
    }

    #endregion

    #region Own Methods

    private void SendMessage()
    {
      msHeader = textBoxHeader.Text;
      msMessage = textBoxMessage.Text;

      Visible = false;
      MailSenderStart();
    }

    private void ShowHelp()
    {
      Shortcuts lhHelp = new Shortcuts(mcConfig);
      lhHelp.ShowDialog(this);
      mcConfig.LocationHelp = lhHelp.Location;
      byte[] lbKey = Common.CreateKey();
      Config.SaveConfig(mcConfig, lbKey);
    }

    private void CloseProgram()
    {
      if (InvokeRequired)
        Invoke(new CloseProgramDelegate(CloseProgram));
      else
        Close();
    }

    private void ErrorWhileSending()
    {
      if (InvokeRequired)
        Invoke(new ErrorWhileSendingDelegate(ErrorWhileSending));
      else
        Visible = true;
    }

    #endregion

    #region Thread: E-Mail Sender

    private void MailSenderStart()
    {
      mtMailSender = new Thread(MailSenderWorkspace);
      mtMailSender.Name = "MailSender";
      mtMailSender.IsBackground = false;
      mtMailSender.Start();
    }

    private void MailSenderWorkspace()
    {
      try
      {
        SmtpClient lscSender = new SmtpClient();

        //Configure send options
        lscSender.Host = mcConfig.SmtpServer;
        lscSender.Port = mcConfig.Port;
        lscSender.Timeout = 30000;
        lscSender.Credentials = new NetworkCredential(mcConfig.Username, mcConfig.Password);

        MailMessage lmmMessage = new MailMessage();

        //Sender
        MailAddress lmaSender;
        if (mcConfig.From != string.Empty)
          lmaSender = new MailAddress(mcConfig.SmtpAddress, mcConfig.From);
        else
          lmaSender = new MailAddress(mcConfig.SmtpAddress);

        lmmMessage.From = lmaSender;

        //Receiver
        lmmMessage.To.Add(mcConfig.ReceiverAddress);

        //Message
        lmmMessage.Subject = msHeader;
        lmmMessage.Body = msMessage;

        lscSender.Send(lmmMessage);
        CloseProgram();
      }
      catch (SmtpException e)
      {
        string lsError;
        if (e.InnerException != null)
          lsError = e.InnerException.Message;
        else
          lsError = e.Message;
        MessageBox.Show(string.Format("The e-mail could not be sent. The following error occured:{0}{1}", Environment.NewLine, lsError), "Memo-Mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //MessageBox.Show(string.Format("The e-mail could not be sent.{0}Please check if the smtp information were set correctly and that your internet connection works properly.", Environment.NewLine), "Memo-Mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
        ErrorWhileSending();
      }
    }

    #endregion

  }
}
