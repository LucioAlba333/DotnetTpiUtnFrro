using System.ComponentModel;

namespace Academia.Desktop.Views.Cursos.Modals;

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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        numericUpDownCupo = new System.Windows.Forms.NumericUpDown();
        comboBoxComisiones = new System.Windows.Forms.ComboBox();
        flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        buttonEnviar = new System.Windows.Forms.Button();
        buttonCancelar = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        comboBoxMaterias = new System.Windows.Forms.ComboBox();
        numericUpDownAnioCalendario = new System.Windows.Forms.NumericUpDown();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownCupo).BeginInit();
        flowLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownAnioCalendario).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(numericUpDownCupo, 1, 3);
        tableLayoutPanel1.Controls.Add(comboBoxComisiones, 1, 1);
        tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 4);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(label2, 0, 1);
        tableLayoutPanel1.Controls.Add(label3, 0, 2);
        tableLayoutPanel1.Controls.Add(label4, 0, 3);
        tableLayoutPanel1.Controls.Add(comboBoxMaterias, 1, 0);
        tableLayoutPanel1.Controls.Add(numericUpDownAnioCalendario, 1, 2);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new System.Drawing.Size(484, 561);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // numericUpDownCupo
        // 
        numericUpDownCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
        numericUpDownCupo.Location = new System.Drawing.Point(245, 380);
        numericUpDownCupo.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        numericUpDownCupo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDownCupo.Name = "numericUpDownCupo";
        numericUpDownCupo.Size = new System.Drawing.Size(120, 23);
        numericUpDownCupo.TabIndex = 8;
        numericUpDownCupo.Value = new decimal(new int[] { 40, 0, 0, 0 });
        // 
        // comboBoxComisiones
        // 
        comboBoxComisiones.Anchor = System.Windows.Forms.AnchorStyles.Left;
        comboBoxComisiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboBoxComisiones.FormattingEnabled = true;
        comboBoxComisiones.Location = new System.Drawing.Point(245, 156);
        comboBoxComisiones.Name = "comboBoxComisiones";
        comboBoxComisiones.Size = new System.Drawing.Size(121, 23);
        comboBoxComisiones.TabIndex = 6;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
        tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
        flowLayoutPanel1.Controls.Add(buttonEnviar);
        flowLayoutPanel1.Controls.Add(buttonCancelar);
        flowLayoutPanel1.Location = new System.Drawing.Point(142, 454);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // buttonEnviar
        // 
        buttonEnviar.Location = new System.Drawing.Point(3, 3);
        buttonEnviar.Name = "buttonEnviar";
        buttonEnviar.Size = new System.Drawing.Size(110, 23);
        buttonEnviar.TabIndex = 0;
        buttonEnviar.Text = "Enviar";
        buttonEnviar.UseVisualStyleBackColor = true;
        buttonEnviar.Click += buttonEnviar_Click;
        // 
        // buttonCancelar
        // 
        buttonCancelar.Location = new System.Drawing.Point(119, 3);
        buttonCancelar.Name = "buttonCancelar";
        buttonCancelar.Size = new System.Drawing.Size(75, 23);
        buttonCancelar.TabIndex = 1;
        buttonCancelar.Text = "Cancelar";
        buttonCancelar.UseVisualStyleBackColor = true;
        buttonCancelar.Click += buttonCancelar_Click;
        // 
        // label1
        // 
        label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(192, 48);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(47, 15);
        label1.TabIndex = 1;
        label1.Text = "Materia";
        // 
        // label2
        // 
        label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(181, 160);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(58, 15);
        label2.TabIndex = 2;
        label2.Text = "Comision";
        // 
        // label3
        // 
        label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(150, 272);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(89, 15);
        label3.TabIndex = 3;
        label3.Text = "Año Calendario";
        // 
        // label4
        // 
        label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(203, 384);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(36, 15);
        label4.TabIndex = 4;
        label4.Text = "Cupo";
        // 
        // comboBoxMaterias
        // 
        comboBoxMaterias.Anchor = System.Windows.Forms.AnchorStyles.Left;
        comboBoxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboBoxMaterias.FormattingEnabled = true;
        comboBoxMaterias.Location = new System.Drawing.Point(245, 44);
        comboBoxMaterias.Name = "comboBoxMaterias";
        comboBoxMaterias.Size = new System.Drawing.Size(121, 23);
        comboBoxMaterias.TabIndex = 5;
        // 
        // numericUpDownAnioCalendario
        // 
        numericUpDownAnioCalendario.Anchor = System.Windows.Forms.AnchorStyles.Left;
        numericUpDownAnioCalendario.Location = new System.Drawing.Point(245, 268);
        numericUpDownAnioCalendario.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
        numericUpDownAnioCalendario.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
        numericUpDownAnioCalendario.Name = "numericUpDownAnioCalendario";
        numericUpDownAnioCalendario.RightToLeft = System.Windows.Forms.RightToLeft.No;
        numericUpDownAnioCalendario.Size = new System.Drawing.Size(120, 23);
        numericUpDownAnioCalendario.TabIndex = 7;
        numericUpDownAnioCalendario.Value = new decimal(new int[] { 2000, 0, 0, 0 });
        // 
        // CrearModal
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(484, 561);
        Controls.Add(tableLayoutPanel1);
        MaximumSize = new System.Drawing.Size(500, 600);
        MinimumSize = new System.Drawing.Size(500, 600);
        Text = "Crear Curso";
        Load += CrearModal_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownCupo).EndInit();
        flowLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDownAnioCalendario).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Button buttonEnviar;
    private System.Windows.Forms.Button buttonCancelar;
    private Label label1;
    private NumericUpDown numericUpDownCupo;
    private ComboBox comboBoxComisiones;
    private Label label2;
    private Label label3;
    private Label label4;
    private ComboBox comboBoxMaterias;
    private NumericUpDown numericUpDownAnioCalendario;
}