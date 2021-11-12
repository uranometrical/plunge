using Newtonsoft.Json;

namespace Plunge.Newtonsoft.ProfileVersions
{
    public class LibraryArtifact
    {
        public class OperatingSystemArtifact
        {
            [JsonProperty("path")]
            public string Path = "";

            [JsonProperty("sha1")]
            public string Sha1 = "";

            [JsonProperty("size")]
            public int Size;

            [JsonProperty("url")]
            public string Url = "";
        }

        [JsonProperty("path")]
        public string Path = "";

        [JsonProperty("sha1")]
        public string Sha1 = "";

        [JsonProperty("size")]
        public int Size;

        [JsonProperty("url")]
        public string Url = "";

        [JsonProperty("natives-linux")]
        public OperatingSystemArtifact NativesLinux = new();

        [JsonProperty("natives-osx")]
        public OperatingSystemArtifact NativesOsx = new();

        [JsonProperty("natives-windows")]
        public OperatingSystemArtifact NativesWindows = new();
    }
}