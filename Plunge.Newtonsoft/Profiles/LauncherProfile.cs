using Newtonsoft.Json;

namespace Plunge.Newtonsoft.Profiles
{
    public class LauncherProfile
    {
        // Some sort of DateTime format.
        /// <summary>
        ///     Point in time the profile was created. A DateTime following the format <c>yyyy-mm-ddThh:mm:ss.msZ</c>.
        /// </summary>
        [JsonProperty("created")]
        public string Created = "";

        /// <summary>
        ///     The game's launch directory. Not always set.
        /// </summary>
        [JsonProperty("gameDir")]
        public string GameDir = "";

        // Can be a traditional name or can be a weird link (base64 I believe?)
        /// <summary>
        ///     The icon. Weird string format.
        /// </summary>
        [JsonProperty("icon")]
        public string Icon = "";

        /// <summary>
        ///     Not always set. The java launch arguments.
        /// </summary>
        [JsonProperty("javaArgs")]
        public string JavaArgs = "";

        // Some sort of DateTime format.
        /// <summary>
        ///     Last time this profile was used. A DateTime following the format <c>yyyy-mm-ddThh:mm:ss.msZ</c>.
        /// </summary>
        [JsonProperty("lastUsed")]
        public string LastUsed = "";

        /// <summary>
        ///     The last known ID of a profile "version" attributed to this profile.
        /// </summary>
        [JsonProperty("lastVersionId")]
        public string LastVersionId = "";

        /// <summary>
        ///     The profile's display name.
        /// </summary>
        [JsonProperty("name")]
        public string Name = "";

        // Probably an enum.
        /// <summary>
        ///     Likely an enum internally; the profile type. Can be custom, release, snapshot, etc.
        /// </summary>
        [JsonProperty("type")]
        public string Type = "";
    }
}