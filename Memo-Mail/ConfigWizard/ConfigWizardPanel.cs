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
The installer for the current version can be found at <http://mischolz.de/?page_id=140>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Nepochal.MemoMail.ConfigWizard
{
  public partial class ConfigWizardPanel : UserControl
  {

    #region member variables

    internal Wizard mwOwner;

    #endregion

    #region accessors

    //Enables or disables the next button in the wizard-form
    internal bool EnableNextButton
    {
      set { mwOwner.EnableNextButton = value; }
    }

    #endregion

    #region ctors

    public ConfigWizardPanel(Wizard pwOwner)
    {
      InitializeComponent();
      mwOwner = pwOwner;
    }

    public ConfigWizardPanel()
    {
      InitializeComponent();
    }

    #endregion

    #region Methods

    //will be used when the panel shows up
    internal virtual void OnShow()
    {
      EnableNextButton = CheckInputs();
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
