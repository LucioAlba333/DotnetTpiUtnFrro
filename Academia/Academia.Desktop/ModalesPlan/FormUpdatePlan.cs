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
    public partial class FormUpdatePlan : Form
    {
        private readonly HttpClient _httpClient;
        public FormUpdatePlan(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
        }
        private async void FormUpdatePlan_Load(object sender, EventArgs e)
        {
            await PlanesListar();
            await EspecialidadesListar();
        }

        private async void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEspecialidades.SelectedItem is Especialidad esp && comboBoxPlanes.SelectedItem is Plan plan)
                {
                    plan.Descripcion = textBox1.Text;
                    plan.Especialidad = esp;
                    plan.IdEspecialidad = esp.Id;
                    var response = await _httpClient.PutAsJsonAsync($"api/Plan/{plan.Id}", plan);
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
        private async Task PlanesListar()
        {
            try
            {
                IEnumerable<Plan>? planes
                    = await _httpClient.GetFromJsonAsync<IEnumerable<Plan>>("api/Plan");
                if (planes != null && planes.Any())
                {
                    comboBoxPlanes.DataSource = planes.ToList();
                    comboBoxPlanes.DisplayMember = "Descripcion";
                    comboBoxPlanes.ValueMember = "Id";
                    textBox1.Text = comboBoxPlanes.Text;

                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void comboBoxPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBoxPlanes.Text;
        }
    }
}
