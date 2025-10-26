using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;


namespace Academia.ApiClient;

public class MateriaApiClient : ApiClient
{
    public static async Task<IEnumerable<MateriaDto>> GetAllAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync("api/Materia");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var materias = JsonSerializer.Deserialize<IEnumerable<MateriaDto>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return materias ?? [];
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al obtener las materias: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al  obtener las materias: {e.Message}");
        }
    }

    public static async Task<MateriaDto?> GetAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Materia/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var materia = JsonSerializer.Deserialize<MateriaDto>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return materia;


        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al obtener la materia con Id {id}: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al  obtener la materia con Id {id}: {e.Message}");
        }
    }

    public static async Task AddAsync(MateriaDto materiaDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PostAsJsonAsync("api/Materia", materiaDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al crear la materia: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al  crear materia: {e.Message}");
        }
    }

    public static async Task UpdateAsync(MateriaDto materiaDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PutAsJsonAsync("api/Materia/" + materiaDto.Id, materiaDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al editar materia: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al  editar materia: {e.Message}");
        }
    }

    public static async Task DeleteAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.DeleteAsync($"api/Materia/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al eliminar materia: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al  eliminar materia: {e.Message}");
        }
    }
}