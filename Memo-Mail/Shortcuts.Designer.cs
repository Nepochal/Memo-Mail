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

namespace Nepochal.MemoMail
{
  partial class Shortcuts
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shortcuts));
      this.labelF1 = new System.Windows.Forms.Label();
      this.labelF1Text = new System.Windows.Forms.Label();
      this.labelF2Text = new System.Windows.Forms.Label();
      this.labelF2 = new System.Windows.Forms.Label();
      this.labelF12Text = new System.Windows.Forms.Label();
      this.labelF12 = new System.Windows.Forms.Label();
      this.labelDoubleEnterText = new System.Windows.Forms.Label();
      this.labelDoubleEnter = new System.Windows.Forms.Label();
      this.buttonClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelF1
      // 
      this.labelF1.Location = new System.Drawing.Point(7, 7);
      this.labelF1.Name = "labelF1";
      this.labelF1.Size = new System.Drawing.Size(53, 15);
      this.labelF1.TabIndex = 0;
      this.labelF1.Text = "F1";
      // 
      // labelF1Text
      // 
      this.labelF1Text.Location = new System.Drawing.Point(66, 7);
      this.labelF1Text.Name = "labelF1Text";
      this.labelF1Text.Size = new System.Drawing.Size(133, 15);
      this.labelF1Text.TabIndex = 1;
      this.labelF1Text.Text = "Show shortcut dialog";
      // 
      // labelF2Text
      // 
      this.labelF2Text.Location = new System.Drawing.Point(66, 27);
      this.labelF2Text.Name = "labelF2Text";
      this.labelF2Text.Size = new System.Drawing.Size(133, 15);
      this.labelF2Text.TabIndex = 3;
      this.labelF2Text.Text = "Show configuration dialog";
      // 
      // labelF2
      // 
      this.labelF2.Location = new System.Drawing.Point(7, 27);
      this.labelF2.Name = "labelF2";
      this.labelF2.Size = new System.Drawing.Size(53, 15);
      this.labelF2.TabIndex = 2;
      this.labelF2.Text = "F2";
      // 
      // labelF12Text
      // 
      this.labelF12Text.Location = new System.Drawing.Point(66, 47);
      this.labelF12Text.Name = "labelF12Text";
      this.labelF12Text.Size = new System.Drawing.Size(133, 15);
      this.labelF12Text.TabIndex = 5;
      this.labelF12Text.Text = "Show about dialog";
      // 
      // labelF12
      // 
      this.labelF12.Location = new System.Drawing.Point(7, 47);
      this.labelF12.Name = "labelF12";
      this.labelF12.Size = new System.Drawing.Size(53, 15);
      this.labelF12.TabIndex = 4;
      this.labelF12.Text = "F12";
      // 
      // labelDoubleEnterText
      // 
      this.labelDoubleEnterText.Location = new System.Drawing.Point(66, 67);
      this.labelDoubleEnterText.Name = "labelDoubleEnterText";
      this.labelDoubleEnterText.Size = new System.Drawing.Size(133, 15);
      this.labelDoubleEnterText.TabIndex = 7;
      this.labelDoubleEnterText.Text = "Send mail (if enabled)";
      // 
      // labelDoubleEnter
      // 
      this.labelDoubleEnter.Location = new System.Drawing.Point(7, 67);
      this.labelDoubleEnter.Name = "labelDoubleEnter";
      this.labelDoubleEnter.Size = new System.Drawing.Size(53, 15);
      this.labelDoubleEnter.TabIndex = 6;
      this.labelDoubleEnter.Text = "2 x Enter";
      // 
      // buttonClose
      // 
      this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonClose.Location = new System.Drawing.Point(135, 93);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(75, 23);
      this.buttonClose.TabIndex = 9;
      this.buttonClose.Text = "Close";
      this.buttonClose.UseVisualStyleBackColor = true;
      // 
      // Shortcuts
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(217, 124);
      this.Controls.Add(this.buttonClose);
      this.Controls.Add(this.labelDoubleEnterText);
      this.Controls.Add(this.labelDoubleEnter);
      this.Controls.Add(this.labelF12Text);
      this.Controls.Add(this.labelF12);
      this.Controls.Add(this.labelF2Text);
      this.Controls.Add(this.labelF2);
      this.Controls.Add(this.labelF1Text);
      this.Controls.Add(this.labelF1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(223, 148);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(223, 148);
      this.Name = "Shortcuts";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Memo-Mail Shortcuts";
      this.Load += new System.EventHandler(this.Shortcuts_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label labelF1;
    private System.Windows.Forms.Label labelF1Text;
    private System.Windows.Forms.Label labelF2Text;
    private System.Windows.Forms.Label labelF2;
    private System.Windows.Forms.Label labelF12Text;
    private System.Windows.Forms.Label labelF12;
    private System.Windows.Forms.Label labelDoubleEnterText;
    private System.Windows.Forms.Label labelDoubleEnter;
    private System.Windows.Forms.Button buttonClose;
  }
}