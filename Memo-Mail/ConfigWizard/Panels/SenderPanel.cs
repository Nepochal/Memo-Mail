using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  public partial class SenderPanel : aConfigWizardPanel
  {

    #region ctors

    public SenderPanel()
    {
      InitializeComponent();
    }

    public SenderPanel(Wizard pwOwner)
    {
      mwOwner = pwOwner;
      InitializeComponent();
    }

    #endregion

    #region designer methods

    private void InputChanged(object sender, EventArgs e)
    {
      EnableNextButton = CheckInputs();
    }

    #endregion

    #region own methods

    internal override void OnShow()
    {
      EnableNextButton = CheckInputs();
    }

    internal override bool CheckInputs()
    {
      if (!Common.CheckMailAddress(textBoxMail.Text) || textBoxPwd1.Text == string.Empty)
        return false;
      if (!textBoxPwd1.Text.Equals(textBoxpwd2.Text))
        return false;
      return true;
    }

    internal override void InsertInformationIntoConfig(Config pcConfig)
    {
      pcConfig.From = textBoxName.Text;
      pcConfig.SmtpAddress = textBoxMail.Text;
      pcConfig.Password = textBoxPwd1.Text;
    }

    #endregion

  }
}
