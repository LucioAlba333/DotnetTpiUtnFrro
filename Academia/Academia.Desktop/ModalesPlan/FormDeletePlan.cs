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

namespace Academia.Desktop.ModalesPlan
{

    public partial class FormDeletePlan : Form
    {
        private readonly HttpClient _httpClient;
        public FormDeletePlan(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
        }

        private async void FormDeletePlan_Load(object sender, EventArgs e)
        {
            await PlanesListar();
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
                }
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPlanes.SelectedItem is Plan plan)
                {
                    var response = await _httpClient.DeleteAsync($"api/Plan/{plan.Id}");
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
