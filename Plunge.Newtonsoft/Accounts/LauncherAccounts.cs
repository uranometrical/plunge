using Newtonsoft.Json;

namespace Plunge.Newtonsoft.Accounts
{
    /// <summary>
    ///     Launcher accounts JSON.
    /// </summary>
    public class LauncherAccounts
    {
        [JsonProperty("accounts")]
        public Dictionary<string, LauncherAccount> Accounts = new();

        [JsonProperty("activeAccountLocalId")]
        public string ActiveAccountLocalId = "";

        [JsonProperty("mojangClientToken")]
        public string MojangClientToken = "";
    }
}