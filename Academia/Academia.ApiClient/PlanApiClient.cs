using System.Net.Http.Json;
using System.Text.Json;
using Academia.Models;

namespace Academia.ApiClient;

public class PlanApiClient
{
    public static async Task<IEnumerable<Plan>> GetAllAsync()
    {
        try
        {
            var response = await ApiClient.Client.GetAsync("api/Plan");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"status: {response.StatusCode} - {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var planes = JsonSerializer.Deserialize<IEnumerable<Plan>>(json, 
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

    public static async Task<Plan?> GetAsync(int id)
    {
        try
        {
            var response = await ApiClient.Client.GetAsync($"api/Plan/{id}");
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Status: {response.StatusCode} - {error}");
            }

            var json = await response.Content.ReadAsStreamAsync();
            var plan = JsonSerializer.Deserialize<Plan>(json);
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

    public static async Task AddAsync(Plan plan)
    {
        try
        {
            var response = await ApiClient.Client.PostAsJsonAsync("api/Plan", plan);
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

    public static async Task UpdateAsync(Plan plan)
    {
        try
        {
            var response = await ApiClient.Client.PutAsJsonAsync("api/Plan/"+plan.Id, plan);
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
            var response = await ApiClient.Client.DeleteAsync($"api/Plan/{id}");
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