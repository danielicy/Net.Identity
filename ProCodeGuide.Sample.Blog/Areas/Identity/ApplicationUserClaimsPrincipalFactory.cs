using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using ProCodeGuide.Sample.Blog.Areas.Identity.Data;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.Blog.Areas.Identity
{
    public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<SampleAppUser>
    {
        public ApplicationUserClaimsPrincipalFactory(
            UserManager<SampleAppUser> userManager,
            IOptions<IdentityOptions> options
            ) : base(userManager, options)
        {

        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(SampleAppUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim("FullName",
                user.FullName
                ));

            return identity;
        }
    }
}
