using Academia.ApiClient;
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

namespace Academia.Desktop.Views.Planes.Modals
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
                List<EspecialidadDto> especialidades = (List<EspecialidadDto>)await EspecialidadApiClient.GetAllAsync();
                this.comboBox1.DataSource = especialidades;
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
                if (this.comboBox1.SelectedItem is EspecialidadDto)
                {
                    EspecialidadDto especialidad = (EspecialidadDto)comboBox1.SelectedItem;
                    PlanDto plan = new PlanDto()
                    {
                        Descripcion = this.textBox1.Text,
                        EspecialidadId = especialidad.Id,
                        DescripcionEspecialidad = especialidad.Descripcion,

                    };
                    await PlanApiClient.AddAsync(plan);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception("No se Selecciono una especialidad valida");
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
