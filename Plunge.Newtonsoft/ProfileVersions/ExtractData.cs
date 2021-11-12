using Newtonsoft.Json;
using System;

namespace Plunge.Newtonsoft.ProfileVersions
{
    public class ExtractData
    {
        [JsonProperty("exclude")]
        public string[]? Exclude;
    }
}