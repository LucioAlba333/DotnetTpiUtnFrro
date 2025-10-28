using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;

namespace Academia.ApiClient;

public class PersonaApiClient : ApiClient
{
    public static async Task<IEnumerable<PersonaDto>> GetAllAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Persona");
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

            var json = await response.Content.ReadAsStreamAsync();
            var personas = JsonSerializer.Deserialize<IEnumerable<PersonaDto>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            if (personas == null)
            {
                return [];
            }

            return personas;

        }
        catch (HttpRequestException e)
        {
            throw new Exception($"error de conexion al obtener las personas: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"timeout al obtener las personas: {e.Message}");
        }
    }
    public static async Task<IEnumerable<PersonaDto>> GetAlumnosAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Persona/alumnos");
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

            var json = await response.Content.ReadAsStreamAsync();
            var personas = JsonSerializer.Deserialize<IEnumerable<PersonaDto>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            if (personas == null)
            {
                return [];
            }

            return personas;

        }
        catch (HttpRequestException e)
        {
            throw new Exception($"error de conexion al obtener las personas: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"timeout al obtener las personas: {e.Message}");
        }
    }
    public static async Task<IEnumerable<PersonaDto>> GetProfesoresAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Persona/profesores");
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

            var json = await response.Content.ReadAsStreamAsync();
            var personas = JsonSerializer.Deserialize<IEnumerable<PersonaDto>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            if (personas == null)
            {
                return [];
            }

            return personas;

        }
        catch (HttpRequestException e)
        {
            throw new Exception($"error de conexion al obtener las personas: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"timeout al obtener las personas: {e.Message}");
        }
    }
    public static async Task<PersonaDto?> GetAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Persona/{id}");
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

            var json = await response.Content.ReadAsStreamAsync();
            var persona = JsonSerializer.Deserialize<PersonaDto>(json);
            return persona;
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"error de conexion al obtener la persona con Id {id}: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"timeout al obtener la persona con Id {id}: {e.Message}");
        }
    }

    public static async Task<PersonaDto?> GetPersonaActualAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Persona/actual");
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

            var json = await response.Content.ReadAsStreamAsync();
            var persona = JsonSerializer.Deserialize<PersonaDto>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return persona;

        }
        catch (HttpRequestException e)
        {
            throw new Exception($"error de conexion al obtener las personas: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"timeout al obtener las personas: {e.Message}");
        }
    }
    public static async Task AddAsync(PersonaDto dto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PostAsJsonAsync("api/Persona", dto);
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"error de conexion al crear persona: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"timeout al crear persona: {e.Message}");
        }
    }

    public static async Task UpdateAsync(PersonaDto dto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PutAsJsonAsync("api/Persona/" + dto.Id, dto);
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al actualizar persona con Id {dto.Id}: {e.Message}");

        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al actualizar persona con Id {dto.Id}: {e.Message}");
        }
    }

    public static async Task DeleteAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.DeleteAsync($"api/Persona/{id}");
            if (!response.IsSuccessStatusCode)
            {
                await ErrorResponse.SendError(response);
            }

        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al eliminar persona con Id {id}: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al eliminar persona con Id {id}: {e.Message}");
        }
    }
    
}