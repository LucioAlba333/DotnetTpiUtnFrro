using System.ComponentModel;

namespace Academia.Desktop.Views.Cursos.Modals;

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
        components = new Container();
        tableLayoutPanel1 = new TableLayoutPanel();
        comboBoxCursos = new ComboBox();
        label5 = new Label();
        flowLayoutPanel1 = new FlowLayoutPanel();
        buttonEnviar = new Button();
        buttonCancelar = new Button();
        label4 = new Label();
        numericUpDownCupo = new NumericUpDown();
        label3 = new Label();
        numericUpDownAnioCalendario = new NumericUpDown();
        label2 = new Label();
        comboBoxComisiones = new ComboBox();
        label1 = new Label();
        comboBoxMaterias = new ComboBox();
        backgroundWorker1 = new BackgroundWorker();
        toolTip1 = new ToolTip(components);
        tableLayoutPanel1.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        ((ISupportInitialize)numericUpDownCupo).BeginInit();
        ((ISupportInitialize)numericUpDownAnioCalendario).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(comboBoxCursos, 1, 0);
        tableLayoutPanel1.Controls.Add(label5, 0, 0);
        tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 5);
        tableLayoutPanel1.Controls.Add(label4, 0, 4);
        tableLayoutPanel1.Controls.Add(numericUpDownCupo, 1, 4);
        tableLayoutPanel1.Controls.Add(label3, 0, 3);
        tableLayoutPanel1.Controls.Add(numericUpDownAnioCalendario, 1, 3);
        tableLayoutPanel1.Controls.Add(label2, 0, 2);
        tableLayoutPanel1.Controls.Add(comboBoxComisiones, 1, 2);
        tableLayoutPanel1.Controls.Add(label1, 0, 1);
        tableLayoutPanel1.Controls.Add(comboBoxMaterias, 1, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 6;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.Size = new Size(484, 561);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // comboBoxCursos
        // 
        comboBoxCursos.Anchor = AnchorStyles.Left;
        comboBoxCursos.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxCursos.FormattingEnabled = true;
        comboBoxCursos.Location = new Point(245, 35);
        comboBoxCursos.Name = "comboBoxCursos";
        comboBoxCursos.Size = new Size(121, 23);
        comboBoxCursos.TabIndex = 10;
        comboBoxCursos.SelectedIndexChanged += comboBoxCursos_SelectedIndexChanged;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.Right;
        label5.AutoSize = true;
        label5.Location = new Point(159, 39);
        label5.Name = "label5";
        label5.Size = new Size(80, 15);
        label5.TabIndex = 9;
        label5.Text = "Curso a Editar";
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.None;
        tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
        flowLayoutPanel1.Controls.Add(buttonEnviar);
        flowLayoutPanel1.Controls.Add(buttonCancelar);
        flowLayoutPanel1.Location = new Point(142, 468);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(200, 90);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // buttonEnviar
        // 
        buttonEnviar.Location = new Point(3, 3);
        buttonEnviar.Name = "buttonEnviar";
        buttonEnviar.Size = new Size(110, 23);
        buttonEnviar.TabIndex = 0;
        buttonEnviar.Text = "Enviar";
        buttonEnviar.UseVisualStyleBackColor = true;
        buttonEnviar.Click += buttonEnviar_Click;
        // 
        // buttonCancelar
        // 
        buttonCancelar.Location = new Point(119, 3);
        buttonCancelar.Name = "buttonCancelar";
        buttonCancelar.Size = new Size(75, 23);
        buttonCancelar.TabIndex = 1;
        buttonCancelar.Text = "Cancelar";
        buttonCancelar.UseVisualStyleBackColor = true;
        buttonCancelar.Click += buttonCancelar_Click;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(203, 411);
        label4.Name = "label4";
        label4.Size = new Size(36, 15);
        label4.TabIndex = 4;
        label4.Text = "Cupo";
        // 
        // numericUpDownCupo
        // 
        numericUpDownCupo.Anchor = AnchorStyles.Left;
        numericUpDownCupo.Location = new Point(245, 407);
        numericUpDownCupo.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        numericUpDownCupo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDownCupo.Name = "numericUpDownCupo";
        numericUpDownCupo.Size = new Size(120, 23);
        numericUpDownCupo.TabIndex = 8;
        numericUpDownCupo.Value = new decimal(new int[] { 40, 0, 0, 0 });
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(150, 318);
        label3.Name = "label3";
        label3.Size = new Size(89, 15);
        label3.TabIndex = 3;
        label3.Text = "Año Calendario";
        // 
        // numericUpDownAnioCalendario
        // 
        numericUpDownAnioCalendario.Anchor = AnchorStyles.Left;
        numericUpDownAnioCalendario.Location = new Point(245, 314);
        numericUpDownAnioCalendario.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
        numericUpDownAnioCalendario.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
        numericUpDownAnioCalendario.Name = "numericUpDownAnioCalendario";
        numericUpDownAnioCalendario.RightToLeft = RightToLeft.No;
        numericUpDownAnioCalendario.Size = new Size(120, 23);
        numericUpDownAnioCalendario.TabIndex = 7;
        numericUpDownAnioCalendario.Value = new decimal(new int[] { 2000, 0, 0, 0 });
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(181, 225);
        label2.Name = "label2";
        label2.Size = new Size(58, 15);
        label2.TabIndex = 2;
        label2.Text = "Comision";
        // 
        // comboBoxComisiones
        // 
        comboBoxComisiones.Anchor = AnchorStyles.Left;
        comboBoxComisiones.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxComisiones.FormattingEnabled = true;
        comboBoxComisiones.Location = new Point(245, 221);
        comboBoxComisiones.Name = "comboBoxComisiones";
        comboBoxComisiones.Size = new Size(121, 23);
        comboBoxComisiones.TabIndex = 6;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(192, 132);
        label1.Name = "label1";
        label1.Size = new Size(47, 15);
        label1.TabIndex = 1;
        label1.Text = "Materia";
        // 
        // comboBoxMaterias
        // 
        comboBoxMaterias.Anchor = AnchorStyles.Left;
        comboBoxMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxMaterias.FormattingEnabled = true;
        comboBoxMaterias.Location = new Point(245, 128);
        comboBoxMaterias.Name = "comboBoxMaterias";
        comboBoxMaterias.Size = new Size(121, 23);
        comboBoxMaterias.TabIndex = 5;
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
        Text = "Editar Curso";
        Load += CrearModal_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        flowLayoutPanel1.ResumeLayout(false);
        ((ISupportInitialize)numericUpDownCupo).EndInit();
        ((ISupportInitialize)numericUpDownAnioCalendario).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button buttonEnviar;
    private System.Windows.Forms.Button buttonCancelar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numericUpDownCupo;
    private System.Windows.Forms.ComboBox comboBoxComisiones;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBoxMaterias;
    private System.Windows.Forms.NumericUpDown numericUpDownAnioCalendario;
    private ComboBox comboBoxCursos;
    private Label label5;
    private BackgroundWorker backgroundWorker1;
    private ToolTip toolTip1;
}