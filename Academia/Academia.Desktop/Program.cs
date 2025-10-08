using Academia.ApiClient;
using Academia.Desktop.Views;
using Academia.Auth.WinForms;
namespace Academia.Desktop;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.ThreadException += Application_ThreadException;
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
        MainAsync().GetAwaiter().GetResult();
    }

    static async Task MainAsync()
    {
        var authService = new WinFormsAuthService();
        AuthServiceProvider.Register(authService);
        while (true)
        {
            if (!await authService.IsAuthenticatedAsync())
            {
                var loginForm = new Login();
                if (loginForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }
            try
            {
                Application.Run(new MainForm());
                break;
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "sesion expirada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception is UnauthorizedAccessException)
            {

                MessageBox.Show("la sesion ha expirado. debe volver a ingresar.", "Sesion Expirada", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Restart();
            }
            else
            {
                MessageBox.Show($"Error: {e.Exception.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
}
