using Academia.Data;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
namespace Academia.Services;

public class AuthService
{
    private readonly JwtSettings _jwtSettings;
    private readonly UsuarioRepository _usuarioRepository;

    public AuthService(IOptions<JwtSettings> jwtSettings, UsuarioRepository usuarioRepository)
    {
        _jwtSettings = jwtSettings.Value;
        _usuarioRepository = usuarioRepository;
    }
    
}