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

namespace Nepochal.MemoMail.ConfigWizard.Panels
{
  partial class SmtpPanel
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
      this.textBoxServer = new System.Windows.Forms.TextBox();
      this.labelServer = new System.Windows.Forms.Label();
      this.labelServerInfo = new System.Windows.Forms.Label();
      this.labelPort = new System.Windows.Forms.Label();
      this.numericUpDownSmtpPort = new System.Windows.Forms.NumericUpDown();
      this.labelPortInfo = new System.Windows.Forms.Label();
      this.textBoxUsername = new System.Windows.Forms.TextBox();
      this.labelUsername = new System.Windows.Forms.Label();
      this.labelUsernameInfo = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmtpPort)).BeginInit();
      this.SuspendLayout();
      // 
      // labelHeader
      // 
      this.labelHeader.Location = new System.Drawing.Point(4, 4);
      this.labelHeader.Name = "labelHeader";
      this.labelHeader.Size = new System.Drawing.Size(473, 28);
      this.labelHeader.TabIndex = 0;
      this.labelHeader.Text = "Please insert your SMTP information.\r\nYou should find this data on the website of" +
    " your e-mail provider.";
      // 
      // textBoxServer
      // 
      this.textBoxServer.Location = new System.Drawing.Point(131, 42);
      this.textBoxServer.Name = "textBoxServer";
      this.textBoxServer.Size = new System.Drawing.Size(164, 20);
      this.textBoxServer.TabIndex = 4;
      this.textBoxServer.TextChanged += new System.EventHandler(this.InputChanged);
      // 
      // labelServer
      // 
      this.labelServer.AutoSize = true;
      this.labelServer.Location = new System.Drawing.Point(53, 45);
      this.labelServer.Name = "labelServer";
      this.labelServer.Size = new System.Drawing.Size(74, 13);
      this.labelServer.TabIndex = 3;
      this.labelServer.Text = "SMTP-Server:";
      // 
      // labelServerInfo
      // 
      this.labelServerInfo.AutoSize = true;
      this.labelServerInfo.Location = new System.Drawing.Point(128, 67);
      this.labelServerInfo.Name = "labelServerInfo";
      this.labelServerInfo.Size = new System.Drawing.Size(212, 13);
      this.labelServerInfo.TabIndex = 5;
      this.labelServerInfo.Text = "In most cases this will be smtp.your-provider";
      // 
      // labelPort
      // 
      this.labelPort.AutoSize = true;
      this.labelPort.Location = new System.Drawing.Point(64, 99);
      this.labelPort.Name = "labelPort";
      this.labelPort.Size = new System.Drawing.Size(62, 13);
      this.labelPort.TabIndex = 6;
      this.labelPort.Text = "SMTP-Port:";
      // 
      // numericUpDownSmtpPort
      // 
      this.numericUpDownSmtpPort.Location = new System.Drawing.Point(131, 97);
      this.numericUpDownSmtpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.numericUpDownSmtpPort.Name = "numericUpDownSmtpPort";
      this.numericUpDownSmtpPort.Size = new System.Drawing.Size(164, 20);
      this.numericUpDownSmtpPort.TabIndex = 8;
      this.numericUpDownSmtpPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
      // 
      // labelPortInfo
      // 
      this.labelPortInfo.AutoSize = true;
      this.labelPortInfo.Location = new System.Drawing.Point(128, 122);
      this.labelPortInfo.Name = "labelPortInfo";
      this.labelPortInfo.Size = new System.Drawing.Size(174, 13);
      this.labelPortInfo.TabIndex = 9;
      this.labelPortInfo.Text = "In most cases this can be left on 25";
      // 
      // textBoxUsername
      // 
      this.textBoxUsername.Location = new System.Drawing.Point(131, 152);
      this.textBoxUsername.Name = "textBoxUsername";
      this.textBoxUsername.Size = new System.Drawing.Size(164, 20);
      this.textBoxUsername.TabIndex = 11;
      this.textBoxUsername.TextChanged += new System.EventHandler(this.InputChanged);
      // 
      // labelUsername
      // 
      this.labelUsername.AutoSize = true;
      this.labelUsername.Location = new System.Drawing.Point(68, 155);
      this.labelUsername.Name = "labelUsername";
      this.labelUsername.Size = new System.Drawing.Size(58, 13);
      this.labelUsername.TabIndex = 10;
      this.labelUsername.Text = "Username:";
      // 
      // labelUsernameInfo
      // 
      this.labelUsernameInfo.AutoSize = true;
      this.labelUsernameInfo.Location = new System.Drawing.Point(128, 177);
      this.labelUsernameInfo.Name = "labelUsernameInfo";
      this.labelUsernameInfo.Size = new System.Drawing.Size(194, 13);
      this.labelUsernameInfo.TabIndex = 12;
      this.labelUsernameInfo.Text = "In most cases this is your e-mail address";
      // 
      // SmtpPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.labelUsernameInfo);
      this.Controls.Add(this.textBoxUsername);
      this.Controls.Add(this.labelUsername);
      this.Controls.Add(this.labelPortInfo);
      this.Controls.Add(this.numericUpDownSmtpPort);
      this.Controls.Add(this.labelPort);
      this.Controls.Add(this.labelServerInfo);
      this.Controls.Add(this.textBoxServer);
      this.Controls.Add(this.labelServer);
      this.Controls.Add(this.labelHeader);
      this.Name = "SmtpPanel";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmtpPort)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelHeader;
    private System.Windows.Forms.TextBox textBoxServer;
    private System.Windows.Forms.Label labelServer;
    private System.Windows.Forms.Label labelServerInfo;
    private System.Windows.Forms.Label labelPort;
    private System.Windows.Forms.NumericUpDown numericUpDownSmtpPort;
    private System.Windows.Forms.Label labelPortInfo;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.Label labelUsername;
    private System.Windows.Forms.Label labelUsernameInfo;
  }
}
