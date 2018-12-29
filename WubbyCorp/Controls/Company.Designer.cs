namespace WubbyCorp.Controls {
    partial class Company {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.CompanyLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CompanyDisplayNameLabel = new System.Windows.Forms.Label();
            this.CompanyTaglineLabel = new System.Windows.Forms.Label();
            this.CompanyLevelLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.ProductionTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyLogoPictureBox
            // 
            this.CompanyLogoPictureBox.ErrorImage = null;
            this.CompanyLogoPictureBox.InitialImage = null;
            this.CompanyLogoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.CompanyLogoPictureBox.Name = "CompanyLogoPictureBox";
            this.CompanyLogoPictureBox.Size = new System.Drawing.Size(75, 75);
            this.CompanyLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompanyLogoPictureBox.TabIndex = 0;
            this.CompanyLogoPictureBox.TabStop = false;
            this.CompanyLogoPictureBox.Click += new System.EventHandler(this.CompanyLogoPictureBox_Click);
            // 
            // CompanyDisplayNameLabel
            // 
            this.CompanyDisplayNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyDisplayNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyDisplayNameLabel.Location = new System.Drawing.Point(81, 3);
            this.CompanyDisplayNameLabel.Name = "CompanyDisplayNameLabel";
            this.CompanyDisplayNameLabel.Size = new System.Drawing.Size(304, 21);
            this.CompanyDisplayNameLabel.TabIndex = 1;
            this.CompanyDisplayNameLabel.Text = "Company Display Name";
            // 
            // CompanyTaglineLabel
            // 
            this.CompanyTaglineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompanyTaglineLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyTaglineLabel.Location = new System.Drawing.Point(89, 24);
            this.CompanyTaglineLabel.Name = "CompanyTaglineLabel";
            this.CompanyTaglineLabel.Size = new System.Drawing.Size(296, 15);
            this.CompanyTaglineLabel.TabIndex = 2;
            this.CompanyTaglineLabel.Text = "Company Tagline";
            // 
            // CompanyLevelLabel
            // 
            this.CompanyLevelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLevelLabel.Location = new System.Drawing.Point(0, 78);
            this.CompanyLevelLabel.Name = "CompanyLevelLabel";
            this.CompanyLevelLabel.Size = new System.Drawing.Size(78, 15);
            this.CompanyLevelLabel.TabIndex = 3;
            this.CompanyLevelLabel.Text = "1";
            this.CompanyLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuyButton
            // 
            this.BuyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuyButton.Enabled = false;
            this.BuyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuyButton.Location = new System.Drawing.Point(84, 55);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(301, 38);
            this.BuyButton.TabIndex = 4;
            this.BuyButton.Text = "Buy (x1) for 1 WubbyCado";
            this.BuyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // ProductionTimer
            // 
            this.ProductionTimer.Interval = 5000;
            this.ProductionTimer.Tick += new System.EventHandler(this.ProductionTimer_Tick);
            // 
            // Subsidiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.CompanyLogoPictureBox);
            this.Controls.Add(this.CompanyLevelLabel);
            this.Controls.Add(this.CompanyTaglineLabel);
            this.Controls.Add(this.CompanyDisplayNameLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Subsidiary";
            this.Size = new System.Drawing.Size(388, 97);
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CompanyLogoPictureBox;
        private System.Windows.Forms.Label CompanyDisplayNameLabel;
        private System.Windows.Forms.Label CompanyTaglineLabel;
        private System.Windows.Forms.Label CompanyLevelLabel;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Timer ProductionTimer;
    }
}
