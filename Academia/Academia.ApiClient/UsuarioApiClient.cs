using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;

namespace Academia.ApiClient;

public class UsuarioApiClient : ApiClient
{
    public static async Task<IEnumerable<UsuarioDto>> GetAllAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync("api/Usuario");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var usuarios = JsonSerializer.Deserialize<IEnumerable<UsuarioDto>>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return usuarios ?? [];
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al obtener los usuarios: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener los usuarios: {e.Message}");
        }
    }

    public static async Task<UsuarioDto?> GetAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Usuario/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var usuario = JsonSerializer.Deserialize<UsuarioDto>(json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return usuario;
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al obtener el usuario con Id {id}: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener el usuario con Id {id}: {e.Message}");
        }
    }

    public static async Task AddAsync(UsuarioCreateDto usuarioCreateDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PostAsJsonAsync("api/Usuario", usuarioCreateDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al crear el usuario: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al crear el usuario: {e.Message}");
        }
    }

    public static async Task UpdateAsync(UsuarioUpdateDto usuarioUpdateDto)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PutAsJsonAsync($"api/Usuario/{usuarioUpdateDto.Id}", usuarioUpdateDto);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al editar el usuario: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al editar el usuario: {e.Message}");
        }
    }

    public static async Task DeleteAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.DeleteAsync($"api/Usuario/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode}, error: {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexión al eliminar el usuario: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al eliminar el usuario: {e.Message}");
        }
    }
}
