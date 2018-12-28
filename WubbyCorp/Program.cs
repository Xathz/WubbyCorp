using System;
using System.IO;
using System.Windows.Forms;
using WubbyCorp.Settings;
using WubbyCorp.GameData;

namespace WubbyCorp {

    static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Directory.CreateDirectory(Constants.WorkingDirectory);
            Directory.CreateDirectory(Constants.LogDirectory);

            LoggingManager.Initialize();
            SettingsManager.Load();
            GameDataManager.Load();

            // Process settings
            if (string.IsNullOrWhiteSpace(SettingsManager.Configuration.TelemetryID)) {
                SettingsManager.Configuration.TelemetryID = Guid.NewGuid().ToString();
            }

            SettingsManager.Configuration.TimesLaunched++;

            if (string.IsNullOrWhiteSpace(SettingsManager.Configuration.OAuthToken)) {
                OAuthForm oauthForm = new OAuthForm();
                oauthForm.ShowDialog();
            }

            SettingsManager.Save();
            // ================

            Application.Run(new MainForm());
        }

    }

}
