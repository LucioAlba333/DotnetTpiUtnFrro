using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;

namespace Academia.ApiClient;

public class DocenteCursosApiClient : ApiClient
{
    public static async Task<IEnumerable<DocenteCursosDto>> GetAllAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync("api/DocenteCursos");
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

            var json = await response.Content.ReadAsStreamAsync();
            var docentesCursos = JsonSerializer.Deserialize<IEnumerable<DocenteCursosDto>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return docentesCursos ?? [];
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al obtener los docentes por curso: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener los docentes por curso: {e.Message}");
        }
    }

    public static async Task<DocenteCursosDto?> GetAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/DocenteCursos/{id}");
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

            var json = await response.Content.ReadAsStreamAsync();
            var docenteCurso = JsonSerializer.Deserialize<DocenteCursosDto>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return docenteCurso;
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al obtener el docente del curso con Id {id}: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener el docente del curso con Id {id}: {e.Message}");
        }
    }

    public static async Task AddAsync(DocenteCursosDto docenteCursosDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PostAsJsonAsync("api/DocenteCursos", docenteCursosDto);
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al asignar docente al curso: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al asignar docente al curso: {e.Message}");
        }
    }

    public static async Task UpdateAsync(DocenteCursosDto docenteCursosDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PutAsJsonAsync($"api/DocenteCursos/{docenteCursosDto.Id}", docenteCursosDto);
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al editar la asignación del docente: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al editar la asignación del docente: {e.Message}");
        }
    }

    public static async Task DeleteAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.DeleteAsync($"api/DocenteCursos/{id}");
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al eliminar la asignación del docente: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al eliminar la asignación del docente: {e.Message}");
        }
    }
}
