using Newtonsoft.Json;

namespace Plunge.Newtonsoft.ProfileVersions
{
    public class LoggingData
    {
        [JsonProperty("argument")]
        public string Argument = "";

        [JsonProperty("file")]
        public LoggingFileData File = new();

        [JsonProperty("type")]
        public string Type = "";
    }
}