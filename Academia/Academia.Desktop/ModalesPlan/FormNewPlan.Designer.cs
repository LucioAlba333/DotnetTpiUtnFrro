namespace Academia.Desktop.ModalesPlan
{
    partial class FormNewPlan
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
            comboBoxEspecialidades = new ComboBox();
            buttonEnviar = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // comboBoxEspecialidades
            // 
            comboBoxEspecialidades.FormattingEnabled = true;
            comboBoxEspecialidades.Location = new Point(89, 89);
            comboBoxEspecialidades.Name = "comboBoxEspecialidades";
            comboBoxEspecialidades.Size = new Size(121, 23);
            comboBoxEspecialidades.TabIndex = 0;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(283, 149);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 23);
            buttonEnviar.TabIndex = 1;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 2;
            // 
            // FormNewPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 261);
            Controls.Add(textBox1);
            Controls.Add(buttonEnviar);
            Controls.Add(comboBoxEspecialidades);
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "FormNewPlan";
            Text = "NuevoPlan";
            Load += FormNewPlan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxEspecialidades;
        private Button buttonEnviar;
        private TextBox textBox1;
    }
}