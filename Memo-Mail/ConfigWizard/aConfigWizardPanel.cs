using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Nepochal.MemoMail.ConfigWizard
{
  public partial class aConfigWizardPanel : UserControl
  {

    #region member variables

    internal Wizard mwOwner;

    #endregion

    #region accessors

    //Enables or disables the next button in the wizard-form
    private bool EnableNextButton
    {
      set { mwOwner.EnableNextButton = value; }
    }

    #endregion

    #region ctors

    public aConfigWizardPanel(Wizard pwOwner)
    {
      InitializeComponent();
      mwOwner = pwOwner;
    }

    public aConfigWizardPanel()
    {
      InitializeComponent();
    }

    #endregion

    #region Methods

    //will be used when the panel shows up
    internal virtual void OnShow()
    {
      throw new NotImplementedException();
    }

    //checks all inputs for enabling or disabling the next button
    internal virtual bool CheckInputs()
    {
      throw new NotImplementedException();
    }

    //Insert all Information into config. will always be automaticly done when the next button was clicked
    internal virtual void InsertInformationIntoConfig(Config pcConfig)
    {
      throw new NotImplementedException();
    }

    //Will be automaticly bound when this panel shows up and unbound when another panel is active
    internal void WizardButtonNextClicked(object sender, EventArgs e)
    {
      InsertInformationIntoConfig(mwOwner.Config);
    }

    #endregion

  }
}
