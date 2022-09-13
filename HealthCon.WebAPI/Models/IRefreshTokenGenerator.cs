namespace HealthCon.WebAPI.Models
{
    public interface IRefreshTokenGenerator
    {
        public string GenerateToken(string username);
    }
}
