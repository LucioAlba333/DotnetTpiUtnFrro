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

namespace Academia.Desktop.Views.Especialidades.Modals
{
    public partial class EditarModal : Form
    {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = this.comboBox1.Text;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBox1.SelectedItem is Especialidad)
                {
                    Especialidad esp = (Especialidad)this.comboBox1.SelectedItem;
                    esp.Descripcion = this.textBox1.Text;
                    await EspecialidadApiClient.UpdateAsync(esp);
                    this.DialogResult = DialogResult.OK;
                    this.Close();

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
