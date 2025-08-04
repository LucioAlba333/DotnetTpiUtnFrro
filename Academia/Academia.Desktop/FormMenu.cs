namespace Academia.Desktop
{
    public partial class FormMenu : FormPadre
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
    }
}
