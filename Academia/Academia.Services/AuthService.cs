using Academia.Data;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Academia.Dtos;
using Academia.Models;

namespace Academia.Services;

public class AuthService
{
    private readonly JwtSettings _jwtSettings;
    private readonly UsuarioRepository _usuarioRepository;
    private readonly PasswordEncrypter _passwordEncrypter;

    public AuthService(IOptions<JwtSettings> jwtSettings,
        UsuarioRepository usuarioRepository, 
        PasswordEncrypter passwordEncrypter)
    {
        _jwtSettings = jwtSettings.Value;
        _usuarioRepository = usuarioRepository;
        _passwordEncrypter = passwordEncrypter;
    }

    public async Task<LoginResponse?> Login(LoginRequest loginRequest)
    {
        if (string.IsNullOrWhiteSpace(loginRequest.Username) || string.IsNullOrWhiteSpace(loginRequest.Password))
            return null;
        var user = await _usuarioRepository.GetByUsername(loginRequest.Username);
        if (user == null)
            return null;
        if (!_passwordEncrypter.Verify(loginRequest.Password, user.Clave))
            return null;
        
        var token = GenerateJwt(user);
        var espiresAt = DateTime.UtcNow.AddMinutes(GetExpirationMinutes());
        return new LoginResponse
        {
            Token = token,
            Expires = espiresAt,
            Username = user.NombreUsuario
        };

    }

    private string GenerateJwt(Usuario user)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key!));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.NombreUsuario),
            new Claim(ClaimTypes.Email, user.Persona.Email),
            new Claim("jti",Guid.NewGuid().ToString())
        };
        var token = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(GetExpirationMinutes()),
            signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public bool ValidateToken(string token)
    {
        try
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key!));
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = _jwtSettings.Issuer,
                ValidateAudience = true,
                ValidAudience = _jwtSettings.Audience,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = key,
                ClockSkew = TimeSpan.Zero
            };
            tokenHandler.ValidateToken(token, validationParameters, out SecurityToken securityToken);
            return true;
        }
        catch 
        {
            return false;
        }
    }

    public int? GetUserIdFromToken(string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var jsonToken = tokenHandler.ReadJwtToken(token);
            var userIdClaim = jsonToken.Claims.First(c => c.Type == ClaimTypes.NameIdentifier);
            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out var userId))
            {
                return userId;
            }
            return null;
        }
        catch
        {
            return null;
        }
    }
    private int GetExpirationMinutes()
    {
        return int.TryParse(_jwtSettings.ExpirationMinutes, out var expirationMinutes) ? expirationMinutes : 60;
    }
}