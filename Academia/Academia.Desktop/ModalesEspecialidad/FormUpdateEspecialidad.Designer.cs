namespace Academia.Desktop.ModalesEspecialidad
{
    partial class FormUpdateEspecialidad
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
            textBox1 = new TextBox();
            buttonEnviar = new Button();
            comboxEspecialidades = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 0;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(270, 100);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 23);
            buttonEnviar.TabIndex = 1;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // comboxEspecialidades
            // 
            comboxEspecialidades.FormattingEnabled = true;
            comboxEspecialidades.Location = new Point(36, 71);
            comboxEspecialidades.Name = "comboxEspecialidades";
            comboxEspecialidades.Size = new Size(121, 23);
            comboxEspecialidades.TabIndex = 2;
            comboxEspecialidades.SelectedIndexChanged += comboxEspecialidades_SelectedIndexChanged;
            // 
            // FormUpdateEspecialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(484, 261);
            Controls.Add(comboxEspecialidades);
            Controls.Add(buttonEnviar);
            Controls.Add(textBox1);
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "FormUpdateEspecialidad";
            Text = "Editar Especialidad";
            Load += FormUpdateEspecialidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonEnviar;
        private ComboBox comboxEspecialidades;
    }
}