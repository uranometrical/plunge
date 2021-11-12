using Newtonsoft.Json;
using System.Collections.Generic;

namespace Plunge.Newtonsoft.Profiles
{
    /// <summary>
    ///     Full launcher profile JSON data.
    /// </summary>
    public class LauncherProfiles
    {
        /// <summary>
        ///     Potentially unused client token.
        /// </summary>
        [JsonProperty("clientToken")]
        public string ClientToken = "";

        /// <summary>
        ///     Version data.
        /// </summary>
        [JsonProperty("launcherVersion")]
        public LauncherVersion LauncherVersion = new();

        /// <summary>
        ///     A (traditionally) GUID-keyed dictionary of <see cref="LauncherProfile"/>s.
        /// </summary>
        [JsonProperty("profiles")]
        public Dictionary<string, LauncherProfile> Profiles = new();

        /// <summary>
        ///     Saved launcher settings.
        /// </summary>
        [JsonProperty("settings")]
        public LauncherSettings Settings = new();
    }
}