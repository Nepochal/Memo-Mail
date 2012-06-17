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

namespace Nepochal.MemoMail.ConfigWizard
{
  partial class Wizard
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizard));
      this.buttonCancel = new System.Windows.Forms.Button();
      this.buttonNext = new System.Windows.Forms.Button();
      this.buttonBack = new System.Windows.Forms.Button();
      this.panelMain = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // buttonCancel
      // 
      this.buttonCancel.Location = new System.Drawing.Point(403, 234);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 0;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
      // 
      // buttonNext
      // 
      this.buttonNext.Enabled = false;
      this.buttonNext.Location = new System.Drawing.Point(322, 234);
      this.buttonNext.Name = "buttonNext";
      this.buttonNext.Size = new System.Drawing.Size(75, 23);
      this.buttonNext.TabIndex = 1;
      this.buttonNext.Text = "Next >";
      this.buttonNext.UseVisualStyleBackColor = true;
      this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
      // 
      // buttonBack
      // 
      this.buttonBack.Location = new System.Drawing.Point(241, 234);
      this.buttonBack.Name = "buttonBack";
      this.buttonBack.Size = new System.Drawing.Size(75, 23);
      this.buttonBack.TabIndex = 2;
      this.buttonBack.Text = "< Back";
      this.buttonBack.UseVisualStyleBackColor = true;
      this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
      // 
      // panelMain
      // 
      this.panelMain.Location = new System.Drawing.Point(2, 2);
      this.panelMain.Name = "panelMain";
      this.panelMain.Size = new System.Drawing.Size(480, 226);
      this.panelMain.TabIndex = 3;
      // 
      // Wizard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 262);
      this.Controls.Add(this.panelMain);
      this.Controls.Add(this.buttonBack);
      this.Controls.Add(this.buttonNext);
      this.Controls.Add(this.buttonCancel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Wizard";
      this.Text = "Memo-Mail Configuration Wizard";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Wizard_FormClosing);
      this.Load += new System.EventHandler(this.Wizard_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonCancel;
    private System.Windows.Forms.Button buttonNext;
    private System.Windows.Forms.Button buttonBack;
    private System.Windows.Forms.Panel panelMain;
  }
}