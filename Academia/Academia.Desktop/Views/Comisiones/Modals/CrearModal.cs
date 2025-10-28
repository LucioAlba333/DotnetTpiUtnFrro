using Academia.ApiClient;

using Academia.Dtos;

namespace Academia.Desktop.Views.Comisiones.Modals
{
    public partial class CrearModal : Form
    {
        public CrearModal()
        {
            InitializeComponent();
        }
        private async void CrearModal_Load(object sender, EventArgs e)
        {
            await CargaDatos();
        }
        private async Task CargaDatos()
        {
            try
            {
                List<PlanDto> planes = (List<PlanDto>)await PlanApiClient.GetAllAsync();
                this.comboBox1.DataSource = planes;
                this.comboBox1.DisplayMember = "Descripcion";
                this.comboBox1.SelectedIndex = -1;
                this.comboBox1.ValueMember = "Id";

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
                if (this.comboBox1.SelectedItem is PlanDto plan)
                {
                    
                    ComisionDto comision = new  ComisionDto()
                    {
                        Descripcion = textBox1.Text,
                        AnioEspecialidad = (int)numericUpDown1.Value,
                        IdPlan = plan.Id,
                        PlanDescripcion = plan.Descripcion,
                    };
                    await ComisionApiClient.AddAsync(comision);
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
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }

}
