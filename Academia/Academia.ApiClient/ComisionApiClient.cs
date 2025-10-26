using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;

namespace Academia.ApiClient;

public class ComisionApiClient : ApiClient
{
    public static async Task<IEnumerable<ComisionDto>> GetAllAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync("api/Comision");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var comisiones = JsonSerializer.Deserialize<IEnumerable<ComisionDto>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return comisiones ?? [];
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al obtener las comisiones: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener las comisiones: {e.Message}");
        }
    }

    public static async Task<ComisionDto?> GetAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Comision/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var comision = JsonSerializer.Deserialize<ComisionDto>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return comision;
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al obtener la comisión con Id {id}: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener la comisión con Id {id}: {e.Message}");
        }
    }

    public static async Task AddAsync(ComisionDto comisionDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PostAsJsonAsync("api/Comision", comisionDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al crear la comisión: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al crear la comisión: {e.Message}");
        }
    }

    public static async Task UpdateAsync(ComisionDto comisionDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PutAsJsonAsync($"api/Comision/{comisionDto.Id}", comisionDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al editar la comisión: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al editar la comisión: {e.Message}");
        }
    }

    public static async Task DeleteAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.DeleteAsync($"api/Comision/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al eliminar la comisión: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al eliminar la comisión: {e.Message}");
        }
    }
}
