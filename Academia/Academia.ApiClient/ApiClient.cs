namespace Academia.ApiClient;

public static class ApiClient
{
    internal static readonly HttpClient Client = new HttpClient();

    static ApiClient()
    {
        Client.BaseAddress = new Uri("http://localhost:5858");
        Client.DefaultRequestHeaders.Accept.Clear();
        Client.DefaultRequestHeaders.Accept.Add
            (new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    }
}