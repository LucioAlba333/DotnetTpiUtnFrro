namespace Academia.Desktop
{
    public partial class FormMenu : Form
    {

        public FormMenu() : base()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
        }

        private void buttonEspecialidad_Click(object sender, EventArgs e)
        {
            FormEspecialidad formEspecialidad = new FormEspecialidad(this);
            this.Hide();
            formEspecialidad.Show();

            formEspecialidad.FormClosed += (s, args) => this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            FormPlan formPlan = new FormPlan(this);
            this.Hide();
            formPlan.Show();
            formPlan.FormClosed += (s, args) => this.Close();
        }
    }
}
