using System;
using GitLabApiClient.Models.Projects.Responses;
using GitLabApiClient.Models.Users.Responses;

namespace GitLabApiClient.Internal.Paths
{
    public class AccessTokenId
    {
        private readonly string _id;

        private AccessTokenId(string accessTokenId) => _id = accessTokenId;

        public static implicit operator AccessTokenId(int accessTokenId)
        {
            return new AccessTokenId(accessTokenId.ToString());
        }

        public static implicit operator AccessTokenId(AccessToken accessToken)
        {
            int id = accessToken.Id;
            if (id > 0)
                return new AccessTokenId(id.ToString());

            throw new ArgumentException("Cannot determine access token id from provided AccessToken instance.");
        }

        public override string ToString()
        {
            return _id;
        }
    }
}
