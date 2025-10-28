using System.ComponentModel;

namespace Academia.Desktop.Views.Profesores.Modals;

partial class EditarModal
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
        flowLayoutPanel1 = new FlowLayoutPanel();
        buttonEnviar = new Button();
        buttonCancelar = new Button();
        label6 = new Label();
        dateTimePickerNacimiento = new DateTimePicker();
        label5 = new Label();
        textBoxEmail = new TextBox();
        label4 = new Label();
        textBoxTelefono = new TextBox();
        label3 = new Label();
        textBoxDireccion = new TextBox();
        label2 = new Label();
        label1 = new Label();
        textBoxNombre = new TextBox();
        label8 = new Label();
        comboBox2 = new ComboBox();
        textBoxApellido = new TextBox();
        tableLayoutPanel1.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(label6, 0, 6);
        tableLayoutPanel1.Controls.Add(dateTimePickerNacimiento, 1, 6);
        tableLayoutPanel1.Controls.Add(label5, 0, 5);
        tableLayoutPanel1.Controls.Add(textBoxEmail, 1, 5);
        tableLayoutPanel1.Controls.Add(label4, 0, 4);
        tableLayoutPanel1.Controls.Add(textBoxTelefono, 1, 4);
        tableLayoutPanel1.Controls.Add(label3, 0, 3);
        tableLayoutPanel1.Controls.Add(textBoxDireccion, 1, 3);
        tableLayoutPanel1.Controls.Add(label2, 0, 2);
        tableLayoutPanel1.Controls.Add(label1, 0, 1);
        tableLayoutPanel1.Controls.Add(textBoxNombre, 1, 1);
        tableLayoutPanel1.Controls.Add(label8, 0, 0);
        tableLayoutPanel1.Controls.Add(comboBox2, 1, 0);
        tableLayoutPanel1.Controls.Add(textBoxApellido, 1, 2);
        tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 7);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 8;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
        tableLayoutPanel1.Size = new Size(484, 561);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.None;
        tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
        flowLayoutPanel1.Controls.Add(buttonEnviar);
        flowLayoutPanel1.Controls.Add(buttonCancelar);
        flowLayoutPanel1.Location = new Point(142, 496);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(200, 59);
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
        // label6
        // 
        label6.Anchor = AnchorStyles.Right;
        label6.AutoSize = true;
        label6.Location = new Point(122, 447);
        label6.Name = "label6";
        label6.Size = new Size(117, 15);
        label6.TabIndex = 5;
        label6.Text = "Fecha de nacimiento";
        // 
        // dateTimePickerNacimiento
        // 
        dateTimePickerNacimiento.Anchor = AnchorStyles.Left;
        dateTimePickerNacimiento.Format = DateTimePickerFormat.Short;
        dateTimePickerNacimiento.Location = new Point(245, 443);
        dateTimePickerNacimiento.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
        dateTimePickerNacimiento.Size = new Size(227, 23);
        dateTimePickerNacimiento.TabIndex = 12;
        dateTimePickerNacimiento.Value = new DateTime(2025, 10, 27, 0, 0, 0, 0);
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Right;
        label5.AutoSize = true;
        label5.Location = new Point(203, 377);
        label5.Name = "label5";
        label5.Size = new Size(36, 15);
        label5.TabIndex = 4;
        label5.Text = "Email";
        // 
        // textBoxEmail
        // 
        textBoxEmail.Anchor = AnchorStyles.Left;
        textBoxEmail.Location = new Point(245, 373);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(227, 23);
        textBoxEmail.TabIndex = 11;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(187, 307);
        label4.Name = "label4";
        label4.Size = new Size(52, 15);
        label4.TabIndex = 3;
        label4.Text = "Telefono";
        // 
        // textBoxTelefono
        // 
        textBoxTelefono.Anchor = AnchorStyles.Left;
        textBoxTelefono.Location = new Point(245, 303);
        textBoxTelefono.Name = "textBoxTelefono";
        textBoxTelefono.Size = new Size(227, 23);
        textBoxTelefono.TabIndex = 10;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(182, 237);
        label3.Name = "label3";
        label3.Size = new Size(57, 15);
        label3.TabIndex = 2;
        label3.Text = "Direccion";
        // 
        // textBoxDireccion
        // 
        textBoxDireccion.Anchor = AnchorStyles.Left;
        textBoxDireccion.Location = new Point(245, 233);
        textBoxDireccion.Name = "textBoxDireccion";
        textBoxDireccion.Size = new Size(227, 23);
        textBoxDireccion.TabIndex = 9;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(188, 167);
        label2.Name = "label2";
        label2.Size = new Size(51, 15);
        label2.TabIndex = 1;
        label2.Text = "Apellido";
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(188, 97);
        label1.Name = "label1";
        label1.Size = new Size(51, 15);
        label1.TabIndex = 0;
        label1.Text = "Nombre";
        // 
        // textBoxNombre
        // 
        textBoxNombre.Anchor = AnchorStyles.Left;
        textBoxNombre.Location = new Point(245, 93);
        textBoxNombre.Name = "textBoxNombre";
        textBoxNombre.Size = new Size(227, 23);
        textBoxNombre.TabIndex = 7;
        // 
        // label8
        // 
        label8.Anchor = AnchorStyles.Right;
        label8.AutoSize = true;
        label8.Location = new Point(188, 27);
        label8.Name = "label8";
        label8.Size = new Size(51, 15);
        label8.TabIndex = 15;
        label8.Text = "Profesor";
        // 
        // comboBox2
        // 
        comboBox2.Anchor = AnchorStyles.Left;
        comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(245, 23);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(227, 23);
        comboBox2.TabIndex = 16;
        comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        // 
        // textBoxApellido
        // 
        textBoxApellido.Anchor = AnchorStyles.Left;
        textBoxApellido.Location = new Point(245, 163);
        textBoxApellido.Name = "textBoxApellido";
        textBoxApellido.Size = new Size(227, 23);
        textBoxApellido.TabIndex = 8;
        // 
        // EditarModal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 561);
        Controls.Add(tableLayoutPanel1);
        MaximumSize = new Size(500, 600);
        MinimumSize = new Size(500, 600);
        Name = "EditarModal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Editar Profesor";
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
    private TextBox textBoxEmail;
    private TextBox textBoxTelefono;
    private TextBox textBoxDireccion;
    private TextBox textBoxApellido;
    private TextBox textBoxNombre;
    private DateTimePicker dateTimePickerNacimiento;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button buttonEnviar;
    private Button buttonCancelar;
    private Label label8;
    private ComboBox comboBox2;
}