using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WubbyCorp.Settings;

namespace WubbyCorp {

    public partial class MainForm : Form {

        private bool _IsExit = false;

        public MainForm() {
            InitializeComponent();

            Icon = Properties.Resources.WubbyCorp;
            TrayNotifyIcon.Icon = Properties.Resources.WubbyCorp;

            // Add title to the right-click context menu
            ToolStripLabel toolStripLabelTitle = new ToolStripLabel {
                Text = Constants.ApplicationName,
                Font = new Font(TrayContextMenuStrip.Font, FontStyle.Bold)
            };
            TrayContextMenuStrip.Items.Insert(0, toolStripLabelTitle);

            // Add version and basic about to the right-click context menu
            ToolStripLabel toolStripLabelInfo = new ToolStripLabel() {
                TextAlign = ContentAlignment.MiddleLeft,
                Text = $"v{Version.Parse(Application.ProductVersion).ToString(3)}, by {Application.CompanyName}{Environment.NewLine}Left-click tray icon to show window",
                ForeColor = SystemColors.ControlDarkDark
            };
            TrayContextMenuStrip.Items.Insert(1, toolStripLabelInfo);

            // Process settings
            MinimizeToTrayMenuItem.Checked = SettingsManager.Configuration.MinimizeToTray;
            CloseToTrayMenuItem.Checked = SettingsManager.Configuration.CloseToTray;

            if (SettingsManager.Configuration.MainForm.IsLocationSet) {
                Location = SettingsManager.Configuration.MainForm.Location;
            } else {
                CenterToScreen();
            }

            if (SettingsManager.Configuration.MainForm.IsSizeSet) {
                Size = SettingsManager.Configuration.MainForm.Size;
            } else {
                SettingsManager.Configuration.MainForm.Size = new Size(800, 600);
                 Size = new Size(800, 600);
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            TrayContextMenuStrip.PerformLayout();
            TrayNotifyIcon.Visible = true;

#if !DEBUG
            Telemetry.TrackEvent("Launched", "TimesLaunched", SettingsManager.Configuration.TimesLaunched);
#endif
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (!_IsExit) {
                if (SettingsManager.Configuration.CloseToTray) {
                    e.Cancel = true;
                    ShowInTaskbar = false;
                    Hide();
                    return;
                }
            }

            SettingsManager.Save();
            LoggingManager.Log.Info("Exiting application.");
            LoggingManager.Flush();
        }

        private void MainForm_LocationChanged(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                SettingsManager.Configuration.MainForm.Location = Location;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            if (SettingsManager.Configuration.MinimizeToTray) {
                if (WindowState == FormWindowState.Normal) {
                    ShowInTaskbar = true;
                } else if (WindowState == FormWindowState.Minimized) {
                    ShowInTaskbar = false;
                }
            }

            if (WindowState == FormWindowState.Normal) {
                SettingsManager.Configuration.MainForm.Size = Size;
            }
        }

        private void TrayNotifyIcon_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                Show();
            }
        }

        private void MinimizeToTrayMenuItem_CheckedChanged(object sender, EventArgs e) {
            SettingsManager.Configuration.MinimizeToTray = MinimizeToTrayMenuItem.Checked;
            if (WindowState == FormWindowState.Minimized) {
                ShowInTaskbar = false;
            }
        }

        private void CloseToTrayMenuItem_CheckedChanged(object sender, EventArgs e) {
            SettingsManager.Configuration.CloseToTray = CloseToTrayMenuItem.Checked;
            if (WindowState == FormWindowState.Minimized) {
                ShowInTaskbar = false;
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e) {
            _IsExit = true;
            Close();
        }

    }

}
