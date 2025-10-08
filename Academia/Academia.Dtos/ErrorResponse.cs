using System.Text.Json;

namespace Academia.Dtos;

public class SimpleError
{
    public string Error { get; set; } = string.Empty;
}

public class ErrorResponse
{
    public string PropertyName { get; set; } = string.Empty;
    public string ErrorMessage { get; set; } = string.Empty;


    public static async Task SendError(HttpResponseMessage response)
    {
        var error = await response.Content.ReadAsStringAsync();
        var tipoError = error.TrimStart();
        string message = string.Empty;
        if (tipoError.StartsWith("["))
        {
            var errorResponse = JsonSerializer.Deserialize<List<ErrorResponse>>(error,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            
            message = errorResponse?.FirstOrDefault()?.ErrorMessage
                      ?? "Error desconocido. por favor intente denuevo";
        }
        else
        {
            var errorResponse =JsonSerializer.Deserialize<SimpleError>(error,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            message = errorResponse?.Error ?? "Error desconocido. por favor intente denuevo";
            
        }

        
        throw new Exception(message);
    }
}

