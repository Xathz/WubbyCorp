using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WubbyCorp.GameData {

    internal static class GameDataManager {

        /// <summary>
        /// Configuration settings.
        /// </summary>
        public static Configuration Configuration = new Configuration();

        /// <summary>
        /// Load game data from the disk at <see cref="Constants.GameDataFile" />.
        /// </summary>
        public static void Load() {
            if (!File.Exists(Constants.GameDataFile)) {
                LoggingManager.Log.Warn($"Game data file was not found at '{Constants.GameDataFile}', creating default one.");
                Save();
            }

            using (StreamReader jsonFile = File.OpenText(Constants.GameDataFile)) {
                JsonSerializer jsonSerializer = new JsonSerializer();
                Configuration = (Configuration)jsonSerializer.Deserialize(jsonFile, typeof(Configuration));
            }

            LoggingManager.Log.Info("Game data loaded.");
        }

        /// <summary>
        /// Save game data to the disk at <see cref="Constants.GameDataFile" />.
        /// </summary>
        public static void Save() {
            using (StreamWriter streamWriter = new StreamWriter(Constants.GameDataFile))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter)) {
                DefaultContractResolver contractResolver = new DefaultContractResolver {
                    NamingStrategy = new CamelCaseNamingStrategy()
                };

                JsonSerializer jsonSerializer = new JsonSerializer() {
                    ContractResolver = contractResolver,
                    NullValueHandling = NullValueHandling.Include,
                    Formatting = Formatting.Indented,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };

                jsonSerializer.Serialize(jsonWriter, Configuration, typeof(Configuration));
            }

            LoggingManager.Log.Info("Game data saved.");
        }

    }

}
