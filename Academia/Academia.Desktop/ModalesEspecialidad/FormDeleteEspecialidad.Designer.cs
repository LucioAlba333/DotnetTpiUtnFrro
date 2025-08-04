namespace Academia.Desktop.ModalesEspecialidad
{
    partial class FormDeleteEspecialidad
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
            buttonEnviar = new Button();
            comboBoxEspecialidades = new ComboBox();
            SuspendLayout();
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(197, 118);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(75, 23);
            buttonEnviar.TabIndex = 1;
            buttonEnviar.Text = "Eliminar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // comboBoxEspecialidades
            // 
            comboBoxEspecialidades.FormattingEnabled = true;
            comboBoxEspecialidades.Location = new Point(173, 89);
            comboBoxEspecialidades.Name = "comboBoxEspecialidades";
            comboBoxEspecialidades.Size = new Size(121, 23);
            comboBoxEspecialidades.TabIndex = 2;
            // 
            // FormDeleteEspecialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 261);
            Controls.Add(comboBoxEspecialidades);
            Controls.Add(buttonEnviar);
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "FormDeleteEspecialidad";
            Text = "BorrarEspecialidad";
            Load += FormDeleteEspecialidad_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button buttonEnviar;
        private ComboBox comboBoxEspecialidades;
    }
}