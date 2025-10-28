using Academia.ApiClient;
using Academia.Dtos;


namespace Academia.Auth.WinForms;

public class WinFormsAuthService : IAuthService
{
    private static string? _currentToken;
    private static DateTime _tokenExpiration;
    private static string? _currentUsername;
    private static List<string> _currentPermissions = [];
    private static PersonaDto? _currentPersona;

    public event Action<bool>? AuthenticationStateChanged;
    public async Task<bool> IsAuthenticatedAsync()
    {
        return !string.IsNullOrEmpty(_currentToken) && DateTime.UtcNow < _tokenExpiration;
    }

    public async Task<string?> GetTokenAsync()
    {
        var isAuthenticated = await IsAuthenticatedAsync();
        return isAuthenticated ? _currentToken : null;
    }

    public async Task<string?> GetUsernameAsync()
    {
        var isAuthenticated = await IsAuthenticatedAsync();
        return isAuthenticated ? _currentUsername : null;
    }

    public async Task<bool> LoginAsync(string username, string password)
    {
        var request = new LoginRequest
        {
            Username = username,
            Password = password
        };
        var authClient = new AuthApiClient();
        var response = await authClient.LoginAsync(request);
        if (response != null)
        {
            
            _currentToken = response.Token;
            _currentUsername = response.Username;
            _tokenExpiration = response.Expires;
            _currentPermissions = response.Permisos; 
            AuthenticationStateChanged?.Invoke(true);
            _currentPersona = await PersonaApiClient.GetPersonaActualAsync();
            return true;
        }
        return false;
    }

    public async Task LogoutAsync()
    {
        _currentToken = null;
        _currentUsername = null;
        _tokenExpiration = DateTime.MinValue;
        _currentPermissions = [];
        _currentPersona = null;
        AuthenticationStateChanged?.Invoke(false);
    }

    public async Task CheckTokenExpirationAsync()
    {
        if (!string.IsNullOrEmpty(_currentToken) && DateTime.UtcNow >= _tokenExpiration)
        {
            await LogoutAsync();
        }
    }
    public bool HasPermission(string permission)
    {
        return _currentPermissions.Contains(permission);
    }

    public IEnumerable<string> GetPermissions()
    {
        return _currentPermissions.AsReadOnly();
    }

    public async Task<PersonaDto?> GetPersonaActual()
    {
        var isAuthenticated = await IsAuthenticatedAsync();
        return isAuthenticated ? _currentPersona : null;
    }
}