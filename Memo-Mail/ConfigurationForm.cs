/*
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
The installer for the current version can be found at [PLACEHOLDER].
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nepochal.MemoMail
{
  public partial class ConfigurationForm : Form
  {

    #region Accessors

    public Config Config
    {
      get { return mcConfig; }
    }

    #endregion

    #region Member Variables

    private Config mcConfig;
    private bool mbInvalidValues;

    #endregion

    #region ctors

    public ConfigurationForm()
    {
      InitializeComponent();
      mcConfig = new Config();
      Location = mcConfig.LocationConfiguration;
    }

    public ConfigurationForm(Config pcConfig)
    {
      InitializeComponent();
      mcConfig = pcConfig;
      Location = mcConfig.LocationConfiguration;

      GetConfig(mcConfig);

      buttonAccept.Enabled = false;
    }

    #endregion

    #region Designer Methods

    private void Configuration_Load(object sender, EventArgs e)
    {
      BindChangeEvents();
    }

    private void buttonAccept_Click(object sender, EventArgs e)
    {
      if (!CheckSettings())
        System.Media.SystemSounds.Exclamation.Play();
      else
      {
        byte[] lbKey = Common.CreateKey();
        mcConfig = SetConfig();
        if (Config.SaveConfig(mcConfig, lbKey))
        {
          buttonAccept.Enabled = false;
        }
      }
    }

    private void ValueChanged(object sender, EventArgs e)
    {
      buttonAccept.Enabled = true;
    }

    private void Configuration_FormClosing(object sender, FormClosingEventArgs e)
    {
      mcConfig.LocationConfiguration = Location;
    }

    #endregion

    #region Own Methods

    private void BindChangeEvents()
    {
      textBoxServer.TextChanged += new EventHandler(ValueChanged);
      textBoxUsername.TextChanged += new EventHandler(ValueChanged);
      textBoxPassword.TextChanged += new EventHandler(ValueChanged);
      textBoxSmtpMail.TextChanged += new EventHandler(ValueChanged);
      textBoxPopMail.TextChanged += new EventHandler(ValueChanged);
      textBoxHeader.TextChanged += new EventHandler(ValueChanged);
      numericUpDownSmtpPort.ValueChanged += new EventHandler(ValueChanged);
      textBoxFrom.TextChanged += new EventHandler(ValueChanged);
      checkBoxAlwaysUseDefault.CheckedChanged += new EventHandler(ValueChanged);
      checkBoxSendDoubleEnter.CheckedChanged += new EventHandler(ValueChanged);
      checkBoxClipboard2Mail.CheckedChanged += new EventHandler(ValueChanged);
    }

    private bool CheckSettings()
    {
      mbInvalidValues = false;


      //Sender
      //------
      TabPage ltpCurrent = tabPageSmtp;

      //Server
      SetErrorStatus(textBoxServer, labelServer, ltpCurrent, !Common.CheckServer(textBoxServer.Text));

      //Username
      SetErrorStatus(textBoxUsername, labelUsername, ltpCurrent, string.IsNullOrEmpty(textBoxUsername.Text));

      //Password
      SetErrorStatus(textBoxPassword, labelPassword, ltpCurrent, string.IsNullOrEmpty(textBoxPassword.Text));

      //SMTP-Mail
      SetErrorStatus(textBoxSmtpMail, labelSmtpMail, ltpCurrent, !Common.CheckMailAddress(textBoxSmtpMail.Text));


      //Receiver
      //--------
      ltpCurrent = tabPageReceiver;

      //Mail
      SetErrorStatus(textBoxPopMail, labelPopMail, ltpCurrent, !Common.CheckMailAddress(textBoxPopMail.Text));


      return !mbInvalidValues;
    }

    /// <summary>
    /// Sets the foreground color of the label on red or black. Sets focus on the Textbox on first error.
    /// </summary>
    private void SetErrorStatus(TextBox ptbTextBox, Label plLabel, TabPage ptpTabpage, bool pbError)
    {
      plLabel.ForeColor = (pbError) ? Color.Red : Color.Black;

      if (pbError)
      {
        if (!mbInvalidValues)
        {
          tabControl.SelectedTab = ptpTabpage;
          ptbTextBox.Focus();
          ptbTextBox.SelectAll();
        }
        mbInvalidValues = true;
      }
    }

    private Config SetConfig()
    {
      Config lcNewConfig = mcConfig;
      lcNewConfig.From = textBoxFrom.Text;
      lcNewConfig.Header = textBoxHeader.Text;
      lcNewConfig.Password = textBoxPassword.Text;
      lcNewConfig.Port = Convert.ToInt32(numericUpDownSmtpPort.Value);
      lcNewConfig.ReceiverAddress = textBoxPopMail.Text;
      lcNewConfig.SmtpAddress = textBoxSmtpMail.Text;
      lcNewConfig.SmtpServer = textBoxServer.Text;
      lcNewConfig.Username = textBoxUsername.Text;
      lcNewConfig.AlwaysUseDefaultheader = checkBoxAlwaysUseDefault.Checked;
      lcNewConfig.SendMailOnDoubleEnter = checkBoxSendDoubleEnter.Checked;
      lcNewConfig.Clipboard2Mail = checkBoxClipboard2Mail.Checked;

      return lcNewConfig;
    }

    private void GetConfig(Config pcConfig)
    {
      textBoxFrom.Text = pcConfig.From;
      textBoxHeader.Text = pcConfig.Header;
      textBoxPassword.Text = pcConfig.Password;
      numericUpDownSmtpPort.Value = pcConfig.Port;
      textBoxPopMail.Text = pcConfig.ReceiverAddress;
      textBoxSmtpMail.Text = pcConfig.SmtpAddress;
      textBoxServer.Text = pcConfig.SmtpServer;
      textBoxUsername.Text = pcConfig.Username;
      checkBoxAlwaysUseDefault.Checked = pcConfig.AlwaysUseDefaultheader;
      checkBoxSendDoubleEnter.Checked = pcConfig.SendMailOnDoubleEnter;
      checkBoxClipboard2Mail.Checked = pcConfig.Clipboard2Mail;
    }

    #endregion

  }
}
