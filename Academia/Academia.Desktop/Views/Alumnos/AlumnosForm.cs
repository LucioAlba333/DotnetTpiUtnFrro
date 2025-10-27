using Academia.Desktop.Views.Alumnos.Modals;
using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Alumnos
{
    public partial class AlumnosForm : Form
    {
        public AlumnosForm()
        {
            InitializeComponent();
            this.dataGridViewAlumnos.AutoGenerateColumns = false;
            this.dataGridViewAlumnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Name = "ID",
            });
            this.dataGridViewAlumnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NombreCompleto",
                HeaderText = "Alumno",
                Name = "Alumno",
            });
            dataGridViewAlumnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Legajo",
                HeaderText = "Legajo",
                Name = "Legajo"
            });

            dataGridViewAlumnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                Name = "Email"
            });

            dataGridViewAlumnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono",
                Name = "Telefono"
            });

            dataGridViewAlumnos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DescripcionPlan",
                HeaderText = "Plan",
                Name = "Plan"
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
                List<PersonaDto> alumnos = (List<PersonaDto>)await PersonaApiClient.GetAlumnosAsync();
                this.dataGridViewAlumnos.DataSource = null;
                this.dataGridViewAlumnos.DataSource = alumnos;
                EstadoBotones(alumnos);

            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstadoBotones(List<PersonaDto> alumnos)
        {
            bool estaVacio = alumnos.Count > 0;
            this.toolStripButtonEliminar.Enabled = estaVacio;
            this.toolStripButtonEditar.Enabled = estaVacio;
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

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            var modal = new GenerarUsuarioModal();
            var generar = modal.ShowDialog();
            if (generar == DialogResult.OK)
                await CargaDatos();
        }
    }
}
