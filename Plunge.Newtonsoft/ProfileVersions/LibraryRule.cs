using Newtonsoft.Json;

namespace Plunge.Newtonsoft.ProfileVersions
{
    public class LibraryRule
    {
        [JsonProperty("action")]
        public string? Action;

        [JsonProperty("os")]
        public OperatingSystemRule? Os;
    }
}