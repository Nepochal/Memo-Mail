namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  partial class MiscellaneousPanel
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
      this.checkBoxSendformForeground = new System.Windows.Forms.CheckBox();
      this.labelSendformForeground = new System.Windows.Forms.Label();
      this.labelSendDoubleEnter = new System.Windows.Forms.Label();
      this.checkBoxSendDoubleEnter = new System.Windows.Forms.CheckBox();
      this.labelClipboard2Mail = new System.Windows.Forms.Label();
      this.checkBoxClipboard2Mail = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // labelInfo
      // 
      this.labelInfo.Location = new System.Drawing.Point(4, 4);
      this.labelInfo.Name = "labelInfo";
      this.labelInfo.Size = new System.Drawing.Size(462, 30);
      this.labelInfo.TabIndex = 1;
      this.labelInfo.Text = "Last please choose the following options that influence the behavior and the look" +
    " of the main sending form.";
      // 
      // checkBoxSendformForeground
      // 
      this.checkBoxSendformForeground.AutoSize = true;
      this.checkBoxSendformForeground.Location = new System.Drawing.Point(9, 45);
      this.checkBoxSendformForeground.Name = "checkBoxSendformForeground";
      this.checkBoxSendformForeground.Size = new System.Drawing.Size(218, 17);
      this.checkBoxSendformForeground.TabIndex = 3;
      this.checkBoxSendformForeground.Text = "Keep send form always in the foreground";
      this.checkBoxSendformForeground.UseVisualStyleBackColor = true;
      // 
      // labelSendformForeground
      // 
      this.labelSendformForeground.AutoSize = true;
      this.labelSendformForeground.Location = new System.Drawing.Point(7, 67);
      this.labelSendformForeground.Name = "labelSendformForeground";
      this.labelSendformForeground.Size = new System.Drawing.Size(440, 13);
      this.labelSendformForeground.TabIndex = 4;
      this.labelSendformForeground.Text = "This option forces the sending form to be in the foreground even if you use anoth" +
    "er program.";
      // 
      // labelSendDoubleEnter
      // 
      this.labelSendDoubleEnter.Location = new System.Drawing.Point(7, 119);
      this.labelSendDoubleEnter.Name = "labelSendDoubleEnter";
      this.labelSendDoubleEnter.Size = new System.Drawing.Size(470, 26);
      this.labelSendDoubleEnter.TabIndex = 6;
      this.labelSendDoubleEnter.Text = "With this option you can send your mail by tapping Enter twice instead of clickin" +
    "g the \"Send\"-Button.";
      // 
      // checkBoxSendDoubleEnter
      // 
      this.checkBoxSendDoubleEnter.AutoSize = true;
      this.checkBoxSendDoubleEnter.Location = new System.Drawing.Point(7, 97);
      this.checkBoxSendDoubleEnter.Name = "checkBoxSendDoubleEnter";
      this.checkBoxSendDoubleEnter.Size = new System.Drawing.Size(175, 17);
      this.checkBoxSendDoubleEnter.TabIndex = 5;
      this.checkBoxSendDoubleEnter.Text = "Send the mail with double Enter";
      this.checkBoxSendDoubleEnter.UseVisualStyleBackColor = true;
      // 
      // labelClipboard2Mail
      // 
      this.labelClipboard2Mail.Location = new System.Drawing.Point(7, 184);
      this.labelClipboard2Mail.Name = "labelClipboard2Mail";
      this.labelClipboard2Mail.Size = new System.Drawing.Size(464, 27);
      this.labelClipboard2Mail.TabIndex = 8;
      this.labelClipboard2Mail.Text = "Enabling this option causes the program to auto insert your current clipboard int" +
    "o the mail text when you start Memo-Mail.";
      // 
      // checkBoxClipboard2Mail
      // 
      this.checkBoxClipboard2Mail.AutoSize = true;
      this.checkBoxClipboard2Mail.Location = new System.Drawing.Point(7, 162);
      this.checkBoxClipboard2Mail.Name = "checkBoxClipboard2Mail";
      this.checkBoxClipboard2Mail.Size = new System.Drawing.Size(181, 17);
      this.checkBoxClipboard2Mail.TabIndex = 7;
      this.checkBoxClipboard2Mail.Text = "Auto insert clipboard into the mail";
      this.checkBoxClipboard2Mail.UseVisualStyleBackColor = true;
      // 
      // MiscellaneousPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelClipboard2Mail);
      this.Controls.Add(this.checkBoxClipboard2Mail);
      this.Controls.Add(this.labelSendDoubleEnter);
      this.Controls.Add(this.checkBoxSendDoubleEnter);
      this.Controls.Add(this.labelSendformForeground);
      this.Controls.Add(this.checkBoxSendformForeground);
      this.Controls.Add(this.labelInfo);
      this.Name = "MiscellaneousPanel";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelInfo;
    private System.Windows.Forms.CheckBox checkBoxSendformForeground;
    private System.Windows.Forms.Label labelSendformForeground;
    private System.Windows.Forms.Label labelSendDoubleEnter;
    private System.Windows.Forms.CheckBox checkBoxSendDoubleEnter;
    private System.Windows.Forms.Label labelClipboard2Mail;
    private System.Windows.Forms.CheckBox checkBoxClipboard2Mail;
  }
}
