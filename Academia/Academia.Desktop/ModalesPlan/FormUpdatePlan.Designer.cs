namespace Academia.Desktop.ModalesPlan
{
    partial class FormUpdatePlan
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
            comboBoxPlanes = new ComboBox();
            comboBoxEspecialidades = new ComboBox();
            textBox1 = new TextBox();
            buttonEnviar = new Button();
            SuspendLayout();
            // 
            // comboBoxPlanes
            // 
            comboBoxPlanes.FormattingEnabled = true;
            comboBoxPlanes.Location = new Point(32, 77);
            comboBoxPlanes.Name = "comboBoxPlanes";
            comboBoxPlanes.Size = new Size(121, 23);
            comboBoxPlanes.TabIndex = 0;
            comboBoxPlanes.SelectedIndexChanged += comboBoxPlanes_SelectedIndexChanged;
            // 
            // comboBoxEspecialidades
            // 
            comboBoxEspecialidades.FormattingEnabled = true;
            comboBoxEspecialidades.Location = new Point(313, 77);
            comboBoxEspecialidades.Name = "comboBoxEspecialidades";
            comboBoxEspecialidades.Size = new Size(121, 23);
            comboBoxEspecialidades.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(178, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 2;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(359, 134);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 23);
            buttonEnviar.TabIndex = 3;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // FormUpdatePlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 261);
            Controls.Add(buttonEnviar);
            Controls.Add(textBox1);
            Controls.Add(comboBoxEspecialidades);
            Controls.Add(comboBoxPlanes);
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "FormUpdatePlan";
            Text = "Editar Plan";
            Load += FormUpdatePlan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPlanes;
        private ComboBox comboBoxEspecialidades;
        private TextBox textBox1;
        private Button buttonEnviar;
    }
}