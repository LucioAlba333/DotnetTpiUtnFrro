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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Academia.Desktop.ModalesEspecialidad
{
    public partial class FormDeleteEspecialidad : Form
    {
        private readonly HttpClient _httpClient;
        public FormDeleteEspecialidad(HttpClient httpClient)
        {
            _httpClient = httpClient;
            InitializeComponent();
        }
        private async void FormDeleteEspecialidad_Load(object sender, EventArgs e)
        {
            await EspecialidadesListar();
        }
        private async Task EspecialidadesListar()
        {
            try
            {
                IEnumerable<Especialidad>? especialidades
                  = await _httpClient.GetFromJsonAsync<IEnumerable<Especialidad>>("api/Especialidad");
                if (especialidades != null && especialidades.Any())
                {
                    comboBoxEspecialidades.DataSource = especialidades.ToList();
                    comboBoxEspecialidades.DisplayMember = "Descripcion";
                    comboBoxEspecialidades.ValueMember = "Id";
                }

            }

            catch (Exception ex) { MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxEspecialidades.SelectedItem is Especialidad esp)
                {
                    var response = await _httpClient.DeleteAsync($"api/Especialidad/{esp.Id}");
                    if (response.IsSuccessStatusCode)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
