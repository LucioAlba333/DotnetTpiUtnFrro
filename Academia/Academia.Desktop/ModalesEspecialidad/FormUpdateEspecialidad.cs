using Academia.Models;
using System;
using System.Collections;
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
    public partial class FormUpdateEspecialidad : Form
    {

        private readonly HttpClient _httpClient;
        public FormUpdateEspecialidad(HttpClient httpClient)
        {

            _httpClient = httpClient;
            InitializeComponent();

        }

        private async void FormUpdateEspecialidad_Load(object sender, EventArgs e)
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
                    comboxEspecialidades.DataSource = especialidades.ToList();
                    comboxEspecialidades.DisplayMember = "Descripcion";
                    comboxEspecialidades.ValueMember = "Id";
                    textBox1.Text = comboxEspecialidades.Text;
                }

            }

            catch (Exception ex) { MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private async void buttonEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboxEspecialidades.SelectedItem is Especialidad esp)
                {
                    esp.Descripcion = textBox1.Text;
                    var response = await _httpClient.PutAsJsonAsync($"api/Especialidad/{esp.Id}", esp);
                    if (response.IsSuccessStatusCode)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void comboxEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboxEspecialidades.Text;
        }
    }
}
