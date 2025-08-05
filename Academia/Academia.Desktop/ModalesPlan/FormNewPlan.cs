using Academia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.Desktop.ModalesPlan
{
    public partial class FormNewPlan : Form
    {
        private readonly HttpClient _httpClient;
        public FormNewPlan(HttpClient httpClient)
        {
            _httpClient = httpClient;
            InitializeComponent();
        }

        private async void FormNewPlan_Load(object sender, EventArgs e)
        {
            await EspecialidadesListar();
        }

        private async void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEspecialidades.SelectedItem is Especialidad esp)
                {
                    Plan plan = new Plan { Especialidad = esp, Descripcion = textBox1.Text,IdEspecialidad= esp.Id };
                    var response = await _httpClient.PostAsJsonAsync("api/Plan", plan);
                    if (response.IsSuccessStatusCode)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
    }
}
