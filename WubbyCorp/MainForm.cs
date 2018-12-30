using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using WubbyCorp.GameData;
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
                Size = SettingsManager.Configuration.MainForm.Size;
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            TrayContextMenuStrip.PerformLayout();
            TrayNotifyIcon.Visible = true;

            WubbyCadosTotalLabel.Text = WubbyCadosManager.TotalFormatted();
            WubbyCadosManager.TotalChanged += WubbyCadosManager_TotalChanged;

#if !DEBUG
            Telemetry.TrackEvent("Launched", "TimesLaunched", SettingsManager.Configuration.TimesLaunched);
#endif
        }

        private void WubbyCadosManager_TotalChanged(object sender, PropertyChangedEventArgs e) {
            WubbyCadosTotalLabel.Text = WubbyCadosManager.TotalFormatted();
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

            GameDataManager.Configuration.WubbyCados = WubbyCadosManager.Total;

            foreach (CustomControls.Company company in Controls.OfType<CustomControls.Company>()) {
                if (GameDataManager.Configuration.Companies.ContainsKey(company.CompanyDisplayNameFormatted())) {
                    GameDataManager.Configuration.Companies[company.CompanyDisplayNameFormatted()] = company;
                } else {
                    GameDataManager.Configuration.Companies.Add(company.CompanyDisplayNameFormatted(), company);
                }
            }

            GameDataManager.Save();
            SettingsManager.Save();
            LoggingManager.Log.Info("Exiting application.");
            LoggingManager.Flush();
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e) {
            using (LinearGradientBrush brush = new LinearGradientBrush(HeaderPanel.ClientRectangle, SystemColors.Control, SystemColors.ControlDark, LinearGradientMode.Vertical)) {
                e.Graphics.FillRectangle(brush, HeaderPanel.ClientRectangle);
            }
        }

        private void MainForm_LocationChanged(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                SettingsManager.Configuration.MainForm.Location = Location;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            HeaderPanel.Refresh();

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

        private void MenuButton_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right) {
                TrayContextMenuStrip.PerformLayout();
                TrayContextMenuStrip.Show(MenuButton, e.Location);
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
