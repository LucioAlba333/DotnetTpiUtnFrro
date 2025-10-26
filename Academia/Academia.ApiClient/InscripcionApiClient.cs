using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;

namespace Academia.ApiClient;

public class InscripcionApiClient : ApiClient
{
    public static async Task<IEnumerable<InscripcionDto>> GetAllAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync("api/Inscripcion");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var inscripciones = JsonSerializer.Deserialize<IEnumerable<InscripcionDto>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return inscripciones ?? [];
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al obtener las inscripciones: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener las inscripciones: {e.Message}");
        }
    }

    public static async Task<InscripcionDto?> GetAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Inscripcion/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var inscripcion = JsonSerializer.Deserialize<InscripcionDto>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return inscripcion;
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al obtener la inscripción con Id {id}: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener la inscripción con Id {id}: {e.Message}");
        }
    }

    public static async Task AddAsync(InscripcionDto inscripcionDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PostAsJsonAsync("api/Inscripcion", inscripcionDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al crear la inscripción: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al crear la inscripción: {e.Message}");
        }
    }

    public static async Task UpdateAsync(InscripcionDto inscripcionDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PutAsJsonAsync($"api/Inscripcion/{inscripcionDto.Id}", inscripcionDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al editar la inscripción: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al editar la inscripción: {e.Message}");
        }
    }

    public static async Task DeleteAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.DeleteAsync($"api/Inscripcion/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al eliminar la inscripción: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al eliminar la inscripción: {e.Message}");
        }
    }
}
