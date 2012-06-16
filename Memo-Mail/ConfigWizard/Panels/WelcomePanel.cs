using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  public partial class WelcomePanel : aConfigWizardPanel
  {

    #region ctors
    public WelcomePanel(Wizard pwOwner)
    {
      mwOwner = pwOwner;
      InitializeComponent();
      mwOwner.EnableBackButton = false;
    }

    public WelcomePanel()
    {
      InitializeComponent();
    }

    #endregion

    #region own methods

    internal override void OnShow()
    {
      mwOwner.EnableBackButton = false;
      EnableNextButton = true;
    }

    internal override bool CheckInputs()
    {
      return true;
    }

    internal override void InsertInformationIntoConfig(Config pcConfig)
    { }

    #endregion

  }
}
