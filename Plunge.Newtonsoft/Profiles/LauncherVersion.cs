using Newtonsoft.Json;

namespace Plunge.Newtonsoft.Profiles
{
    /// <summary>
    ///     Launcher version data included in the profiles JSON file.
    /// </summary>
    public class LauncherVersion
    {
        /// <summary>
        ///     The launcher format.
        /// </summary>
        [JsonProperty("format")]
        public int Format;

        /// <summary>
        ///     Potentially unused name.
        /// </summary>
        [JsonProperty("name")]
        public string Name = "";

        /// <summary>
        ///     Profiles data format.
        /// </summary>
        [JsonProperty("profilesFormat")]
        public int ProfilesFormat;
    }
}