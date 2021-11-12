using Newtonsoft.Json;

namespace Plunge.Newtonsoft.Profiles
{
    /// <summary>
    ///     Launcher settings, stored in the profiles JSON.
    /// </summary>
    public class LauncherSettings
    {
        /// <summary>
        ///     Assist with crashes.
        /// </summary>
        [JsonProperty("crashAssistance")]
        public bool CrashAssistance;

        /// <summary>
        ///     Enable advanced mode.
        /// </summary>
        [JsonProperty("enableAdvanced")]
        public bool EnableAdvanced;

        /// <summary>
        ///     Enable analytics.
        /// </summary>
        [JsonProperty("enableAnalytics")]
        public bool EnableAnalytics;

        /// <summary>
        ///     Enable historical versions.
        /// </summary>
        [JsonProperty("enableHistorical")]
        public bool EnableHistorical;

        /// <summary>
        ///     Enable release versions.
        /// </summary>
        [JsonProperty("enableReleases")]
        public bool EnableReleases;

        /// <summary>
        ///     Enable snapshot versions.
        /// </summary>
        [JsonProperty("enableSnapshots")]
        public bool EnableSnapshots;

        /// <summary>
        ///     Keep the launcher open while the game process is running.
        /// </summary>
        [JsonProperty("keepLauncherOpen")]
        public bool KeepLauncherOpen;

        // Pretty sure this is an enum.
        /// <summary>
        ///     Likely an enum internally, the profile sort mode.
        /// </summary>
        [JsonProperty("profileSorting")]
        public string ProfileSorting = "";

        /// <summary>
        ///     Show game logs while the game process is open.
        /// </summary>
        [JsonProperty("showGameLog")]
        public bool ShowGameLog;

        /// <summary>
        ///     TODO
        /// </summary>
        [JsonProperty("showMenu")]
        public bool ShowMenu;

        /// <summary>
        ///     TODO (probably launcher sounds or something)
        /// </summary>
        [JsonProperty("soundOn")]
        public bool SoundOn;
    }
}