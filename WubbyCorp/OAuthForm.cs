using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WubbyCorp.Settings;

namespace WubbyCorp {

    public partial class OAuthForm : Form {

        public OAuthForm() {
            InitializeComponent();
            Icon = Icon.FromHandle(Properties.Resources.wubbyLEFT.GetHicon());
        }

        private void OAuthForm_Load(object sender, EventArgs e) => BringToFront();

        private void OAuthForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.ApplicationExitCall) { return; }

            if (string.IsNullOrEmpty(SettingsManager.Configuration.OAuthToken)) {
                DialogResult answer = MessageBox.Show($"You never entered your OAuth Token.{Environment.NewLine}If you do not enter one, you can not play the game.{Environment.NewLine}{Environment.NewLine}Are you sure you want to exit?", "No OAuth Token", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (answer == DialogResult.No) {
                    e.Cancel = true;
                } else {
                    Application.Exit(e);
                }
            }
        }

        private void GetOAuthTokenButton_Click(object sender, EventArgs e) {
            GetOAuthTokenButton.Visible = false;
            OAuthTokenPanel.Visible = true;
            OAuthTokenTextBox.Focus();

            try {
                Process.Start("https://wubbycorp.xathz.net/authorize/");
            } catch (Exception ex) {
                LoggingManager.Log.Error(ex);
                MessageBox.Show($@"{ex.Message}{Environment.NewLine}{Environment.NewLine}Visit https://wubbycorp.xathz.net/authorize for the OAuth Token manually.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OAuthTokenTextBox_TextChanged(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(OAuthTokenTextBox.Text)) {
                if (OAuthTokenTextBox.Text.StartsWith("oauth:")) {
                    OAuthTokenTextBox.BackColor = Color.PaleGreen;
                    ContinueButton.Enabled = true;
                } else {
                    OAuthTokenTextBox.BackColor = Color.Salmon;
                    ContinueButton.Enabled = false;
                }
            } else {
                OAuthTokenTextBox.BackColor = SystemColors.Window;
                ContinueButton.Enabled = false;
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e) {
            SettingsManager.Configuration.OAuthToken = OAuthTokenTextBox.Text.Trim();
            Close();
        }

    }

}
