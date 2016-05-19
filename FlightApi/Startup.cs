using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using IdentityServer3.AccessTokenValidation;
using System.Security.Claims;
using System.Threading.Tasks;
using System.IdentityModel.Tokens;

[assembly: OwinStartup(typeof(Demo.Startup))]

namespace Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var issuer = "https://steyer-identity-server.azurewebsites.net/identity";
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = issuer
            });

            app.UseBasicAuthentication("DEMO", (user, pwd) => {

                var ok = user == "max" && pwd == "secret";

                if (!ok) return null;

                var claims = new List<Claim>();
                claims.Add(new Claim("sub", "4711"));
                claims.Add(new Claim("name", "max"));

                var result = claims as IEnumerable<Claim>;
                return Task.FromResult(result);
            });

            JwtSecurityTokenHandler.InboundClaimTypeMap = new Dictionary<string, string>();
        }
    }
}
