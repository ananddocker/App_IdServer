using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;

namespace App_IdServer.OAuth.Configuration
{
    public class InMemoryConfiguration
    {
        public static IEnumerable<ApiResource> ApiResources()
        {
            return new[] { new ApiResource("LoanApplication", "LoanApplication") };
        }

        public static IEnumerable<Client> Clients()
        {
            return new[] { new Client {
                ClientId="anand",
                ClientSecrets= new[] {new Secret("secret".Sha256())},
                AllowedGrantTypes=GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                AllowedScopes=new[]{"LoanApplication"}
            } };
        }

        public static IEnumerable<TestUser> Users()
        {
            return new[] {new TestUser
            {
                SubjectId="1",
                Password="password",
                Username="anand.gangadhara@hotmail.com"
            }};
        }
    }
}
