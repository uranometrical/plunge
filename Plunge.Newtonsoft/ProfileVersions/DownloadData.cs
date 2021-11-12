using Newtonsoft.Json;

namespace Plunge.Newtonsoft.ProfileVersions
{
    public class DownloadData
    {
        [JsonProperty("sha1")]
        public string? Sha1;

        [JsonProperty("size")]
        public int? Size;

        [JsonProperty("url")]
        public string Url = "";
    }
}