using Newtonsoft.Json;

namespace Plunge.Newtonsoft.ProfileVersions
{
    public class ExtractData
    {
        [JsonProperty("exclude")]
        public string[] Exclude = Array.Empty<string>();
    }
}