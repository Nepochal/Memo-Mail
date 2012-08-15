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

namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  public partial class WelcomePanel : ConfigWizardPanel
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
      mwOwner.FocusNextButton();
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
