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
            public string? Sha1;

            [JsonProperty("size")]
            public int? Size;

            [JsonProperty("url")]
            public string? Url;
        }

        [JsonProperty("path")]
        public string? Path;

        [JsonProperty("sha1")]
        public string? Sha1;

        [JsonProperty("size")]
        public int? Size;

        [JsonProperty("url")]
        public string? Url;

        [JsonProperty("natives-linux")]
        public OperatingSystemArtifact? NativesLinux;

        [JsonProperty("natives-osx")]
        public OperatingSystemArtifact? NativesOsx;

        [JsonProperty("natives-windows")]
        public OperatingSystemArtifact? NativesWindows;

        [JsonProperty("natives-windows-32")]
        public OperatingSystemArtifact? NativesWindows32;

        [JsonProperty("natives-windows-64")]
        public OperatingSystemArtifact? NativesWindows64;
    }
}