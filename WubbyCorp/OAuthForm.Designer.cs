namespace WubbyCorp {
    partial class OAuthForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OAuthForm));
            this.OAuthTokenTag = new System.Windows.Forms.Label();
            this.OAuthTokenTextBox = new System.Windows.Forms.TextBox();
            this.OAuthExplanationLabel = new System.Windows.Forms.Label();
            this.WubbyCorpPictureBox = new System.Windows.Forms.PictureBox();
            this.WubbyCorpLabel = new System.Windows.Forms.Label();
            this.TheGameLabel = new System.Windows.Forms.Label();
            this.GetOAuthTokenButton = new System.Windows.Forms.Button();
            this.ShareWarningLabel = new System.Windows.Forms.Label();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.OAuthTokenPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.WubbyCorpPictureBox)).BeginInit();
            this.OAuthTokenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OAuthTokenTag
            // 
            this.OAuthTokenTag.AutoSize = true;
            this.OAuthTokenTag.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OAuthTokenTag.Location = new System.Drawing.Point(29, 6);
            this.OAuthTokenTag.Name = "OAuthTokenTag";
            this.OAuthTokenTag.Size = new System.Drawing.Size(77, 15);
            this.OAuthTokenTag.TabIndex = 0;
            this.OAuthTokenTag.Text = "OAuth Token";
            // 
            // OAuthTokenTextBox
            // 
            this.OAuthTokenTextBox.Location = new System.Drawing.Point(32, 24);
            this.OAuthTokenTextBox.Name = "OAuthTokenTextBox";
            this.OAuthTokenTextBox.Size = new System.Drawing.Size(339, 23);
            this.OAuthTokenTextBox.TabIndex = 2;
            this.OAuthTokenTextBox.TextChanged += new System.EventHandler(this.OAuthTokenTextBox_TextChanged);
            // 
            // OAuthExplanationLabel
            // 
            this.OAuthExplanationLabel.Location = new System.Drawing.Point(8, 99);
            this.OAuthExplanationLabel.Name = "OAuthExplanationLabel";
            this.OAuthExplanationLabel.Size = new System.Drawing.Size(409, 167);
            this.OAuthExplanationLabel.TabIndex = 0;
            this.OAuthExplanationLabel.Text = resources.GetString("OAuthExplanationLabel.Text");
            // 
            // WubbyCorpPictureBox
            // 
            this.WubbyCorpPictureBox.ErrorImage = null;
            this.WubbyCorpPictureBox.Image = global::WubbyCorp.Properties.Resources.wubbyMoney;
            this.WubbyCorpPictureBox.InitialImage = null;
            this.WubbyCorpPictureBox.Location = new System.Drawing.Point(95, 9);
            this.WubbyCorpPictureBox.Name = "WubbyCorpPictureBox";
            this.WubbyCorpPictureBox.Size = new System.Drawing.Size(82, 82);
            this.WubbyCorpPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WubbyCorpPictureBox.TabIndex = 4;
            this.WubbyCorpPictureBox.TabStop = false;
            // 
            // WubbyCorpLabel
            // 
            this.WubbyCorpLabel.AutoSize = true;
            this.WubbyCorpLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WubbyCorpLabel.Location = new System.Drawing.Point(159, 16);
            this.WubbyCorpLabel.Name = "WubbyCorpLabel";
            this.WubbyCorpLabel.Size = new System.Drawing.Size(171, 37);
            this.WubbyCorpLabel.TabIndex = 0;
            this.WubbyCorpLabel.Text = "WubbyCorp";
            // 
            // TheGameLabel
            // 
            this.TheGameLabel.AutoSize = true;
            this.TheGameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheGameLabel.Location = new System.Drawing.Point(218, 47);
            this.TheGameLabel.Name = "TheGameLabel";
            this.TheGameLabel.Size = new System.Drawing.Size(110, 30);
            this.TheGameLabel.TabIndex = 0;
            this.TheGameLabel.Text = "The Game";
            // 
            // GetOAuthTokenButton
            // 
            this.GetOAuthTokenButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetOAuthTokenButton.Location = new System.Drawing.Point(148, 281);
            this.GetOAuthTokenButton.Name = "GetOAuthTokenButton";
            this.GetOAuthTokenButton.Size = new System.Drawing.Size(129, 28);
            this.GetOAuthTokenButton.TabIndex = 0;
            this.GetOAuthTokenButton.Text = "Get OAuth Token";
            this.GetOAuthTokenButton.UseVisualStyleBackColor = true;
            this.GetOAuthTokenButton.Click += new System.EventHandler(this.GetOAuthTokenButton_Click);
            // 
            // ShareWarningLabel
            // 
            this.ShareWarningLabel.AutoSize = true;
            this.ShareWarningLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShareWarningLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.ShareWarningLabel.Location = new System.Drawing.Point(158, 6);
            this.ShareWarningLabel.Name = "ShareWarningLabel";
            this.ShareWarningLabel.Size = new System.Drawing.Size(213, 15);
            this.ShareWarningLabel.TabIndex = 0;
            this.ShareWarningLabel.Text = "Do not share your token with anyone";
            // 
            // ContinueButton
            // 
            this.ContinueButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContinueButton.Enabled = false;
            this.ContinueButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(136, 61);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(129, 28);
            this.ContinueButton.TabIndex = 3;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // OAuthTokenPanel
            // 
            this.OAuthTokenPanel.Controls.Add(this.OAuthTokenTextBox);
            this.OAuthTokenPanel.Controls.Add(this.ContinueButton);
            this.OAuthTokenPanel.Controls.Add(this.ShareWarningLabel);
            this.OAuthTokenPanel.Controls.Add(this.OAuthTokenTag);
            this.OAuthTokenPanel.Location = new System.Drawing.Point(12, 274);
            this.OAuthTokenPanel.Name = "OAuthTokenPanel";
            this.OAuthTokenPanel.Size = new System.Drawing.Size(401, 94);
            this.OAuthTokenPanel.TabIndex = 5;
            this.OAuthTokenPanel.Visible = false;
            // 
            // OAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 373);
            this.Controls.Add(this.OAuthTokenPanel);
            this.Controls.Add(this.GetOAuthTokenButton);
            this.Controls.Add(this.WubbyCorpLabel);
            this.Controls.Add(this.WubbyCorpPictureBox);
            this.Controls.Add(this.OAuthExplanationLabel);
            this.Controls.Add(this.TheGameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WubbyCorp Employee Authorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OAuthForm_FormClosing);
            this.Load += new System.EventHandler(this.OAuthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WubbyCorpPictureBox)).EndInit();
            this.OAuthTokenPanel.ResumeLayout(false);
            this.OAuthTokenPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OAuthTokenTag;
        private System.Windows.Forms.TextBox OAuthTokenTextBox;
        private System.Windows.Forms.Label OAuthExplanationLabel;
        private System.Windows.Forms.PictureBox WubbyCorpPictureBox;
        private System.Windows.Forms.Label WubbyCorpLabel;
        private System.Windows.Forms.Label TheGameLabel;
        private System.Windows.Forms.Button GetOAuthTokenButton;
        private System.Windows.Forms.Label ShareWarningLabel;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Panel OAuthTokenPanel;
    }
}