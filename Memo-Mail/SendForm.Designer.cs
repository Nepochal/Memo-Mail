namespace Nepochal.MemoMail
{
  partial class SendForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendForm));
      this.textBoxMessage = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBoxMessage
      // 
      this.textBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxMessage.Location = new System.Drawing.Point(0, 0);
      this.textBoxMessage.Multiline = true;
      this.textBoxMessage.Name = "textBoxMessage";
      this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxMessage.Size = new System.Drawing.Size(412, 56);
      this.textBoxMessage.TabIndex = 0;
      this.textBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyDown);
      // 
      // SendForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(412, 56);
      this.Controls.Add(this.textBoxMessage);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(92, 45);
      this.Name = "SendForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Memo-Mail";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.SendForm_Load);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendForm_FormClosing);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendForm_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxMessage;
  }
}