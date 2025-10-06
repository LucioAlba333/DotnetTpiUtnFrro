using Academia.ApiClient;
using Academia.Desktop.Views.Especialidades.Modals;
using Academia.Dtos;

namespace Academia.Desktop.Views.Especialidades
{
    public partial class EspecialidadesForm : Form
    {
        public EspecialidadesForm()
        {

            InitializeComponent();
            this.dataGridViewEspecialidades.AutoGenerateColumns = false;
            this.dataGridViewEspecialidades.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Name = "ID"
            });
            this.dataGridViewEspecialidades.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripcion Especialidad",
                Name = "Descripcion"
            });
        }
        private async void EspecialidadesForm_Load(object sender, EventArgs e)
        {
            await CargaDatos();
        }

        private async Task CargaDatos()
        {
            try
            {
                List<EspecialidadDto> especialidades = (List<EspecialidadDto>)await EspecialidadApiClient.GetAllAsync();
                this.dataGridViewEspecialidades.DataSource = null;
                this.dataGridViewEspecialidades.DataSource = especialidades;
                EstadoBotones(especialidades);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EstadoBotones(List<EspecialidadDto> e)
        {
            bool estaVacio = e.Count > 0;
            this.toolStripButtonEditar.Enabled = estaVacio;
            this.toolStripButtonEliminar.Enabled = estaVacio;

        }
        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
