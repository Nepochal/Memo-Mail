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
  partial class PortablePanel
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortablePanel));
      this.labelHeader = new System.Windows.Forms.Label();
      this.radioButtonNonPortable = new System.Windows.Forms.RadioButton();
      this.labelNonPortable = new System.Windows.Forms.Label();
      this.labelPortable = new System.Windows.Forms.Label();
      this.radioButtonPortable = new System.Windows.Forms.RadioButton();
      this.labelPwd1 = new System.Windows.Forms.Label();
      this.textBoxPwd1 = new System.Windows.Forms.TextBox();
      this.textBoxPwd2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelHeader
      // 
      this.labelHeader.AutoSize = true;
      this.labelHeader.Location = new System.Drawing.Point(4, 4);
      this.labelHeader.Name = "labelHeader";
      this.labelHeader.Size = new System.Drawing.Size(313, 13);
      this.labelHeader.TabIndex = 0;
      this.labelHeader.Text = "Please select if you want to use Memo-Mail on a portable device.";
      // 
      // radioButtonNonPortable
      // 
      this.radioButtonNonPortable.AutoSize = true;
      this.radioButtonNonPortable.Location = new System.Drawing.Point(10, 29);
      this.radioButtonNonPortable.Name = "radioButtonNonPortable";
      this.radioButtonNonPortable.Size = new System.Drawing.Size(86, 17);
      this.radioButtonNonPortable.TabIndex = 1;
      this.radioButtonNonPortable.TabStop = true;
      this.radioButtonNonPortable.Text = "Non-portable";
      this.radioButtonNonPortable.UseVisualStyleBackColor = true;
      this.radioButtonNonPortable.CheckedChanged += new System.EventHandler(this.radioButtonNonPortable_CheckedChanged);
      // 
      // labelNonPortable
      // 
      this.labelNonPortable.Location = new System.Drawing.Point(7, 49);
      this.labelNonPortable.Name = "labelNonPortable";
      this.labelNonPortable.Size = new System.Drawing.Size(470, 56);
      this.labelNonPortable.TabIndex = 2;
      this.labelNonPortable.Text = resources.GetString("labelNonPortable.Text");
      // 
      // labelPortable
      // 
      this.labelPortable.Location = new System.Drawing.Point(7, 137);
      this.labelPortable.Name = "labelPortable";
      this.labelPortable.Size = new System.Drawing.Size(470, 31);
      this.labelPortable.TabIndex = 4;
      this.labelPortable.Text = "The configuration-file will be stored in the program folder and will be encrypted" +
    " using the key below. You will have to enter the key on each program start.";
      // 
      // radioButtonPortable
      // 
      this.radioButtonPortable.AutoSize = true;
      this.radioButtonPortable.Enabled = false;
      this.radioButtonPortable.Location = new System.Drawing.Point(10, 117);
      this.radioButtonPortable.Name = "radioButtonPortable";
      this.radioButtonPortable.Size = new System.Drawing.Size(167, 17);
      this.radioButtonPortable.TabIndex = 3;
      this.radioButtonPortable.TabStop = true;
      this.radioButtonPortable.Text = "Portable (not implemented yet)";
      this.radioButtonPortable.UseVisualStyleBackColor = true;
      // 
      // labelPwd1
      // 
      this.labelPwd1.AutoSize = true;
      this.labelPwd1.Location = new System.Drawing.Point(72, 171);
      this.labelPwd1.Name = "labelPwd1";
      this.labelPwd1.Size = new System.Drawing.Size(56, 13);
      this.labelPwd1.TabIndex = 5;
      this.labelPwd1.Text = "Password:";
      // 
      // textBoxPwd1
      // 
      this.textBoxPwd1.Enabled = false;
      this.textBoxPwd1.Location = new System.Drawing.Point(130, 168);
      this.textBoxPwd1.Name = "textBoxPwd1";
      this.textBoxPwd1.PasswordChar = '*';
      this.textBoxPwd1.Size = new System.Drawing.Size(154, 20);
      this.textBoxPwd1.TabIndex = 6;
      // 
      // textBoxPwd2
      // 
      this.textBoxPwd2.Enabled = false;
      this.textBoxPwd2.Location = new System.Drawing.Point(130, 191);
      this.textBoxPwd2.Name = "textBoxPwd2";
      this.textBoxPwd2.PasswordChar = '*';
      this.textBoxPwd2.Size = new System.Drawing.Size(154, 20);
      this.textBoxPwd2.TabIndex = 8;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(36, 194);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Retype password:";
      // 
      // PortablePanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.textBoxPwd2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxPwd1);
      this.Controls.Add(this.labelPwd1);
      this.Controls.Add(this.labelPortable);
      this.Controls.Add(this.radioButtonPortable);
      this.Controls.Add(this.labelNonPortable);
      this.Controls.Add(this.radioButtonNonPortable);
      this.Controls.Add(this.labelHeader);
      this.Name = "PortablePanel";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelHeader;
    private System.Windows.Forms.RadioButton radioButtonNonPortable;
    private System.Windows.Forms.Label labelNonPortable;
    private System.Windows.Forms.Label labelPortable;
    private System.Windows.Forms.RadioButton radioButtonPortable;
    private System.Windows.Forms.Label labelPwd1;
    private System.Windows.Forms.TextBox textBoxPwd1;
    private System.Windows.Forms.TextBox textBoxPwd2;
    private System.Windows.Forms.Label label1;
  }
}
