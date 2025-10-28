using Academia.ApiClient;
using Academia.Desktop.Views.Comisiones.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia.Dtos;

namespace Academia.Desktop.Views.Comisiones
{
    public partial class ComisionesForm : Form
    {
        public ComisionesForm()
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
                HeaderText = "Descripcion",
                Name = "Descripcion"
            });
            this.dataGridViewPlanes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AnioEspecialidad",
                HeaderText = "Nivel",
                Name = "Nivel"
            });
            this.dataGridViewPlanes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PlanDescripcion",
                HeaderText = "Plan",
                Name = "Plan"
            });
        }
        private async void ComisionesForm_Load(object sender, EventArgs e)
        {
            await CargaDatos();
        }
        private async Task CargaDatos()
        {
            try
            {
                List<ComisionDto> comisiones = (List<ComisionDto>)await ComisionApiClient.GetAllAsync();
                this.dataGridViewPlanes.DataSource = null;
                this.dataGridViewPlanes.DataSource = comisiones;
                EstadoBotones(comisiones);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EstadoBotones(List<ComisionDto> c)
        {
            bool estaVacio = c.Count > 0;
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
