using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using WubbyCorp.Settings;

namespace WubbyCorp {

    // https://developers.google.com/analytics/devguides/collection/protocol/v1/devguide
    // https://developers.google.com/analytics/devguides/collection/protocol/v1/parameters
    // https://support.google.com/analytics/answer/1033068?hl=en

    internal static class Telemetry {

        /// <summary>
        /// Send an event to Google Analytics.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="label"></param>
        /// <param name="value"></param>
        public static void TrackEvent(string action, string label, int value) => Track("event", action, label, value);

        private static void Track(string type, string action, string label, int value) {
            if (SettingsManager.Configuration.TelemetryEnabled == false) { return; }

            try {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.google-analytics.com/collect");
                request.Method = "POST";

                Dictionary<string, string> postData = new Dictionary<string, string> {
                    { "v", "1" }, // Protocol version
                    { "tid", "UA-131481053-1" }, // Tracking ID
                    { "cid", SettingsManager.Configuration.TelemetryID }, // Anonymous client ID, generated at first run
                    { "t", "event" }, // Type
                    { "ec", "GameApp" }, // Event category
                    { "ea", action }, // Event action
                    { "el", label }, // Event label
                    { "ev", value.ToString() } // Event value
                };

                string postDataString = postData.Aggregate("", (data, next) => $"{data}&{next.Key}={HttpUtility.UrlEncode(next.Value)}").TrimEnd('&');
                request.ContentLength = Encoding.UTF8.GetByteCount(postDataString);

                using (StreamWriter writer = new StreamWriter(request.GetRequestStream())) {
                    writer.WriteAsync(postDataString);
                }

                HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse();
                if (webResponse.StatusCode != HttpStatusCode.OK) {
                    LoggingManager.Log.Error(new HttpException((int)webResponse.StatusCode, "Google Analytics collection did not return OK (200)"));
                }
            } catch (Exception ex) {
                LoggingManager.Log.Error(ex);
            }
        }

    }

}
