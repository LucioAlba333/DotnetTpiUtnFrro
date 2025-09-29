using System.Net.Http.Json;
using System.Text.Json;
using Academia.Dtos;

namespace Academia.ApiClient;

public class PlanApiClient : ApiClient
{
    public static async Task<IEnumerable<PlanDto>> GetAllAsync()
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync("api/Plan");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode} - {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var planes = JsonSerializer.Deserialize<IEnumerable<PlanDto>>(json, 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            if (planes == null)
            {
                return [];
            }

            return planes;
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al obtener los planes: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener los planes: {e.Message}");
        }
    }

    public static async Task<PlanDto?> GetAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.GetAsync($"api/Plan/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Status: {response.StatusCode} - {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var plan = JsonSerializer.Deserialize<PlanDto>(json);
            return plan;

        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al obtener el plan con Id {id}: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al obtener el plan con Id {id}: {e.Message}");
        }
    }

    public static async Task AddAsync(PlanDto plan)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PostAsJsonAsync("api/Plan", plan);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al crear plan. Status: {response.StatusCode} - {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al crear Plan: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al crear Plan: {e.Message}");
        }
    }

    public static async Task UpdateAsync(PlanDto plan)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.PutAsJsonAsync("api/Plan/"+plan.Id, plan);
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al actualizar Plan Status: {response.StatusCode} - {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error al actualizar Plan: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al actualizar Plan: {e.Message}");
        }
    }

    public static async Task DeleteAsync(int id)
    {
        try
        {
            using var client = await GetHttpClient();
            var response = await client.DeleteAsync($"api/Plan/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al eliminar el plan. Status: {response.StatusCode} - {error}");
            }
        }
        catch (HttpRequestException e)
        {
            throw new Exception($"Error de conexion al eliminar Plan: {e.Message}");
        }
        catch (TaskCanceledException e)
        {
            throw new Exception($"Timeout al eliminar Plan: {e.Message}");
        }
    }
    
}