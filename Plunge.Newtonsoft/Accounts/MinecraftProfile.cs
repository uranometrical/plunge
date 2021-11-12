using Newtonsoft.Json;

namespace Plunge.Newtonsoft.Accounts
{
    /// <summary>
    ///     Data for Minecraft accounts.
    /// </summary>
    public class MinecraftProfile
    {
        /// <summary>
        ///     Account GUID.
        /// </summary>
        [JsonProperty("id")]
        public string Id = "";

        /// <summary>
        ///     Account name.
        /// </summary>
        [JsonProperty("name")]
        public string Name = "";
    }
}