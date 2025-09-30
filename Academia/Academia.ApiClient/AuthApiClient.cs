using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;

namespace Academia.ApiClient;

public class AuthApiClient: ApiClient
{
    public async Task<LoginResponse?> LoginAsync(LoginRequest loginRequest)
    {
        using var client = await GetHttpClient();
        var response = await client.PostAsJsonAsync("api/auth/login", loginRequest);
        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<LoginResponse>(responseContent, 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
        return null;
    }
}