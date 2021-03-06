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

namespace Nepochal.MemoMail.ConfigWizard
{
  public partial class Wizard : Form
  {

    #region member variables

    private Config mcConfig = new Config();
    private ConfigWizardPanel[] mcwpPanels; //all panels
    private ConfigWizardPanel mcwpCurrentPanel; //the currently shown panel
    private int miCurrentPanelID = 0;
    private bool mbPortableMode = false;

    private bool mbFinishButton = false;

    #endregion

    #region accessors

    //for use in the panel classes
    internal bool EnableNextButton
    {
      set { buttonNext.Enabled = value; }
    }
    internal bool SetFinishButton
    {
      set
      {
        buttonNext.Text = value ? "Finish" : "Next >";
        mbFinishButton = value;
      }
    }
    internal bool EnableBackButton
    {
      set { buttonBack.Enabled = value; }
    }
    internal bool PortableMode
    {
      get { return mbPortableMode; }
      set { mbPortableMode = value; }
    }

    public Config Config
    {
      get { return mcConfig; }
      set { mcConfig = value; }
    }

    #endregion

    #region ctors

    public Wizard()
    {
      InitializeComponent();
    }

    #endregion

    #region designer methods

    private void Wizard_Load(object sender, EventArgs e)
    {
      mcConfig = new MemoMail.Config();
      InitializePanels();
      ShowPanel(mcwpPanels[0]);
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Wizard_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (DialogResult == System.Windows.Forms.DialogResult.OK)
        return;

      if (MessageBox.Show("Do you really want to abort the configuration?", "Abort", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
      {
        DialogResult = System.Windows.Forms.DialogResult.Cancel;
        return;
      }
      e.Cancel = true;
    }

    private void buttonNext_Click(object sender, EventArgs e)
    {
      if (mbFinishButton)
      {
        DialogResult = System.Windows.Forms.DialogResult.OK;
        Close();
      }
      else
      {
        mcwpCurrentPanel.InsertInformationIntoConfig(mcConfig);
        miCurrentPanelID++;
        ShowPanel(mcwpPanels[miCurrentPanelID]);
      }
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
      miCurrentPanelID--;
      ShowPanel(mcwpPanels[miCurrentPanelID]);
    }

    #endregion

    #region own methods

    private void InitializePanels()
    {
      Panels.WelcomePanel lp1 = new Panels.WelcomePanel(this);
      Panels.PortablePanel lp2 = new Panels.PortablePanel(this);
      Panels.SenderPanel lp3 = new Panels.SenderPanel(this);
      Panels.SmtpPanel lp4 = new Panels.SmtpPanel(this);
      Panels.ReceiverPanel lp5 = new Panels.ReceiverPanel(this);
      Panels.MiscellaneousPanel lp6 = new Panels.MiscellaneousPanel(this);
      Panels.CompletionPanel lp7 = new Panels.CompletionPanel(this);

      mcwpPanels = new ConfigWizardPanel[] { lp1, lp2, lp3, lp4, lp5, lp6, lp7 };
    }

    private ConfigWizardPanel FindPanel(Type ptPanelType)
    {
      //Find the panel that is type of the parameter
      foreach (ConfigWizardPanel lcwpCurrent in mcwpPanels)
        if (lcwpCurrent.GetType() == ptPanelType)
          return lcwpCurrent;

      return null;
    }

    private void ShowPanel(ConfigWizardPanel pcwpPanel)
    {
      //Delete NextClickEvent on the old panel
      if (mcwpCurrentPanel != null)
        BindNextClickedEvent(mcwpCurrentPanel, false);

      //Bind NextClickEvent on the new Panel
      mcwpCurrentPanel = pcwpPanel;
      BindNextClickedEvent(mcwpCurrentPanel, false);

      //Show the new panel
      panelMain.Controls.Clear();
      panelMain.Controls.Add(pcwpPanel);
      pcwpPanel.OnShow();
    }

    internal void BindNextClickedEvent(ConfigWizardPanel pcwPanel, bool pbBind)
    {
      buttonNext.Click -= pcwPanel.WizardButtonNextClicked;

      if (pbBind)
        buttonNext.Click += pcwPanel.WizardButtonNextClicked;
    }

    //for use in the panel classes
    internal void FocusNextButton()
    {
      buttonNext.Focus();
    }

    #endregion

  }
}
