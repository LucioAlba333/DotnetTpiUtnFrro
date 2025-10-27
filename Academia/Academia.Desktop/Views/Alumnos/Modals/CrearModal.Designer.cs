using System.ComponentModel;

namespace Academia.Desktop.Views.Alumnos.Modals;

partial class CrearModal
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new TableLayoutPanel();
        textBoxEmail = new TextBox();
        textBoxTelefono = new TextBox();
        textBoxDireccion = new TextBox();
        textBoxApellido = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        textBoxNombre = new TextBox();
        dateTimePickerNacimiento = new DateTimePicker();
        comboBox1 = new ComboBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        buttonEnviar = new Button();
        buttonCancelar = new Button();
        tableLayoutPanel1.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(textBoxEmail, 1, 4);
        tableLayoutPanel1.Controls.Add(textBoxTelefono, 1, 3);
        tableLayoutPanel1.Controls.Add(textBoxDireccion, 1, 2);
        tableLayoutPanel1.Controls.Add(textBoxApellido, 1, 1);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(label2, 0, 1);
        tableLayoutPanel1.Controls.Add(label3, 0, 2);
        tableLayoutPanel1.Controls.Add(label4, 0, 3);
        tableLayoutPanel1.Controls.Add(label5, 0, 4);
        tableLayoutPanel1.Controls.Add(label6, 0, 5);
        tableLayoutPanel1.Controls.Add(label7, 0, 6);
        tableLayoutPanel1.Controls.Add(textBoxNombre, 1, 0);
        tableLayoutPanel1.Controls.Add(dateTimePickerNacimiento, 1, 5);
        tableLayoutPanel1.Controls.Add(comboBox1, 1, 6);
        tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 7);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 8;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
        tableLayoutPanel1.Size = new Size(484, 561);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Anchor = AnchorStyles.Left;
        textBoxEmail.Location = new Point(245, 303);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(198, 23);
        textBoxEmail.TabIndex = 11;
        // 
        // textBoxTelefono
        // 
        textBoxTelefono.Anchor = AnchorStyles.Left;
        textBoxTelefono.Location = new Point(245, 233);
        textBoxTelefono.Name = "textBoxTelefono";
        textBoxTelefono.Size = new Size(198, 23);
        textBoxTelefono.TabIndex = 10;
        // 
        // textBoxDireccion
        // 
        textBoxDireccion.Anchor = AnchorStyles.Left;
        textBoxDireccion.Location = new Point(245, 163);
        textBoxDireccion.Name = "textBoxDireccion";
        textBoxDireccion.Size = new Size(198, 23);
        textBoxDireccion.TabIndex = 9;
        // 
        // textBoxApellido
        // 
        textBoxApellido.Anchor = AnchorStyles.Left;
        textBoxApellido.Location = new Point(245, 93);
        textBoxApellido.Name = "textBoxApellido";
        textBoxApellido.Size = new Size(198, 23);
        textBoxApellido.TabIndex = 8;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(188, 27);
        label1.Name = "label1";
        label1.Size = new Size(51, 15);
        label1.TabIndex = 0;
        label1.Text = "Nombre";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(188, 97);
        label2.Name = "label2";
        label2.Size = new Size(51, 15);
        label2.TabIndex = 1;
        label2.Text = "Apellido";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(182, 167);
        label3.Name = "label3";
        label3.Size = new Size(57, 15);
        label3.TabIndex = 2;
        label3.Text = "Direccion";
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(187, 237);
        label4.Name = "label4";
        label4.Size = new Size(52, 15);
        label4.TabIndex = 3;
        label4.Text = "Telefono";
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Right;
        label5.AutoSize = true;
        label5.Location = new Point(203, 307);
        label5.Name = "label5";
        label5.Size = new Size(36, 15);
        label5.TabIndex = 4;
        label5.Text = "Email";
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.Right;
        label6.AutoSize = true;
        label6.Location = new Point(122, 377);
        label6.Name = "label6";
        label6.Size = new Size(117, 15);
        label6.TabIndex = 5;
        label6.Text = "Fecha de nacimiento";
        // 
        // label7
        // 
        label7.Anchor = AnchorStyles.Right;
        label7.AutoSize = true;
        label7.Location = new Point(209, 447);
        label7.Name = "label7";
        label7.Size = new Size(30, 15);
        label7.TabIndex = 6;
        label7.Text = "Plan";
        // 
        // textBoxNombre
        // 
        textBoxNombre.Anchor = AnchorStyles.Left;
        textBoxNombre.Location = new Point(245, 23);
        textBoxNombre.Name = "textBoxNombre";
        textBoxNombre.Size = new Size(198, 23);
        textBoxNombre.TabIndex = 7;
        // 
        // dateTimePickerNacimiento
        // 
        dateTimePickerNacimiento.Anchor = AnchorStyles.Left;
        dateTimePickerNacimiento.Location = new Point(245, 373);
        dateTimePickerNacimiento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
        dateTimePickerNacimiento.Size = new Size(227, 23);
        dateTimePickerNacimiento.TabIndex = 12;
        dateTimePickerNacimiento.Value = new DateTime(2025, 10, 26, 22, 43, 19, 0);
        // 
        // comboBox1
        // 
        comboBox1.Anchor = AnchorStyles.Left;
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(245, 443);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(121, 23);
        comboBox1.TabIndex = 13;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.None;
        tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
        flowLayoutPanel1.Controls.Add(buttonEnviar);
        flowLayoutPanel1.Controls.Add(buttonCancelar);
        flowLayoutPanel1.Location = new Point(142, 493);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(200, 65);
        flowLayoutPanel1.TabIndex = 14;
        // 
        // buttonEnviar
        // 
        buttonEnviar.Location = new Point(3, 3);
        buttonEnviar.Name = "buttonEnviar";
        buttonEnviar.Size = new Size(112, 23);
        buttonEnviar.TabIndex = 0;
        buttonEnviar.Text = "Enviar";
        buttonEnviar.UseVisualStyleBackColor = true;
        buttonEnviar.Click += buttonEnviar_Click;
        // 
        // buttonCancelar
        // 
        buttonCancelar.Location = new Point(121, 3);
        buttonCancelar.Name = "buttonCancelar";
        buttonCancelar.Size = new Size(75, 23);
        buttonCancelar.TabIndex = 1;
        buttonCancelar.Text = "Cancelar";
        buttonCancelar.UseVisualStyleBackColor = true;
        buttonCancelar.Click += buttoncancelar_Click;
        // 
        // CrearModal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 561);
        Controls.Add(tableLayoutPanel1);
        MaximumSize = new Size(500, 600);
        MinimumSize = new Size(500, 600);
        Name = "CrearModal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Crear Alumno";
        Load += CrearModal_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        flowLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private TextBox textBoxEmail;
    private TextBox textBoxTelefono;
    private TextBox textBoxDireccion;
    private TextBox textBoxApellido;
    private TextBox textBoxNombre;
    private DateTimePicker dateTimePickerNacimiento;
    private ComboBox comboBox1;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button buttonEnviar;
    private Button buttonCancelar;
}