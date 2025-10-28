using Academia.Desktop.Views.Profesores.Modals;
using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Profesores
{
    public partial class ProfesoresForm : Form
    {
        public ProfesoresForm()
        {
            InitializeComponent();
            this.dataGridViewProfesores.AutoGenerateColumns = false;
            this.dataGridViewProfesores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Name = "ID",
            });
            this.dataGridViewProfesores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCompleto",
                HeaderText = "Profesor",
                Name = "Profesor",
            });
            dataGridViewProfesores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Legajo",
                HeaderText = "Legajo",
                Name = "Legajo"
            });

            dataGridViewProfesores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Name = "Email"
            });

            dataGridViewProfesores.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono",
                Name = "Telefono"
            });
        }
        private async void MateriasForm_Load(object sender, EventArgs e)
        {
            await CargaDatos();

        }

        private async Task CargaDatos()
        {
            try
            {
                List<PersonaDto>  profesores = (List<PersonaDto>)await PersonaApiClient.GetProfesoresAsync();
                this.dataGridViewProfesores.DataSource = null;
                this.dataGridViewProfesores.DataSource =  profesores;
                EstadoBotones( profesores);

            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstadoBotones(List<PersonaDto> profesores)
        {
            bool estaVacio = profesores.Count > 0;
            this.toolStripButtonEliminar.Enabled = estaVacio;
            this.toolStripButtonEditar.Enabled = estaVacio;
            this.toolStripButtonGenerarUsuario.Enabled = estaVacio;
        }

        private async void buttonActualizar_Click(object sender, EventArgs e)
        {
            await CargaDatos();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private async void ToolStripButtonGenerarUsuarioClick(object sender, EventArgs e)
        {
            var modal = new GenerarUsuarioModal();
            var generar = modal.ShowDialog();
            if (generar == DialogResult.OK)
                await CargaDatos();
        }
    }
}
