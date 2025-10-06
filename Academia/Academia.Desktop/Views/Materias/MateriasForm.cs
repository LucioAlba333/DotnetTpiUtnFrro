using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Materias
{
    public partial class MateriasForm : Form
    {
        public MateriasForm()
        {
            InitializeComponent();
            this.dataGridViewMaterias.AutoGenerateColumns = false;
            this.dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ID",
                HeaderText = "ID",
                Name = "ID",
            });
            this.dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descripcion",
                HeaderText = "Descripcion",
                Name = "Descripcion",
            });
            this.dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HsSemanales",
                HeaderText = "HsSemanales",
                Name = "HsSemanales",
            });
            this.dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "HsTotales",
                HeaderText = "HsTotales",
                Name = "HsTotales",
            });
            this.dataGridViewMaterias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PlanDescripcion",
                HeaderText = "Plan",
                Name = "Plan",
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
                List<MateriaDto> materias = (List<MateriaDto>)await MateriaApiClient.GetAllAsync();
                this.dataGridViewMaterias.DataSource = null;
                this.dataGridViewMaterias.DataSource = materias;
                EstadoBotones(materias);

            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EstadoBotones(List<MateriaDto> materias)
        {
            bool estaVacio = materias.Count > 0;
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
    }

}
