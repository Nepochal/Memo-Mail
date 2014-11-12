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
using System.Diagnostics;

namespace Nepochal.MemoMail
{
  public partial class About : Form
  {

    #region ctors

    public About(string psApplication, string psVersion)
    {
      InitializeComponent();
      labelTitle.Text = psApplication;
      labelVersion.Text = string.Format("Version: {0}", psVersion);
    }

    #endregion

    #region Designer Methods

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void linkLabelHp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("http://www.mischolz.de");
    }

    private void buttonSourceCode_Click(object sender, EventArgs e)
    {
      Process.Start("https://github.com/Nepochal/Memo-Mail");
    }

    #endregion

  }
}
