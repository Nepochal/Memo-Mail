namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  partial class WelcomePanel
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePanel));
      this.labelText = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelText
      // 
      this.labelText.Location = new System.Drawing.Point(4, 4);
      this.labelText.Name = "labelText";
      this.labelText.Size = new System.Drawing.Size(473, 222);
      this.labelText.TabIndex = 0;
      this.labelText.Text = resources.GetString("labelText.Text");
      // 
      // WelcomePanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelText);
      this.Name = "WelcomePanel";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label labelText;
  }
}
