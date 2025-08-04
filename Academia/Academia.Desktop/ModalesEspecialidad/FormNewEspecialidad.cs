using Academia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.Desktop.ModalesEspecialidad
{

    public partial class FormNewEspecialidad : Form
    {
        private readonly HttpClient _httpClient;
        public FormNewEspecialidad(HttpClient httpClient)
        {
            _httpClient = httpClient;
            InitializeComponent();

        }

        private async void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                Especialidad especialidad = new Especialidad
                {
                    Descripcion = textBox1.Text
                };
                var response = await _httpClient.PostAsJsonAsync("api/Especialidad", especialidad);
                if (response.IsSuccessStatusCode)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormNewEspecialidad_Load(object sender, EventArgs e)
        {

        }
    }
}
