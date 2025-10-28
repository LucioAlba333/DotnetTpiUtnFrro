using Academia.ApiClient;
using Academia.Dtos;

namespace Academia.Desktop.Views.Comisiones.Modals
{
    public partial class EditarModal : Form
    {
        private bool _estaCargando;
        public EditarModal()
        {
            InitializeComponent();
        }
        private async void EditarModal_Load(object sender, EventArgs e)
        {
            await CargaDatos();
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
                List<ComisionDto> comisiones = (List<ComisionDto>)await ComisionApiClient.GetAllAsync();
                this.comboBox2.DataSource = comisiones;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBox1.SelectedItem is PlanDto plan && this.comboBox2.SelectedItem is ComisionDto comision)
                {

                    comision.Descripcion = textBox1.Text;
                    comision.AnioEspecialidad = (int)numericUpDown1.Value;
                    comision.IdPlan = plan.Id;
                    comision.PlanDescripcion = plan.Descripcion;
                    await ComisionApiClient.UpdateAsync(comision);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._estaCargando) return;
            if (this.comboBox2.SelectedItem is ComisionDto comision)
            {
                this.textBox1.Text = comision.Descripcion;
                this.numericUpDown1.Value = comision.AnioEspecialidad;
                this.comboBox1.SelectedValue = comision.IdPlan;
            }

        }
    }
}
