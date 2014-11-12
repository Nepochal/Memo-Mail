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
*/

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
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemSendMail = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemSeperator1 = new System.Windows.Forms.ToolStripSeparator();
      this.ToolStripMenuItemConfiguration = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItemSepertor2 = new System.Windows.Forms.ToolStripSeparator();
      this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemShortcuts = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.textBoxHeader = new System.Windows.Forms.TextBox();
      this.ToolStripMenuItemConfigWizard = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonSend = new System.Windows.Forms.Button();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxMessage
      // 
      this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxMessage.Location = new System.Drawing.Point(0, 44);
      this.textBoxMessage.Multiline = true;
      this.textBoxMessage.Name = "textBoxMessage";
      this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxMessage.Size = new System.Drawing.Size(354, 147);
      this.textBoxMessage.TabIndex = 2;
      this.textBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyDown);
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ToolStripMenuItemHelp});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(354, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "Menu";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSendMail,
            this.toolStripMenuItemSeperator1,
            this.ToolStripMenuItemConfiguration,
            this.ToolStripMenuItemConfigWizard,
            this.toolStripMenuItemSepertor2,
            this.ToolStripMenuItemExit});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // ToolStripMenuItemSendMail
      // 
      this.ToolStripMenuItemSendMail.Name = "ToolStripMenuItemSendMail";
      this.ToolStripMenuItemSendMail.Size = new System.Drawing.Size(214, 22);
      this.ToolStripMenuItemSendMail.Text = "Send mail";
      this.ToolStripMenuItemSendMail.Click += new System.EventHandler(this.ToolStripMenuItemSendMail_Click);
      // 
      // toolStripMenuItemSeperator1
      // 
      this.toolStripMenuItemSeperator1.Name = "toolStripMenuItemSeperator1";
      this.toolStripMenuItemSeperator1.Size = new System.Drawing.Size(211, 6);
      // 
      // ToolStripMenuItemConfiguration
      // 
      this.ToolStripMenuItemConfiguration.Name = "ToolStripMenuItemConfiguration";
      this.ToolStripMenuItemConfiguration.ShortcutKeys = System.Windows.Forms.Keys.F2;
      this.ToolStripMenuItemConfiguration.Size = new System.Drawing.Size(214, 22);
      this.ToolStripMenuItemConfiguration.Text = "Configuration";
      this.ToolStripMenuItemConfiguration.Click += new System.EventHandler(this.ToolStripMenuItemConfiguration_Click);
      // 
      // toolStripMenuItemSepertor2
      // 
      this.toolStripMenuItemSepertor2.Name = "toolStripMenuItemSepertor2";
      this.toolStripMenuItemSepertor2.Size = new System.Drawing.Size(211, 6);
      // 
      // ToolStripMenuItemExit
      // 
      this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
      this.ToolStripMenuItemExit.Size = new System.Drawing.Size(214, 22);
      this.ToolStripMenuItemExit.Text = "Exit";
      this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
      // 
      // ToolStripMenuItemHelp
      // 
      this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemShortcuts,
            this.ToolStripMenuItemAbout});
      this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
      this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
      this.ToolStripMenuItemHelp.Text = "Help";
      // 
      // ToolStripMenuItemShortcuts
      // 
      this.ToolStripMenuItemShortcuts.Name = "ToolStripMenuItemShortcuts";
      this.ToolStripMenuItemShortcuts.ShortcutKeys = System.Windows.Forms.Keys.F1;
      this.ToolStripMenuItemShortcuts.Size = new System.Drawing.Size(198, 22);
      this.ToolStripMenuItemShortcuts.Text = "Shortcuts";
      this.ToolStripMenuItemShortcuts.Click += new System.EventHandler(this.ToolStripMenuItemShortcuts_Click);
      // 
      // ToolStripMenuItemAbout
      // 
      this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
      this.ToolStripMenuItemAbout.ShortcutKeys = System.Windows.Forms.Keys.F12;
      this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(198, 22);
      this.ToolStripMenuItemAbout.Text = "About Memo-Mail";
      this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
      // 
      // textBoxHeader
      // 
      this.textBoxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxHeader.Location = new System.Drawing.Point(0, 24);
      this.textBoxHeader.Name = "textBoxHeader";
      this.textBoxHeader.Size = new System.Drawing.Size(354, 20);
      this.textBoxHeader.TabIndex = 1;
      // 
      // buttonSend
      // 
      this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonSend.Location = new System.Drawing.Point(273, 197);
      this.buttonSend.Name = "buttonSend";
      this.buttonSend.Size = new System.Drawing.Size(75, 23);
      this.buttonSend.TabIndex = 3;
      this.buttonSend.Text = "Send";
      this.buttonSend.UseVisualStyleBackColor = true;
      this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
      // 
      // ToolStripMenuItemConfigWizard
      // 
      this.ToolStripMenuItemConfigWizard.Name = "ToolStripMenuItemConfigWizard";
      this.ToolStripMenuItemConfigWizard.Size = new System.Drawing.Size(214, 22);
      this.ToolStripMenuItemConfigWizard.Text = "Start Configuration Wizard";
      this.ToolStripMenuItemConfigWizard.Click += new System.EventHandler(this.ToolStripMenuItemConfigWizard_Click);
      // 
      // SendForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(354, 226);
      this.Controls.Add(this.buttonSend);
      this.Controls.Add(this.textBoxHeader);
      this.Controls.Add(this.textBoxMessage);
      this.Controls.Add(this.menuStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStrip;
      this.MaximizeBox = false;
      this.MinimumSize = new System.Drawing.Size(200, 120);
      this.Name = "SendForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Memo-Mail (unstable - in development)";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SendForm_FormClosing);
      this.Load += new System.EventHandler(this.SendForm_Load);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxMessage;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConfiguration;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSendMail;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItemSeperator1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItemSepertor2;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShortcuts;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
    private System.Windows.Forms.TextBox textBoxHeader;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConfigWizard;
    private System.Windows.Forms.Button buttonSend;
  }
}