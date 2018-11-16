using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace AstralVacancy.WebApi.Infrastructure
{
    public static class ClaimsPrincipalExtensions
    {
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user?.Claims?
                       .FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Typ)?
                       .Value == true.ToString();
        }
    }
}