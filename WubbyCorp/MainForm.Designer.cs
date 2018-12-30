namespace WubbyCorp {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.TrayNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MinimizeToTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToTrayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MenuButton = new System.Windows.Forms.Button();
            this.WubbyCadosTotalLabel = new System.Windows.Forms.Label();
            this.WubbyCadoPictureBox = new System.Windows.Forms.PictureBox();
            this.MenuContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TestMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.company1 = new WubbyCorp.CustomControls.Company();
            this.company2 = new WubbyCorp.CustomControls.Company();
            this.TrayContextMenuStrip.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WubbyCadoPictureBox)).BeginInit();
            this.MenuContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrayNotifyIcon
            // 
            this.TrayNotifyIcon.ContextMenuStrip = this.TrayContextMenuStrip;
            this.TrayNotifyIcon.Text = "WubbyCorp: The Game";
            this.TrayNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayNotifyIcon_MouseClick);
            // 
            // TrayContextMenuStrip
            // 
            this.TrayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MinimizeToTrayMenuItem,
            this.CloseToTrayMenuItem,
            this.ToolStripSeparator1,
            this.ExitMenuItem});
            this.TrayContextMenuStrip.Name = "TrayContextMenuStrip";
            this.TrayContextMenuStrip.Size = new System.Drawing.Size(161, 76);
            // 
            // MinimizeToTrayMenuItem
            // 
            this.MinimizeToTrayMenuItem.CheckOnClick = true;
            this.MinimizeToTrayMenuItem.Name = "MinimizeToTrayMenuItem";
            this.MinimizeToTrayMenuItem.Size = new System.Drawing.Size(160, 22);
            this.MinimizeToTrayMenuItem.Text = "Minimize to tray";
            this.MinimizeToTrayMenuItem.CheckedChanged += new System.EventHandler(this.MinimizeToTrayMenuItem_CheckedChanged);
            // 
            // CloseToTrayMenuItem
            // 
            this.CloseToTrayMenuItem.CheckOnClick = true;
            this.CloseToTrayMenuItem.Name = "CloseToTrayMenuItem";
            this.CloseToTrayMenuItem.Size = new System.Drawing.Size(160, 22);
            this.CloseToTrayMenuItem.Text = "Close to tray";
            this.CloseToTrayMenuItem.CheckedChanged += new System.EventHandler(this.CloseToTrayMenuItem_CheckedChanged);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HeaderPanel.Controls.Add(this.MenuButton);
            this.HeaderPanel.Controls.Add(this.WubbyCadosTotalLabel);
            this.HeaderPanel.Controls.Add(this.WubbyCadoPictureBox);
            this.HeaderPanel.Location = new System.Drawing.Point(-2, -2);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(824, 73);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPanel_Paint);
            // 
            // MenuButton
            // 
            this.MenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuButton.Location = new System.Drawing.Point(713, 24);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(86, 23);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuButton_MouseDown);
            // 
            // WubbyCadosTotalLabel
            // 
            this.WubbyCadosTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WubbyCadosTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.WubbyCadosTotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WubbyCadosTotalLabel.Location = new System.Drawing.Point(65, 10);
            this.WubbyCadosTotalLabel.Name = "WubbyCadosTotalLabel";
            this.WubbyCadosTotalLabel.Size = new System.Drawing.Size(639, 50);
            this.WubbyCadosTotalLabel.TabIndex = 2;
            this.WubbyCadosTotalLabel.Text = "0 WubbyCados";
            this.WubbyCadosTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WubbyCadoPictureBox
            // 
            this.WubbyCadoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.WubbyCadoPictureBox.ErrorImage = null;
            this.WubbyCadoPictureBox.Image = global::WubbyCorp.Properties.Resources.wubbyCado;
            this.WubbyCadoPictureBox.InitialImage = null;
            this.WubbyCadoPictureBox.Location = new System.Drawing.Point(11, 11);
            this.WubbyCadoPictureBox.Name = "WubbyCadoPictureBox";
            this.WubbyCadoPictureBox.Size = new System.Drawing.Size(48, 48);
            this.WubbyCadoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WubbyCadoPictureBox.TabIndex = 2;
            this.WubbyCadoPictureBox.TabStop = false;
            // 
            // MenuContextMenuStrip
            // 
            this.MenuContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestMenuItem});
            this.MenuContextMenuStrip.Name = "MenuContextMenuStrip";
            this.MenuContextMenuStrip.Size = new System.Drawing.Size(157, 26);
            // 
            // TestMenuItem
            // 
            this.TestMenuItem.Name = "TestMenuItem";
            this.TestMenuItem.Size = new System.Drawing.Size(156, 22);
            this.TestMenuItem.Text = "Test menu Item";
            // 
            // company1
            // 
            this.company1.BuyAmount = 1;
            this.company1.BuyButtonEnabled = false;
            this.company1.BuyPrice = 1D;
            this.company1.CompanyDisplayName = "Tiny Hands: Left";
            this.company1.CompanyLevel = "1";
            this.company1.CompanyLogo = global::WubbyCorp.Properties.Resources.wubbyLEFT;
            this.company1.CompanyTagline = "It\'s like a stranger";
            this.company1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company1.Location = new System.Drawing.Point(9, 78);
            this.company1.MarqueeEnabled = false;
            this.company1.Multiplier = 1;
            this.company1.Name = "company1";
            this.company1.Production = 0D;
            this.company1.ProductionInterval = 5000;
            this.company1.Size = new System.Drawing.Size(393, 117);
            this.company1.TabIndex = 2;
            // 
            // company2
            // 
            this.company2.BuyAmount = 1;
            this.company2.BuyButtonEnabled = false;
            this.company2.BuyPrice = 1D;
            this.company2.CompanyDisplayName = "Tiny Hands: Right";
            this.company2.CompanyLevel = "1";
            this.company2.CompanyLogo = global::WubbyCorp.Properties.Resources.wubbyRIGHT;
            this.company2.CompanyTagline = "pp feels so big now";
            this.company2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company2.Location = new System.Drawing.Point(9, 201);
            this.company2.MarqueeEnabled = false;
            this.company2.Multiplier = 1;
            this.company2.Name = "company2";
            this.company2.Production = 0D;
            this.company2.ProductionInterval = 5000;
            this.company2.Size = new System.Drawing.Size(393, 117);
            this.company2.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 592);
            this.Controls.Add(this.company2);
            this.Controls.Add(this.company1);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WubbyCorp: The Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TrayContextMenuStrip.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WubbyCadoPictureBox)).EndInit();
            this.MenuContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon TrayNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip TrayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MinimizeToTrayMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CloseToTrayMenuItem;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox WubbyCadoPictureBox;
        private System.Windows.Forms.Label WubbyCadosTotalLabel;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.ContextMenuStrip MenuContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TestMenuItem;
        private CustomControls.Company company1;
        private CustomControls.Company company2;
    }
}

