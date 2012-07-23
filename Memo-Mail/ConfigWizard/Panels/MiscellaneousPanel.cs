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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  public partial class MiscellaneousPanel : ConfigWizardPanel
  {

    #region ctors

    public MiscellaneousPanel(Wizard pwOwner)
    {
      mwOwner = pwOwner;
      InitializeComponent();
    }

    public MiscellaneousPanel()
    {
      InitializeComponent();
    }

    #endregion

    #region own methods

    internal override bool CheckInputs()
    {
      mwOwner.SetFinishButton = false;
      return true;
    }

    internal override void InsertInformationIntoConfig(Config pcConfig)
    {
      pcConfig.SendFormForeground = checkBoxSendformForeground.Checked;
      pcConfig.SendMailOnDoubleEnter = checkBoxSendDoubleEnter.Checked;
      pcConfig.Clipboard2Mail = checkBoxClipboard2Mail.Checked;
    }

    #endregion

  }
}
