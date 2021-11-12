using Newtonsoft.Json;
using System.Collections.Generic;

namespace Plunge.Newtonsoft.ProfileVersions
{
    public class LibraryData
    {
        [JsonProperty("downloads")]
        public Dictionary<string, LibraryArtifact>? Downloads;

        [JsonProperty("extract")]
        public ExtractData? Extract;

        [JsonProperty("name")]
        public string Name = "";

        [JsonProperty("natives")]
        public Dictionary<string, string>? Natives;

        [JsonProperty("rules")]
        public LibraryRule[]? Rules;
    }
}