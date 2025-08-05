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
using Academia.Desktop.ModalesEspecialidad;
using Academia.Models;
namespace Academia.Desktop
{
    public partial class FormEspecialidad : Form
    {
        private FormMenu _menu;
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5185")
        };
        public FormEspecialidad(FormMenu menu) : base()
        {
            InitializeComponent();
            _menu = menu;
        }
        private async void FormEspecialidad_Load(object sender, EventArgs e)
        {

            await EspecialidadesListar();

        }
        private async Task EspecialidadesListar()
        {
            try
            {
                dgvEspecialidad.Columns.Clear();
                IEnumerable<Especialidad>? especialidades
                   = await _httpClient.GetFromJsonAsync<IEnumerable<Especialidad>>("api/Especialidad");
                if (especialidades != null && especialidades.Any())
                {

                    dgvEspecialidad.ReadOnly = true;
                    dgvEspecialidad.AllowUserToAddRows = false;
                    dgvEspecialidad.AllowUserToDeleteRows = false;
                    dgvEspecialidad.AutoGenerateColumns = false;
                    dgvEspecialidad.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "ID",
                        DataPropertyName = "Id"
                    });
                    dgvEspecialidad.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Descripción",
                        DataPropertyName = "Descripcion"
                    });
                    this.dgvEspecialidad.DataSource = especialidades.ToList();
                }
                else
                    MessageBox.Show("No hay Especialidades cargadas");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Hide();
        }

        private void tlEspecialidad_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void dgvEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void buttonActualizar_Click(object sender, EventArgs e)
        {
            await EspecialidadesListar();
        }

        private async void buttonNew_Click(object sender, EventArgs e)
        {
            var form = new FormNewEspecialidad(_httpClient);
            var agregar = form.ShowDialog();
            if (agregar == DialogResult.OK)
            {
                await EspecialidadesListar();
            }
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {

            var form = new FormUpdateEspecialidad(_httpClient);
            var editar = form.ShowDialog();
            if (editar == DialogResult.OK)
            {
                await EspecialidadesListar();
            }


        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            var form = new FormDeleteEspecialidad(_httpClient);
            var del = form.ShowDialog();
            if (del == DialogResult.OK)
            {
                await EspecialidadesListar();
            }
        }
    }
}
