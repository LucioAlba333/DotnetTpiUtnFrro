namespace Academia.Dtos;

public class LoginResponse
{
    public string Username { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public DateTime Expires { get; set; }
}