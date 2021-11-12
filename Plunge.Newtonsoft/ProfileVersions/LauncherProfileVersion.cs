namespace Plunge.Newtonsoft.ProfileVersions
{
    public class LauncherProfileVersion
    {
        public AssetIndex AssetIndex = new();

        public string Assets = "";

        public Dictionary<string, DownloadData> Downloads = new();

        public string Id = "";

        public LibraryData[] Libraries = Array.Empty<LibraryData>();

        public Dictionary<string, LoggingData> Logging = new();

        public string MainClass = "";

        public string MinecraftArguments = "";

        public int MinimumLauncherVersion;

        public string ReleaseTime = "";

        public string Time = "";

        public string Type = "";
    }
}