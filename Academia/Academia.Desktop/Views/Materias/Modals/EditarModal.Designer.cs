namespace Academia.Desktop.Views.Materias.Modals
{
    partial class EditarModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            comboBox2 = new ComboBox();
            label5 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonEnviar = new Button();
            buttoncancelar = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            flowLayoutPanel2 = new FlowLayoutPanel();
            radioButtonAnual = new RadioButton();
            radioButtonCuatri = new RadioButton();
            label1 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(comboBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 6);
            tableLayoutPanel1.Controls.Add(label4, 0, 5);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5833321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5833349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5833349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5833349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5833349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5833349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tableLayoutPanel1.Size = new Size(484, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(245, 29);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(192, 33);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 10;
            label5.Text = "Materia";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel1, 2);
            flowLayoutPanel1.Controls.Add(buttonEnviar);
            flowLayoutPanel1.Controls.Add(buttoncancelar);
            flowLayoutPanel1.Location = new Point(142, 496);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 55);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(3, 3);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(105, 23);
            buttonEnviar.TabIndex = 0;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // buttoncancelar
            // 
            buttoncancelar.Location = new Point(114, 3);
            buttoncancelar.Name = "buttoncancelar";
            buttoncancelar.Size = new Size(75, 23);
            buttoncancelar.TabIndex = 1;
            buttoncancelar.Text = "Cancelar";
            buttoncancelar.UseVisualStyleBackColor = true;
            buttoncancelar.Click += buttoncancelar_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(209, 438);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "Plan";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(245, 434);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(163, 357);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 7;
            label3.Text = "Horas totales";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Left;
            numericUpDown2.Enabled = false;
            numericUpDown2.Location = new Point(245, 353);
            numericUpDown2.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.ReadOnly = true;
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(143, 276);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 6;
            label2.Text = "Horas semanales";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left;
            numericUpDown1.Location = new Point(245, 272);
            numericUpDown1.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.None;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel2, 2);
            flowLayoutPanel2.Controls.Add(radioButtonAnual);
            flowLayoutPanel2.Controls.Add(radioButtonCuatri);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(191, 177);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.RightToLeft = RightToLeft.No;
            flowLayoutPanel2.Size = new Size(102, 50);
            flowLayoutPanel2.TabIndex = 9;
            // 
            // radioButtonAnual
            // 
            radioButtonAnual.AutoSize = true;
            radioButtonAnual.Location = new Point(3, 3);
            radioButtonAnual.Name = "radioButtonAnual";
            radioButtonAnual.Size = new Size(56, 19);
            radioButtonAnual.TabIndex = 0;
            radioButtonAnual.Text = "Anual";
            radioButtonAnual.UseVisualStyleBackColor = true;
            radioButtonAnual.CheckedChanged += radioButtonAnual_CheckedChanged;
            // 
            // radioButtonCuatri
            // 
            radioButtonCuatri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonCuatri.AutoSize = true;
            radioButtonCuatri.Location = new Point(3, 28);
            radioButtonCuatri.Name = "radioButtonCuatri";
            radioButtonCuatri.Size = new Size(96, 19);
            radioButtonCuatri.TabIndex = 1;
            radioButtonCuatri.Text = "Cuatrimestral";
            radioButtonCuatri.UseVisualStyleBackColor = true;
            radioButtonCuatri.CheckedChanged += radioButtonCuatri_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(170, 114);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Descripcion";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(245, 110);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
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
            Text = "Editar Materia";
            Load += CrearModal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton radioButtonAnual;
        private RadioButton radioButtonCuatri;
        private Button buttonEnviar;
        private Button buttoncancelar;
        private ComboBox comboBox2;
        private Label label5;
    }
}