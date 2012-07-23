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

namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  partial class SenderPanel
  {
    /// <summary> 
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Komponenten-Designer generierter Code

    /// <summary> 
    /// Erforderliche Methode für die Designerunterstützung. 
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelHeader = new System.Windows.Forms.Label();
      this.labelName = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.labelOptional = new System.Windows.Forms.Label();
      this.textBoxMail = new System.Windows.Forms.TextBox();
      this.labelMail = new System.Windows.Forms.Label();
      this.textBoxPwd1 = new System.Windows.Forms.TextBox();
      this.labelPwd1 = new System.Windows.Forms.Label();
      this.textBoxpwd2 = new System.Windows.Forms.TextBox();
      this.labelPwd2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelHeader
      // 
      this.labelHeader.AutoSize = true;
      this.labelHeader.Location = new System.Drawing.Point(4, 4);
      this.labelHeader.Name = "labelHeader";
      this.labelHeader.Size = new System.Drawing.Size(339, 13);
      this.labelHeader.TabIndex = 0;
      this.labelHeader.Text = "Please insert the following information about the sender e-mail address.";
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(44, 33);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(81, 13);
      this.labelName.TabIndex = 1;
      this.labelName.Text = "Your real name:";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(131, 30);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(164, 20);
      this.textBoxName.TabIndex = 2;
      // 
      // labelOptional
      // 
      this.labelOptional.AutoSize = true;
      this.labelOptional.Location = new System.Drawing.Point(301, 33);
      this.labelOptional.Name = "labelOptional";
      this.labelOptional.Size = new System.Drawing.Size(50, 13);
      this.labelOptional.TabIndex = 3;
      this.labelOptional.Text = "(optional)";
      // 
      // textBoxMail
      // 
      this.textBoxMail.Location = new System.Drawing.Point(131, 53);
      this.textBoxMail.Name = "textBoxMail";
      this.textBoxMail.Size = new System.Drawing.Size(164, 20);
      this.textBoxMail.TabIndex = 5;
      this.textBoxMail.TextChanged += new System.EventHandler(this.InputChanged);
      // 
      // labelMail
      // 
      this.labelMail.AutoSize = true;
      this.labelMail.Location = new System.Drawing.Point(23, 56);
      this.labelMail.Name = "labelMail";
      this.labelMail.Size = new System.Drawing.Size(102, 13);
      this.labelMail.TabIndex = 4;
      this.labelMail.Text = "Your e-mail address:";
      // 
      // textBoxPwd1
      // 
      this.textBoxPwd1.Location = new System.Drawing.Point(131, 76);
      this.textBoxPwd1.Name = "textBoxPwd1";
      this.textBoxPwd1.PasswordChar = '*';
      this.textBoxPwd1.Size = new System.Drawing.Size(164, 20);
      this.textBoxPwd1.TabIndex = 7;
      this.textBoxPwd1.TextChanged += new System.EventHandler(this.InputChanged);
      // 
      // labelPwd1
      // 
      this.labelPwd1.AutoSize = true;
      this.labelPwd1.Location = new System.Drawing.Point(45, 79);
      this.labelPwd1.Name = "labelPwd1";
      this.labelPwd1.Size = new System.Drawing.Size(80, 13);
      this.labelPwd1.TabIndex = 6;
      this.labelPwd1.Text = "Your password:";
      // 
      // textBoxpwd2
      // 
      this.textBoxpwd2.Location = new System.Drawing.Point(131, 99);
      this.textBoxpwd2.Name = "textBoxpwd2";
      this.textBoxpwd2.PasswordChar = '*';
      this.textBoxpwd2.Size = new System.Drawing.Size(164, 20);
      this.textBoxpwd2.TabIndex = 9;
      this.textBoxpwd2.TextChanged += new System.EventHandler(this.InputChanged);
      // 
      // labelPwd2
      // 
      this.labelPwd2.AutoSize = true;
      this.labelPwd2.Location = new System.Drawing.Point(10, 102);
      this.labelPwd2.Name = "labelPwd2";
      this.labelPwd2.Size = new System.Drawing.Size(115, 13);
      this.labelPwd2.TabIndex = 8;
      this.labelPwd2.Text = "Retype your password:";
      // 
      // SenderPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.textBoxpwd2);
      this.Controls.Add(this.labelPwd2);
      this.Controls.Add(this.textBoxPwd1);
      this.Controls.Add(this.labelPwd1);
      this.Controls.Add(this.textBoxMail);
      this.Controls.Add(this.labelMail);
      this.Controls.Add(this.labelOptional);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelName);
      this.Controls.Add(this.labelHeader);
      this.Name = "SenderPanel";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelHeader;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label labelOptional;
    private System.Windows.Forms.TextBox textBoxMail;
    private System.Windows.Forms.Label labelMail;
    private System.Windows.Forms.TextBox textBoxPwd1;
    private System.Windows.Forms.Label labelPwd1;
    private System.Windows.Forms.TextBox textBoxpwd2;
    private System.Windows.Forms.Label labelPwd2;
  }
}
