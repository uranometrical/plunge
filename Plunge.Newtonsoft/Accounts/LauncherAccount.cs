using Newtonsoft.Json;
using System;

// TODO: docs

namespace Plunge.Newtonsoft.Accounts
{
    /// <summary>
    ///     Individual account data.
    /// </summary>
    public class LauncherAccount
    {
        [JsonProperty("accessToken")]
        public string AccessToken = "";

        [JsonProperty("accessTokenExpiresAt")]
        public string AccessTokenExpiresAt = "";

        [JsonProperty("avatar")]
        public string Avatar = "";

        [JsonProperty("eligibleForMigration")]
        public bool EligibleForMigration;

        [JsonProperty("hasMultipleProfiles")]
        public bool HasMultipleProfiles;

        [JsonProperty("legacy")]
        public bool Legacy;

        [JsonProperty("localId")]
        public string LocalId = "";

        [JsonProperty("minecraftProfile")]
        public MinecraftProfile MinecraftProfile = new();

        [JsonProperty("persistent")]
        public bool Persistent;

        [JsonProperty("remoteId")]
        public string RemoteId = "";

        [JsonProperty("type")]
        public string Type = "";

        [JsonProperty("userProperties")]
        public object[] UserProperties = Array.Empty<object>();

        [JsonProperty("username")]
        public string Username = "";
    }
}