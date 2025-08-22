using Academia.ApiClient;
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

namespace Academia.Desktop.Views.Planes.Modals
{
    public partial class EditarModal : Form
    {
        public EditarModal()
        {
            InitializeComponent();
        }
        private async void EditarModal_Load(object sender, EventArgs e)
        {
            await CargaEspecialidades();
            await CargaPlanes();
        }
        private async Task CargaEspecialidades()
        {
            try
            {
                List<Especialidad> especialidades = (List<Especialidad>)await EspecialidadApiClient.GetAllAsync();
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
        private async Task CargaPlanes()
        {
            try
            {
                List<Plan> planes = (List<Plan>)await PlanApiClient.GetAllAsync();
                this.comboBox2.DataSource = planes;
                this.comboBox2.DisplayMember = "Descripcion";
                this.comboBox2.SelectedIndex = -1;
                this.comboBox2.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = comboBox2.Text;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBox1.SelectedItem is Especialidad && this.comboBox2.SelectedItem is Plan)
                {
                    Especialidad esp = (Especialidad)this.comboBox1.SelectedItem;
                    Plan plan = (Plan)this.comboBox2.SelectedItem;
                    plan.Descripcion = this.textBox1.Text;
                    plan.IdEspecialidad = esp.Id;
                    plan.EspecialidadDescripcion = esp.Descripcion;
                    await PlanApiClient.UpdateAsync(plan);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception("No se Seleccionaron los campos necesarios");
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
    }

}
