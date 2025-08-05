using Academia.Desktop.ModalesPlan;
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

namespace Academia.Desktop
{
    public partial class FormPlan : Form
    {
        private FormMenu _menu;
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5185")
        };
        public FormPlan(FormMenu menu)
        {
            _menu = menu;
            InitializeComponent();
        }

        private async void buttonActualizar_Click(object sender, EventArgs e)
        {
            await PlanesListar();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Hide();
        }

        private async void buttoNew_Click(object sender, EventArgs e)
        {
            var form = new FormNewPlan(_httpClient);
            var agregar = form.ShowDialog();
            if (agregar == DialogResult.OK)
            {
                await PlanesListar();
            }
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            var form = new FormUpdatePlan(_httpClient);
            var agregar = form.ShowDialog();
            if (agregar == DialogResult.OK)
            {
                await PlanesListar();
            }

        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            var form = new FormDeletePlan(_httpClient);
            var agregar = form.ShowDialog();
            if (agregar == DialogResult.OK)
            {
                await PlanesListar();
            }
        }

        private async void FormPlan_Load(object sender, EventArgs e)
        {
            await PlanesListar();
        }
        private async Task PlanesListar()
        {
            try
            {
                dgvPlanes.Columns.Clear();
                IEnumerable<Plan>? planes
                    = await _httpClient.GetFromJsonAsync<IEnumerable<Plan>>("api/Plan");
                if (planes != null && planes.Any()) 
                {
                    dgvPlanes.ReadOnly = true;
                    dgvPlanes.AllowUserToAddRows = false;
                    dgvPlanes.AllowUserToDeleteRows = false;
                    dgvPlanes.AutoGenerateColumns = false;
                    dgvPlanes.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                    });
                    dgvPlanes.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Descripcion",
                        DataPropertyName = "Descripcion",
                    });
                    dgvPlanes.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "IdEspecialidad",
                        DataPropertyName = "IdEspecialidad",
                    });
                    this.dgvPlanes.DataSource = planes.ToList();
                }
                else
                    MessageBox.Show("No hay Planes cargados");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
