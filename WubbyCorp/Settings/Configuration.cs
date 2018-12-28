namespace WubbyCorp.Settings {

    public class Configuration {

        /// <summary>
        /// Twitch OAuth token. Default: <see cref="string.Empty"/>
        /// </summary>
        public string OAuthToken { get; set; } = string.Empty;

        /// <summary>
        /// Randomly genrated ID for <see cref="Telemetry"/>. Default: <see cref="string.Empty"/>
        /// </summary>
        public string TelemetryID { get; set; } = string.Empty;

        /// <summary>
        /// Enables/disables <see cref="Telemetry"/>.
        /// </summary>
        public bool TelemetryEnabled { get; set; } = true;

        /// <summary>
        /// How many times the game was launched (started).
        /// </summary>
        public int TimesLaunched { get; set; }

        /// <summary>
        /// When minimized, hide the window.
        /// </summary>
        public bool MinimizeToTray { get; set; } = true;

        /// <summary>
        /// When closed, hide the window.
        /// </summary>
        public bool CloseToTray { get; set; } = true;

        /// <summary>
        /// <see cref="WubbyCorp.MainForm"/> window location [X, Y] and size [Width, Height].
        /// </summary>
        public FormState MainForm { get; set; } = new FormState();

    }

}
