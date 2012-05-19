namespace Nepochal.MemoMail
{
  partial class ConfigurationForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPageSmtp = new System.Windows.Forms.TabPage();
      this.textBoxSmtpMail = new System.Windows.Forms.TextBox();
      this.labelSmtpMail = new System.Windows.Forms.Label();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.labelPassword = new System.Windows.Forms.Label();
      this.textBoxUsername = new System.Windows.Forms.TextBox();
      this.labelUsername = new System.Windows.Forms.Label();
      this.textBoxServer = new System.Windows.Forms.TextBox();
      this.labelServer = new System.Windows.Forms.Label();
      this.tabPageReceiver = new System.Windows.Forms.TabPage();
      this.textBoxHeader = new System.Windows.Forms.TextBox();
      this.labelHeader = new System.Windows.Forms.Label();
      this.textBoxPopMail = new System.Windows.Forms.TextBox();
      this.labelPopMail = new System.Windows.Forms.Label();
      this.tabPageAdvanced = new System.Windows.Forms.TabPage();
      this.textBoxFrom = new System.Windows.Forms.TextBox();
      this.labelFrom = new System.Windows.Forms.Label();
      this.numericUpDownSmtpPort = new System.Windows.Forms.NumericUpDown();
      this.labelSmtpPort = new System.Windows.Forms.Label();
      this.buttonAccept = new System.Windows.Forms.Button();
      this.tabControl.SuspendLayout();
      this.tabPageSmtp.SuspendLayout();
      this.tabPageReceiver.SuspendLayout();
      this.tabPageAdvanced.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmtpPort)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.tabPageSmtp);
      this.tabControl.Controls.Add(this.tabPageReceiver);
      this.tabControl.Controls.Add(this.tabPageAdvanced);
      this.tabControl.Location = new System.Drawing.Point(2, 1);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(199, 209);
      this.tabControl.TabIndex = 0;
      // 
      // tabPageSmtp
      // 
      this.tabPageSmtp.Controls.Add(this.textBoxSmtpMail);
      this.tabPageSmtp.Controls.Add(this.labelSmtpMail);
      this.tabPageSmtp.Controls.Add(this.textBoxPassword);
      this.tabPageSmtp.Controls.Add(this.labelPassword);
      this.tabPageSmtp.Controls.Add(this.textBoxUsername);
      this.tabPageSmtp.Controls.Add(this.labelUsername);
      this.tabPageSmtp.Controls.Add(this.textBoxServer);
      this.tabPageSmtp.Controls.Add(this.labelServer);
      this.tabPageSmtp.Location = new System.Drawing.Point(4, 22);
      this.tabPageSmtp.Name = "tabPageSmtp";
      this.tabPageSmtp.Size = new System.Drawing.Size(191, 183);
      this.tabPageSmtp.TabIndex = 0;
      this.tabPageSmtp.Text = "SMTP";
      this.tabPageSmtp.UseVisualStyleBackColor = true;
      // 
      // textBoxSmtpMail
      // 
      this.textBoxSmtpMail.Location = new System.Drawing.Point(10, 151);
      this.textBoxSmtpMail.Name = "textBoxSmtpMail";
      this.textBoxSmtpMail.Size = new System.Drawing.Size(168, 20);
      this.textBoxSmtpMail.TabIndex = 7;
      // 
      // labelSmtpMail
      // 
      this.labelSmtpMail.AutoSize = true;
      this.labelSmtpMail.Location = new System.Drawing.Point(11, 135);
      this.labelSmtpMail.Name = "labelSmtpMail";
      this.labelSmtpMail.Size = new System.Drawing.Size(69, 13);
      this.labelSmtpMail.TabIndex = 6;
      this.labelSmtpMail.Text = "Mail address:";
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.Location = new System.Drawing.Point(10, 109);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.PasswordChar = '*';
      this.textBoxPassword.Size = new System.Drawing.Size(168, 20);
      this.textBoxPassword.TabIndex = 5;
      // 
      // labelPassword
      // 
      this.labelPassword.AutoSize = true;
      this.labelPassword.Location = new System.Drawing.Point(11, 93);
      this.labelPassword.Name = "labelPassword";
      this.labelPassword.Size = new System.Drawing.Size(56, 13);
      this.labelPassword.TabIndex = 4;
      this.labelPassword.Text = "Password:";
      // 
      // textBoxUsername
      // 
      this.textBoxUsername.Location = new System.Drawing.Point(11, 67);
      this.textBoxUsername.Name = "textBoxUsername";
      this.textBoxUsername.Size = new System.Drawing.Size(168, 20);
      this.textBoxUsername.TabIndex = 3;
      // 
      // labelUsername
      // 
      this.labelUsername.AutoSize = true;
      this.labelUsername.Location = new System.Drawing.Point(12, 51);
      this.labelUsername.Name = "labelUsername";
      this.labelUsername.Size = new System.Drawing.Size(58, 13);
      this.labelUsername.TabIndex = 2;
      this.labelUsername.Text = "Username:";
      // 
      // textBoxServer
      // 
      this.textBoxServer.Location = new System.Drawing.Point(11, 25);
      this.textBoxServer.Name = "textBoxServer";
      this.textBoxServer.Size = new System.Drawing.Size(168, 20);
      this.textBoxServer.TabIndex = 1;
      // 
      // labelServer
      // 
      this.labelServer.AutoSize = true;
      this.labelServer.Location = new System.Drawing.Point(12, 9);
      this.labelServer.Name = "labelServer";
      this.labelServer.Size = new System.Drawing.Size(41, 13);
      this.labelServer.TabIndex = 0;
      this.labelServer.Text = "Server:";
      // 
      // tabPageReceiver
      // 
      this.tabPageReceiver.Controls.Add(this.textBoxHeader);
      this.tabPageReceiver.Controls.Add(this.labelHeader);
      this.tabPageReceiver.Controls.Add(this.textBoxPopMail);
      this.tabPageReceiver.Controls.Add(this.labelPopMail);
      this.tabPageReceiver.Location = new System.Drawing.Point(4, 22);
      this.tabPageReceiver.Name = "tabPageReceiver";
      this.tabPageReceiver.Size = new System.Drawing.Size(191, 183);
      this.tabPageReceiver.TabIndex = 1;
      this.tabPageReceiver.Text = "Receiver";
      this.tabPageReceiver.UseVisualStyleBackColor = true;
      // 
      // textBoxHeader
      // 
      this.textBoxHeader.Location = new System.Drawing.Point(11, 67);
      this.textBoxHeader.Name = "textBoxHeader";
      this.textBoxHeader.Size = new System.Drawing.Size(168, 20);
      this.textBoxHeader.TabIndex = 5;
      this.textBoxHeader.Text = "[MemoMail]";
      // 
      // labelHeader
      // 
      this.labelHeader.AutoSize = true;
      this.labelHeader.Location = new System.Drawing.Point(12, 51);
      this.labelHeader.Name = "labelHeader";
      this.labelHeader.Size = new System.Drawing.Size(45, 13);
      this.labelHeader.TabIndex = 4;
      this.labelHeader.Text = "Header:";
      // 
      // textBoxPopMail
      // 
      this.textBoxPopMail.Location = new System.Drawing.Point(11, 25);
      this.textBoxPopMail.Name = "textBoxPopMail";
      this.textBoxPopMail.Size = new System.Drawing.Size(168, 20);
      this.textBoxPopMail.TabIndex = 3;
      // 
      // labelPopMail
      // 
      this.labelPopMail.AutoSize = true;
      this.labelPopMail.Location = new System.Drawing.Point(12, 9);
      this.labelPopMail.Name = "labelPopMail";
      this.labelPopMail.Size = new System.Drawing.Size(69, 13);
      this.labelPopMail.TabIndex = 2;
      this.labelPopMail.Text = "Mail address:";
      // 
      // tabPageAdvanced
      // 
      this.tabPageAdvanced.Controls.Add(this.textBoxFrom);
      this.tabPageAdvanced.Controls.Add(this.labelFrom);
      this.tabPageAdvanced.Controls.Add(this.numericUpDownSmtpPort);
      this.tabPageAdvanced.Controls.Add(this.labelSmtpPort);
      this.tabPageAdvanced.Location = new System.Drawing.Point(4, 22);
      this.tabPageAdvanced.Name = "tabPageAdvanced";
      this.tabPageAdvanced.Size = new System.Drawing.Size(191, 183);
      this.tabPageAdvanced.TabIndex = 2;
      this.tabPageAdvanced.Text = "Advanced";
      this.tabPageAdvanced.UseVisualStyleBackColor = true;
      // 
      // textBoxFrom
      // 
      this.textBoxFrom.Location = new System.Drawing.Point(11, 67);
      this.textBoxFrom.Name = "textBoxFrom";
      this.textBoxFrom.Size = new System.Drawing.Size(168, 20);
      this.textBoxFrom.TabIndex = 6;
      // 
      // labelFrom
      // 
      this.labelFrom.AutoSize = true;
      this.labelFrom.Location = new System.Drawing.Point(12, 51);
      this.labelFrom.Name = "labelFrom";
      this.labelFrom.Size = new System.Drawing.Size(33, 13);
      this.labelFrom.TabIndex = 5;
      this.labelFrom.Text = "From:";
      // 
      // numericUpDownSmtpPort
      // 
      this.numericUpDownSmtpPort.Location = new System.Drawing.Point(11, 25);
      this.numericUpDownSmtpPort.Maximum = new decimal(new int[] {
            49151,
            0,
            0,
            0});
      this.numericUpDownSmtpPort.Name = "numericUpDownSmtpPort";
      this.numericUpDownSmtpPort.Size = new System.Drawing.Size(168, 20);
      this.numericUpDownSmtpPort.TabIndex = 4;
      this.numericUpDownSmtpPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
      // 
      // labelSmtpPort
      // 
      this.labelSmtpPort.AutoSize = true;
      this.labelSmtpPort.Location = new System.Drawing.Point(12, 9);
      this.labelSmtpPort.Name = "labelSmtpPort";
      this.labelSmtpPort.Size = new System.Drawing.Size(62, 13);
      this.labelSmtpPort.TabIndex = 3;
      this.labelSmtpPort.Text = "SMTP-Port:";
      // 
      // buttonAccept
      // 
      this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonAccept.Location = new System.Drawing.Point(107, 216);
      this.buttonAccept.Name = "buttonAccept";
      this.buttonAccept.Size = new System.Drawing.Size(87, 23);
      this.buttonAccept.TabIndex = 1;
      this.buttonAccept.Text = "Accept";
      this.buttonAccept.UseVisualStyleBackColor = true;
      this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
      // 
      // ConfigurationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(200, 244);
      this.Controls.Add(this.buttonAccept);
      this.Controls.Add(this.tabControl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ConfigurationForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Configuration";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configuration_FormClosing);
      this.Load += new System.EventHandler(this.Configuration_Load);
      this.tabControl.ResumeLayout(false);
      this.tabPageSmtp.ResumeLayout(false);
      this.tabPageSmtp.PerformLayout();
      this.tabPageReceiver.ResumeLayout(false);
      this.tabPageReceiver.PerformLayout();
      this.tabPageAdvanced.ResumeLayout(false);
      this.tabPageAdvanced.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSmtpPort)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.Button buttonAccept;
    private System.Windows.Forms.TabPage tabPageSmtp;
    private System.Windows.Forms.TabPage tabPageReceiver;
    private System.Windows.Forms.TabPage tabPageAdvanced;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.Label labelUsername;
    private System.Windows.Forms.TextBox textBoxServer;
    private System.Windows.Forms.Label labelServer;
    private System.Windows.Forms.TextBox textBoxPassword;
    private System.Windows.Forms.Label labelPassword;
    private System.Windows.Forms.TextBox textBoxSmtpMail;
    private System.Windows.Forms.Label labelSmtpMail;
    private System.Windows.Forms.TextBox textBoxPopMail;
    private System.Windows.Forms.Label labelPopMail;
    private System.Windows.Forms.TextBox textBoxHeader;
    private System.Windows.Forms.Label labelHeader;
    private System.Windows.Forms.Label labelSmtpPort;
    private System.Windows.Forms.NumericUpDown numericUpDownSmtpPort;
    private System.Windows.Forms.TextBox textBoxFrom;
    private System.Windows.Forms.Label labelFrom;
  }
}