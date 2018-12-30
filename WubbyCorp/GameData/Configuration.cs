using System.Collections.Generic;

namespace WubbyCorp.GameData {

    public class Configuration {

        /// <summary>
        /// Twitch username of the player.
        /// </summary>
        public string TwitchName { get; set; }

        /// <summary>
        /// Total WubbyCados the player has.
        /// </summary>
        public double WubbyCados { get; set; }

        /// <summary>
        /// Companies data.
        /// </summary>
        public Dictionary<string, CustomControls.Company> Companies { get; set; } = new Dictionary<string, CustomControls.Company>();

    }

}
