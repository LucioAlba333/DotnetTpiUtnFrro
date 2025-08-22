using Academia.ApiClient;
using Academia.Desktop.Views.Planes.Modals;
using Academia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.Desktop.Views.Planes
{
    public partial class PlanesForm : Form
    {
        public PlanesForm()
        {
            InitializeComponent();
            this.dataGridViewPlanes.AutoGenerateColumns = false;
            this.dataGridViewPlanes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Name = "ID"
            });
            this.dataGridViewPlanes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripcion Plan",
                Name = "Descripcion"
            });
            this.dataGridViewPlanes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EspecialidadDescripcion",
                HeaderText = "Especialidad",
                Name = "Especialidad"
            });
        }
        private async void PlanesForm_Load(object sender, EventArgs e)
        {
            await CargaDatos();
        }
        private async Task CargaDatos()
        {
            try
            {
                List<Plan> planes = (List<Plan>)await PlanApiClient.GetAllAsync();
                this.dataGridViewPlanes.DataSource = null;
                this.dataGridViewPlanes.DataSource = planes;
                EstadoBotones(planes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EstadoBotones(List<Plan> p)
        {
            bool estaVacio = p.Count > 0;
            this.toolStripButtonEditar.Enabled = estaVacio;
            this.toolStripButtonEliminar.Enabled = estaVacio;
        }

        private async void buttonActualizar_Click(object sender, EventArgs e)
        {
            await CargaDatos();
        }

        private async void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            var modal = new CrearModal();
            var crear = modal.ShowDialog();
            if (crear == DialogResult.OK)
                await CargaDatos();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            var modal = new EditarModal();
            var editar = modal.ShowDialog();
            if (editar == DialogResult.OK)
                await CargaDatos();
        }

        private async void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            var modal = new EliminarModal();
            var eliminar = modal.ShowDialog();
            if (eliminar == DialogResult.OK)
                await CargaDatos();
        }
    }
}
