
using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Materias.Modals
{
    public partial class EditarModal : Form
    {
        private bool _estaCargando = false;
        public EditarModal()
        {
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CalculoHoras();
        }

        private void radioButtonAnual_CheckedChanged(object sender, EventArgs e)
        {
            CalculoHoras();
        }

        private void radioButtonCuatri_CheckedChanged(object sender, EventArgs e)
        {
            CalculoHoras();
        }
        private void CalculoHoras()
        {
            int semanas = radioButtonAnual.Checked ? 32 : 16;
            numericUpDown2.Value = semanas * numericUpDown1.Value;
        }
        private async Task CargaDatos()
        {
            try
            {
                this._estaCargando = true;
                List<PlanDto> planes = (List<PlanDto>)await PlanApiClient.GetAllAsync();
                this.comboBox1.DataSource = planes;
                this.comboBox1.DisplayMember = "Descripcion";
                this.comboBox1.SelectedIndex = -1;
                this.comboBox1.ValueMember = "Id";
                List<MateriaDto>  materias = (List<MateriaDto>)await MateriaApiClient.GetAllAsync();
                this.comboBox2.DataSource = materias;
                this.comboBox2.DisplayMember = "Descripcion";
                this.comboBox2.SelectedIndex = -1;
                this.comboBox2.ValueMember = "Id";
                this._estaCargando = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CrearModal_Load(object sender, EventArgs e)
        {
            this.radioButtonAnual.Checked = true;
            CalculoHoras();
            await CargaDatos();
        }

        private async void buttonEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBox1.SelectedItem is PlanDto && this.comboBox2.SelectedItem is MateriaDto)
                {
                    PlanDto plan = (PlanDto)comboBox1.SelectedItem;
                    MateriaDto materia = (MateriaDto) this.comboBox2.SelectedItem;
                    materia.IdPlan = plan.Id;
                    materia.HsSemanales = (int)this.numericUpDown1.Value;
                    materia.HsTotales = (int)this.numericUpDown2.Value;
                    materia.Descripcion = textBox1.Text;
                    materia.PlanDescripcion = plan.Descripcion;
                    await MateriaApiClient.UpdateAsync(materia);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception("No se Selecciono un plan valido");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._estaCargando) return;
            if (this.comboBox2.SelectedItem is MateriaDto)
            {
                MateriaDto materia = (MateriaDto)comboBox2.SelectedItem;
                this.textBox1.Text = materia.Descripcion;
                this.numericUpDown1.Value = (decimal)materia.HsSemanales;
                this.comboBox1.SelectedValue = materia.IdPlan;
            }


        }
    }
}
