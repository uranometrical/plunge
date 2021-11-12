using Newtonsoft.Json;

namespace Plunge.Newtonsoft.ProfileVersions
{
    public class LibraryData
    {
        [JsonProperty("downloads")]
        public Dictionary<string, LibraryArtifact> Downloads = new();

        [JsonProperty("extract")]
        public ExtractData Extract = new();

        [JsonProperty("name")]
        public string Name = "";

        [JsonProperty("natives")]
        public Dictionary<string, string> Natives = new();

        [JsonProperty("rules")]
        public LibraryRule[] Rules = Array.Empty<LibraryRule>();
    }
}