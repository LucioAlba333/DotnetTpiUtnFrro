namespace Academia.Desktop
{
	partial class FormMenu
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEspecialidad = new Button();
            buttonPlan = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEspecialidad
            // 
            buttonEspecialidad.Location = new Point(3, 3);
            buttonEspecialidad.Name = "buttonEspecialidad";
            buttonEspecialidad.Size = new Size(182, 42);
            buttonEspecialidad.TabIndex = 0;
            buttonEspecialidad.Text = "Especialidades";
            buttonEspecialidad.UseVisualStyleBackColor = true;
            buttonEspecialidad.Click += buttonEspecialidad_Click;
            // 
            // buttonPlan
            // 
            buttonPlan.Location = new Point(3, 56);
            buttonPlan.Name = "buttonPlan";
            buttonPlan.Size = new Size(182, 44);
            buttonPlan.TabIndex = 1;
            buttonPlan.Text = "Planes";
            buttonPlan.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonEspecialidad, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonPlan, 0, 1);
            tableLayoutPanel1.Location = new Point(144, 137);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            tableLayoutPanel1.Size = new Size(188, 103);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 461);
            Controls.Add(tableLayoutPanel1);
            Location = new Point(0, 0);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "FormMenu";
            Text = "Academia";
            Load += FormMenu_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEspecialidad;
		private Button buttonPlan;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
