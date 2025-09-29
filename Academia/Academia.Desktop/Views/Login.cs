using Academia.ApiClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.Desktop.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada())
            {
                try
                {
                    buttonIngresar.Enabled = false;
                    buttonIngresar.Text = " iniciando sesion";
                    var authService = AuthServiceProvider.Instance;
                    bool succes = await authService.LoginAsync(textBoxUsuario.Text, textBoxContraseña.Text);
                    if (succes)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso invalido",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxContraseña.Clear();
                        textBoxUsuario.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    buttonIngresar.Enabled = true;
                    buttonIngresar.Text = "Ingresar";
                }
            }
        }
        private bool ValidarEntrada()
        {
            errorProvider1.SetError(textBoxUsuario,string.Empty);
            errorProvider1.SetError(textBoxContraseña,string.Empty);
            bool validado = true;
            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                errorProvider1.SetError(textBoxUsuario, "el nombre de usuario es requerido");
                validado = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxContraseña.Text))
            {
                errorProvider1.SetError(textBoxContraseña, "la contraseña es requerida");
            }
            return validado;
        }
    }
}
