namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  partial class CompletionPanel
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletionPanel));
      this.labelInfo = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelInfo
      // 
      this.labelInfo.Location = new System.Drawing.Point(4, 4);
      this.labelInfo.Name = "labelInfo";
      this.labelInfo.Size = new System.Drawing.Size(471, 218);
      this.labelInfo.TabIndex = 2;
      this.labelInfo.Text = resources.GetString("labelInfo.Text");
      // 
      // CompletionPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelInfo);
      this.Name = "CompletionPanel";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label labelInfo;
  }
}
