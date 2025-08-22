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
    public partial class EliminarModal : Form
    {
        public EliminarModal()
        {
            InitializeComponent();
        }
        private async Task CargaPlanes()
        {
            try
            {
                List<Plan> planes = (List<Plan>)await PlanApiClient.GetAllAsync();
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
                if (this.comboBox1.SelectedItem is Plan)
                {
                    Plan plan = (Plan)this.comboBox1.SelectedItem;
                    await PlanApiClient.DeleteAsync(plan.Id);
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

        private async void EliminarModal_Load(object sender, EventArgs e)
        {
            await CargaPlanes();
        }
    }
}
