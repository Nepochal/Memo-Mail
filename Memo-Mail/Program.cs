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
using System.Windows.Forms;
using Nepochal.MemoMail.ConfigWizard;

namespace Nepochal.MemoMail
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      byte[] lbKey = Common.CreateKey();
      Config lcConfig = Config.LoadConfig(lbKey);
      if (lcConfig == null)
      {
        Wizard lwWizard = new Wizard();
        Application.Run(lwWizard);
        if (lwWizard.DialogResult == DialogResult.OK)
          lcConfig = lwWizard.Config;
        else
          return;
      }

      Application.Run(new SendForm(lcConfig));
    }

    #region global information

    public static readonly string msVersion = "0.9.0 a";
    public static readonly int miRevision = 20;
    public static readonly DateTime mdtRelease = new DateTime(2012, 7, 23);

    #endregion

  }
}
