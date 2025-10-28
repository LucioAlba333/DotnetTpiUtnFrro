using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;
namespace Academia.ApiClient;

public class EspecialidadApiClient : ApiClient
{
    public static async Task<EspecialidadDto?> GetAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync("api/Especialidad/" + id);
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

            var json = await response.Content.ReadAsStreamAsync();
            var especialidad = JsonSerializer.Deserialize<EspecialidadDto>(json);
            return especialidad;


        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al obtener Especialidad con Id {id}: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener Especialidad con Id {id}: {e.Message}");
        }
        
    }

    public static async Task<IEnumerable<EspecialidadDto>> GetAllAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync("api/Especialidad");
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);

            }
            var json = await response.Content.ReadAsStreamAsync();
            var especialidades = JsonSerializer.Deserialize<IEnumerable<EspecialidadDto>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            if (especialidades == null)
            {
                return [];
            }
            return especialidades;
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al obtener las especialidades: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener Especialidades: {e.Message}");
        }
    }

    public static async Task AddAsync(EspecialidadDto especialidad)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PostAsJsonAsync("api/Especialidad", especialidad);
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al crear Especialidad: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al crear Especialidad: {e.Message}");
        }
    }

    public static async Task UpdateAsync(EspecialidadDto especialidad)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PutAsJsonAsync("api/Especialidad/"+especialidad.Id, especialidad);
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error al actualizar Especialidad: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al actualizar Especialidad: {e.Message}");
        }
    }

    public static async Task DeleteAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.DeleteAsync("api/Especialidad/" + id);
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error al eliminar especialidad: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al eliminar especialidad: {e.Message}");
        }
    }
}