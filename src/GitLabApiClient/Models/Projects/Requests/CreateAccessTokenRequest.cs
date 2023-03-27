using System;
using System.Collections.Generic;
using GitLabApiClient.Internal.Utilities;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Projects.Requests
{
    public sealed class CreateAccessTokenRequest
    {
        [JsonProperty("scopes")]
        public string[] Scopes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        [JsonProperty("access_level")]
        public int? AccessLevel { get; set; }
    }
}
