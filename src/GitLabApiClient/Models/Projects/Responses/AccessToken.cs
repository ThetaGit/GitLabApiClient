using System;
using GitLabApiClient.Models.Commits.Responses;
using GitLabApiClient.Models.Pipelines.Responses;
using GitLabApiClient.Models.Runners.Responses;
using GitLabApiClient.Models.Users.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Projects.Responses
{
    public sealed class AccessToken
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("id")]
        public int GroupId { get; set; }

        [JsonProperty("token_id")]
        public int Id { get; set; }

        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("access_level")]
        public int? AccessLevel { get; set; }
    }
}
