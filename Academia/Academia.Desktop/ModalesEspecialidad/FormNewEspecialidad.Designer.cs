namespace Academia.Desktop.ModalesEspecialidad
{
    partial class FormNewEspecialidad
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label = new Label();
            buttonEnviar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(33, 57);
            label.Name = "label";
            label.Size = new Size(137, 15);
            label.TabIndex = 3;
            label.Text = "Descripcion Especialidad";
            label.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(268, 115);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(83, 27);
            buttonEnviar.TabIndex = 4;
            buttonEnviar.Text = "Enviar";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // FormNewEspecialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 261);
            Controls.Add(buttonEnviar);
            Controls.Add(label);
            Controls.Add(textBox1);
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "FormNewEspecialidad";
            Text = "NuevaEspecialidad";
            Load += FormNewEspecialidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label;
        private Button buttonEnviar;
    }
}