namespace Academia.Desktop.ModalesPlan
{
    partial class FormDeletePlan
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
            buttonBorrar = new Button();
            SuspendLayout();
            // 
            // comboBoxPlanes
            // 
            comboBoxPlanes.FormattingEnabled = true;
            comboBoxPlanes.Location = new Point(176, 66);
            comboBoxPlanes.Name = "comboBoxPlanes";
            comboBoxPlanes.Size = new Size(121, 23);
            comboBoxPlanes.TabIndex = 0;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(202, 95);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(75, 23);
            buttonBorrar.TabIndex = 1;
            buttonBorrar.Text = "Eliminar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // FormDeletePlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 261);
            Controls.Add(buttonBorrar);
            Controls.Add(comboBoxPlanes);
            MaximumSize = new Size(500, 300);
            MinimumSize = new Size(500, 300);
            Name = "FormDeletePlan";
            Text = "BorrarPlan";
            Load += FormDeletePlan_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxPlanes;
        private Button buttonBorrar;
    }
}