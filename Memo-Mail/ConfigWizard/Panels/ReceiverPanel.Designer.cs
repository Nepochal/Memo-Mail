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
  partial class ReceiverPanel
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
      this.labelInfo = new System.Windows.Forms.Label();
      this.textBoxReceiver = new System.Windows.Forms.TextBox();
      this.labelReceiver = new System.Windows.Forms.Label();
      this.textBoxDefaultHeader = new System.Windows.Forms.TextBox();
      this.labelDefaultHeader = new System.Windows.Forms.Label();
      this.labelDefaultHeaderInfo = new System.Windows.Forms.Label();
      this.checkBoxAlwaysUseDefaultSubject = new System.Windows.Forms.CheckBox();
      this.labelAlwaysUseDefaultSubjectInfo = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelInfo
      // 
      this.labelInfo.Location = new System.Drawing.Point(4, 4);
      this.labelInfo.Name = "labelInfo";
      this.labelInfo.Size = new System.Drawing.Size(462, 35);
      this.labelInfo.TabIndex = 0;
      this.labelInfo.Text = "Please enter the receiver mail address and the default subject. All messages you " +
    "send will go to this address.";
      // 
      // textBoxReceiver
      // 
      this.textBoxReceiver.Location = new System.Drawing.Point(131, 42);
      this.textBoxReceiver.Name = "textBoxReceiver";
      this.textBoxReceiver.Size = new System.Drawing.Size(164, 20);
      this.textBoxReceiver.TabIndex = 6;
      this.textBoxReceiver.TextChanged += new System.EventHandler(this.InputChanged);
      // 
      // labelReceiver
      // 
      this.labelReceiver.AutoSize = true;
      this.labelReceiver.Location = new System.Drawing.Point(32, 45);
      this.labelReceiver.Name = "labelReceiver";
      this.labelReceiver.Size = new System.Drawing.Size(93, 13);
      this.labelReceiver.TabIndex = 5;
      this.labelReceiver.Text = "Receiver address:";
      // 
      // textBoxDefaultHeader
      // 
      this.textBoxDefaultHeader.Location = new System.Drawing.Point(131, 78);
      this.textBoxDefaultHeader.Name = "textBoxDefaultHeader";
      this.textBoxDefaultHeader.Size = new System.Drawing.Size(164, 20);
      this.textBoxDefaultHeader.TabIndex = 8;
      this.textBoxDefaultHeader.Text = "[MemoMail]";
      this.textBoxDefaultHeader.TextChanged += new System.EventHandler(this.InputChanged);
      // 
      // labelDefaultHeader
      // 
      this.labelDefaultHeader.AutoSize = true;
      this.labelDefaultHeader.Location = new System.Drawing.Point(44, 81);
      this.labelDefaultHeader.Name = "labelDefaultHeader";
      this.labelDefaultHeader.Size = new System.Drawing.Size(81, 13);
      this.labelDefaultHeader.TabIndex = 7;
      this.labelDefaultHeader.Text = "Default subject:";
      // 
      // labelDefaultHeaderInfo
      // 
      this.labelDefaultHeaderInfo.AutoSize = true;
      this.labelDefaultHeaderInfo.Location = new System.Drawing.Point(131, 105);
      this.labelDefaultHeaderInfo.Name = "labelDefaultHeaderInfo";
      this.labelDefaultHeaderInfo.Size = new System.Drawing.Size(327, 13);
      this.labelDefaultHeaderInfo.TabIndex = 9;
      this.labelDefaultHeaderInfo.Text = "This subject will be used when you do not change it before sending.";
      // 
      // checkBoxAlwaysUseDefaultSubject
      // 
      this.checkBoxAlwaysUseDefaultSubject.AutoSize = true;
      this.checkBoxAlwaysUseDefaultSubject.Location = new System.Drawing.Point(134, 134);
      this.checkBoxAlwaysUseDefaultSubject.Name = "checkBoxAlwaysUseDefaultSubject";
      this.checkBoxAlwaysUseDefaultSubject.Size = new System.Drawing.Size(169, 17);
      this.checkBoxAlwaysUseDefaultSubject.TabIndex = 10;
      this.checkBoxAlwaysUseDefaultSubject.Text = "Always use the default subject";
      this.checkBoxAlwaysUseDefaultSubject.UseVisualStyleBackColor = true;
      this.checkBoxAlwaysUseDefaultSubject.CheckedChanged += new System.EventHandler(this.InputChanged);
      // 
      // labelAlwaysUseDefaultSubjectInfo
      // 
      this.labelAlwaysUseDefaultSubjectInfo.Location = new System.Drawing.Point(131, 155);
      this.labelAlwaysUseDefaultSubjectInfo.Name = "labelAlwaysUseDefaultSubjectInfo";
      this.labelAlwaysUseDefaultSubjectInfo.Size = new System.Drawing.Size(335, 30);
      this.labelAlwaysUseDefaultSubjectInfo.TabIndex = 11;
      this.labelAlwaysUseDefaultSubjectInfo.Text = "If selected, the subject-textbox in the send form will be removed and the default" +
    " subject will always be chosen.";
      // 
      // ReceiverPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelAlwaysUseDefaultSubjectInfo);
      this.Controls.Add(this.checkBoxAlwaysUseDefaultSubject);
      this.Controls.Add(this.labelDefaultHeaderInfo);
      this.Controls.Add(this.textBoxDefaultHeader);
      this.Controls.Add(this.labelDefaultHeader);
      this.Controls.Add(this.textBoxReceiver);
      this.Controls.Add(this.labelReceiver);
      this.Controls.Add(this.labelInfo);
      this.Name = "ReceiverPanel";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelInfo;
    private System.Windows.Forms.TextBox textBoxReceiver;
    private System.Windows.Forms.Label labelReceiver;
    private System.Windows.Forms.TextBox textBoxDefaultHeader;
    private System.Windows.Forms.Label labelDefaultHeader;
    private System.Windows.Forms.Label labelDefaultHeaderInfo;
    private System.Windows.Forms.CheckBox checkBoxAlwaysUseDefaultSubject;
    private System.Windows.Forms.Label labelAlwaysUseDefaultSubjectInfo;
  }
}
