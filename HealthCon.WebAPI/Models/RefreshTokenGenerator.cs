using System.Security.Cryptography;
namespace HealthCon.WebAPI.Models
{
    public class RefreshTokenGenerator : IRefreshTokenGenerator
    {
        private readonly DocCareOnlineContext context;

        public RefreshTokenGenerator(DocCareOnlineContext _context)
        {
            context = _context;
        }

        public string GenerateToken(string username)
        {
            var randomnumber = new byte[32];
            using (var randomnumbergenerator = RandomNumberGenerator.Create())
            {
                randomnumbergenerator.GetBytes(randomnumber);
                string RefreshToken = Convert.ToBase64String(randomnumber);

                var _user = context.Tblrefreshtokens.FirstOrDefault(x => x.UserId == username);
                if (_user != null)
                {
                    _user.Refreshtoken = RefreshToken;
                    context.Update(_user);
                }
                else
                {
                    Tblrefreshtoken tblrefreshtoken = new Tblrefreshtoken()
                    {
                        UserId = username,
                        TokenId = new Random().Next().ToString(),
                        Refreshtoken = RefreshToken,
                        IsActive = true
                    };
                    context.Tblrefreshtokens.Add(tblrefreshtoken);  
                }
                var dbS = context.SaveChanges();

                return RefreshToken;
            }
        }
    }
}
