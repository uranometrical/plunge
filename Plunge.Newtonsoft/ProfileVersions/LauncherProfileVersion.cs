using Newtonsoft.Json;

namespace Plunge.Newtonsoft.ProfileVersions
{
    public class LauncherProfileVersion
    {
        [JsonProperty("assetIndex")]
        public AssetIndex AssetIndex = new();

        [JsonProperty("assets")]
        public string Assets = "";

        [JsonProperty("downloads")]
        public Dictionary<string, DownloadData> Downloads = new();

        [JsonProperty("id")]
        public string Id = "";

        [JsonProperty("libraries")]
        public LibraryData[] Libraries = Array.Empty<LibraryData>();

        [JsonProperty("logging")]
        public Dictionary<string, LoggingData> Logging = new();

        [JsonProperty("mainClass")]
        public string MainClass = "";

        [JsonProperty("minecraftArguments")]
        public string MinecraftArguments = "";

        [JsonProperty("minimumLauncherVersion")]
        public int MinimumLauncherVersion;

        [JsonProperty("releaseTime")]
        public string ReleaseTime = "";

        [JsonProperty("time")]
        public string Time = "";

        [JsonProperty("type")]
        public string Type = "";
    }
}