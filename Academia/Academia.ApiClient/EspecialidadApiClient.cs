using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;
namespace Academia.ApiClient;

public class EspecialidadApiClient
{
    public static async Task<EspecialidadDto?> GetAsync(int id)
    {
        try
        {
            var response = await ApiClient.Client.GetAsync("api/Especialidad/" + id);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Status: {response.StatusCode} - {error}");
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
            var response = await ApiClient.Client.GetAsync("api/Especialidad");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Status: {response.StatusCode} - {error}");

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
            var response = await ApiClient.Client.PostAsJsonAsync("api/Especialidad", especialidad);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al crear Especialidad. Status: {response.StatusCode} - {error}");
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
            var response = await ApiClient.Client.PutAsJsonAsync("api/Especialidad/"+especialidad.Id, especialidad);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al actualizar Especialidad. Status: {response.StatusCode} - {error}");
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
            var response = await ApiClient.Client.DeleteAsync("api/Especialidad/" + id);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al eliminar especialidad. Status: {response.StatusCode} - {error}");
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