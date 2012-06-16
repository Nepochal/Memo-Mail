using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  public partial class PortablePanel : aConfigWizardPanel
  {

    #region ctors

    public PortablePanel()
    {
      InitializeComponent();
    }

    public PortablePanel(Wizard pwOwner)
    {
      mwOwner = pwOwner;
      InitializeComponent();
    }

    #endregion

    #region designer methods

    private void radioButtonNonPortable_CheckedChanged(object sender, EventArgs e)
    {
      EnableNextButton = CheckInputs();
    }

    #endregion

    #region own methods

    internal override void OnShow()
    {
      mwOwner.EnableBackButton = true;
      mwOwner.EnableNextButton = CheckInputs();
    }

    internal override bool CheckInputs()
    {
      if (radioButtonNonPortable.Checked)
        return true;
      return false;
    }

    #endregion

  }
}
