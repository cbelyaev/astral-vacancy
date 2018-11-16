using System.Text;

namespace AstralVacancy.WebApi.Config
{
    public class JwtConfig
    {
        public string Issuer { get; set; }
        public string Key { get; set; }
        public byte[] KeyBytes => Encoding.UTF8.GetBytes(Key);
        public string Audience => Issuer;
    }
}