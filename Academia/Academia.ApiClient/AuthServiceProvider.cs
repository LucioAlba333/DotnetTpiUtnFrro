namespace Academia.ApiClient;

public static class AuthServiceProvider
{
    private static IAuthService? _instance;
    private static readonly object _lock = new object();

    public static IAuthService Instance
    {
        get
        {
            if (_instance == null)
            {
                throw new InvalidOperationException("AuthService is not registered.");
            }
            return _instance;
        }
    }

    public static void Register(IAuthService authService)
    {
        lock (_lock)
        { 
            _instance = authService;
        }
    }

    public static void Unregister()
    {
        lock (_lock)
        {
            _instance = null;
        }
    }

}