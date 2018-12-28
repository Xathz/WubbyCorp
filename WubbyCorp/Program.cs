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

            if (string.IsNullOrWhiteSpace(SettingsManager.Configuration.OAuthToken)) {
                OAuthForm oauthForm = new OAuthForm();
                oauthForm.ShowDialog();
            }

            Application.Run(new MainForm());
        }

    }

}
