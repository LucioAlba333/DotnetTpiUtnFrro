using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;

namespace Academia.ApiClient;

public class CursoApiClient : ApiClient
{
    public static async Task<IEnumerable<CursoDto>> GetAllAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync("api/Curso");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var cursos = JsonSerializer.Deserialize<IEnumerable<CursoDto>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return cursos ?? [];
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al obtener los cursos: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener los cursos: {e.Message}");
        }
    }

    public static async Task<CursoDto?> GetAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Curso/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var curso = JsonSerializer.Deserialize<CursoDto>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return curso;
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al obtener el curso con Id {id}: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener el curso con Id {id}: {e.Message}");
        }
    }

    public static async Task AddAsync(CursoDto cursoDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PostAsJsonAsync("api/Curso", cursoDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al crear el curso: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al crear el curso: {e.Message}");
        }
    }

    public static async Task UpdateAsync(CursoDto cursoDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PutAsJsonAsync($"api/Curso/{cursoDto.Id}", cursoDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al editar el curso: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al editar el curso: {e.Message}");
        }
    }

    public static async Task DeleteAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.DeleteAsync($"api/Curso/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al eliminar el curso: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al eliminar el curso: {e.Message}");
        }
    }
}
