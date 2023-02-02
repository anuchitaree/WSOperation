namespace WSOperation
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEST1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationWSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instuctionManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licensedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tEST1ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tEST1ToolStripMenuItem
            // 
            this.tEST1ToolStripMenuItem.Name = "tEST1ToolStripMenuItem";
            this.tEST1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tEST1ToolStripMenuItem.Text = "Start...";
            this.tEST1ToolStripMenuItem.Click += new System.EventHandler(this.tEST1ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationWSToolStripMenuItem,
            this.comPortSettingToolStripMenuItem,
            this.patternSettingToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.setupToolStripMenuItem.Text = "Tool";
            // 
            // registrationWSToolStripMenuItem
            // 
            this.registrationWSToolStripMenuItem.Name = "registrationWSToolStripMenuItem";
            this.registrationWSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrationWSToolStripMenuItem.Text = "Registration WS";
            this.registrationWSToolStripMenuItem.Click += new System.EventHandler(this.registrationWSToolStripMenuItem_Click);
            // 
            // comPortSettingToolStripMenuItem
            // 
            this.comPortSettingToolStripMenuItem.Name = "comPortSettingToolStripMenuItem";
            this.comPortSettingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comPortSettingToolStripMenuItem.Text = "Com port setting";
            this.comPortSettingToolStripMenuItem.Click += new System.EventHandler(this.comPortSettingToolStripMenuItem_Click);
            // 
            // patternSettingToolStripMenuItem
            // 
            this.patternSettingToolStripMenuItem.Name = "patternSettingToolStripMenuItem";
            this.patternSettingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.patternSettingToolStripMenuItem.Text = "Pattern setting";
            this.patternSettingToolStripMenuItem.Click += new System.EventHandler(this.patternSettingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instuctionManualToolStripMenuItem,
            this.licensedToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instuctionManualToolStripMenuItem
            // 
            this.instuctionManualToolStripMenuItem.Name = "instuctionManualToolStripMenuItem";
            this.instuctionManualToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.instuctionManualToolStripMenuItem.Text = "Instuction manual";
            this.instuctionManualToolStripMenuItem.Click += new System.EventHandler(this.instuctionManualToolStripMenuItem_Click);
            // 
            // licensedToolStripMenuItem
            // 
            this.licensedToolStripMenuItem.Name = "licensedToolStripMenuItem";
            this.licensedToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.licensedToolStripMenuItem.Text = "Licensed";
            this.licensedToolStripMenuItem.Click += new System.EventHandler(this.licensedToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 24);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(800, 426);
            this.pnlForm.TabIndex = 1;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem tEST1ToolStripMenuItem;
        private Panel pnlForm;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem setupToolStripMenuItem;
        private ToolStripMenuItem registrationWSToolStripMenuItem;
        private ToolStripMenuItem comPortSettingToolStripMenuItem;
        private ToolStripMenuItem patternSettingToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem instuctionManualToolStripMenuItem;
        private ToolStripMenuItem licensedToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}