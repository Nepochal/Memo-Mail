using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  public partial class CompletionPanel : ConfigWizardPanel
  {

    #region ctors

    public CompletionPanel(Wizard pwOwner)
    {
      mwOwner = pwOwner;
      InitializeComponent();
    }

    public CompletionPanel()
    {
      InitializeComponent();
    }

    #endregion

    #region own methods

    internal override bool CheckInputs()
    {
      return true;
    }

    internal override void InsertInformationIntoConfig(Config pcConfig)
    {
    }

    #endregion

  }
}
