using HealthCon.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HealthCon.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly DocCareOnlineContext _context;
        private readonly JWTSetting setting;
        private readonly IRefreshTokenGenerator refreshTokenGenerator;
        public UserController(DocCareOnlineContext context, IOptions<JWTSetting> options, 
            IRefreshTokenGenerator refresh, ILogger<UserController> logger)
        {
            _context = context;
            setting = options.Value;
            refreshTokenGenerator = refresh;
            _logger = logger;
        }
        [HttpGet]
        public TokenResponse Authenticate(string username, Claim[] claims)
        {
          
            TokenResponse tokenResponse = new TokenResponse();
            var tokenkey=Encoding.UTF8.GetBytes(setting.securitykey );
            var tokenhandler = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(tokenkey),SecurityAlgorithms.HmacSha256)
                );
            tokenResponse.JWTToken = new JwtSecurityTokenHandler().WriteToken(tokenhandler);
            tokenResponse.RefreshToken = refreshTokenGenerator.GenerateToken(username);
            return tokenResponse;
        }

        [Route("Authenticate")]
        [HttpPost]
        public IActionResult Authenticate([FromBody] usercred user)
        {
            _logger.LogInformation("Authenticat has been hit with username and password at :{DT} {DO}",         
                DateTime.UtcNow.ToLongTimeString(), DateOnly.FromDateTime(DateTime.Now));
            TokenResponse tokenResponse = new TokenResponse();
            var _user = _context.Users1s.FirstOrDefault(o => o.Userid == user.username && o.Password == user.password);
            if (_user == null)
                return Unauthorized();

            var tokenhandler = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.UTF8.GetBytes(setting.securitykey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                            new Claim(ClaimTypes.Name, "admin"),
                    }
                ),
                Expires = DateTime.Now.AddMinutes(1),
                SigningCredentials = new SigningCredentials(new
                SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256)
            };
            var token = tokenhandler.CreateToken(tokenDescriptor);
            string finaltoken = tokenhandler.WriteToken(token);

            tokenResponse.JWTToken = finaltoken;
            tokenResponse.RefreshToken = refreshTokenGenerator.GenerateToken(user.username);

            _logger.LogInformation("Completed Authentication with successful username and password and JWT Token at :{DT} {DO}",     
                DateTime.UtcNow.ToLongTimeString(), DateOnly.FromDateTime(DateTime.Now));
            return Ok(tokenResponse);
            
        }

        [Route("Refresh")]
        [HttpPost]
        public IActionResult Refresh([FromBody] TokenResponse token)
        {
            var tokenhandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principle = tokenhandler.ValidateToken(token.JWTToken, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(setting.securitykey)),
                ValidateIssuer = false,
                ValidateAudience = false
            }, out securityToken);

            var _token = securityToken as JwtSecurityToken;
            if (_token != null && !_token.Header.Alg.Equals(SecurityAlgorithms.HmacSha256))
            {
                return Unauthorized();
            }
            var username = principle?.Identity?.Name;
            var _reftable = _context.Tblrefreshtokens.FirstOrDefault(x => x.UserId == username && x.Refreshtoken == token.RefreshToken);
            if (null == _reftable)
            {
                return Unauthorized();
            }

            TokenResponse? tokenResponse = (username == null || principle == null) ? null :
                                            Authenticate(username, principle.Claims.ToArray());

            return Ok(tokenResponse);
        }
    }
}
