using System.Net;
using System.Net.Http.Headers;

namespace Academia.ApiClient;

public abstract class ApiClient
{
    protected static async Task<HttpClient> GetHttpClient()
    {
        var client = new HttpClient();
        await ConfigureClientAsync(client);
        return client;
    }

    protected static async Task ConfigureClientAsync(HttpClient client)
    {
        client.BaseAddress = new Uri("http://localhost:5185");
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add
            (new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        await AddAuthorizationHeaders(client);
        
    }

    protected static async Task AddAuthorizationHeaders(HttpClient client)
    {
        var authService = AuthServiceProvider.Instance;
        await authService.CheckTokenExpirationAsync();
        var token = await authService.GetTokenAsync();
        if (!string.IsNullOrEmpty(token))
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
    }

    protected static async Task EnsureAuthenticated()
    {
        var authService = AuthServiceProvider.Instance;
        await authService.CheckTokenExpirationAsync();
        if (!await authService.IsAuthenticatedAsync())
        {
            throw new UnauthorizedAccessException("sesion expirada");
        }
    }

    protected static async Task HandleUnauthorizedResponse(HttpResponseMessage response)
    {
        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            var authService = AuthServiceProvider.Instance;
            await authService.LogoutAsync();
            throw new UnauthorizedAccessException("sesion expirada");
        }
    }
}