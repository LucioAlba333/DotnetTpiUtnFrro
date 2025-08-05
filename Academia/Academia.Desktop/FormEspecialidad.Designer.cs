namespace Academia.Desktop
{
    partial class FormEspecialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEspecialidad));
            tlEspecialidad = new ToolStripContainer();
            tableLayoutEspecialidad = new TableLayoutPanel();
            dgvEspecialidad = new DataGridView();
            buttonActualizar = new Button();
            buttonVolver = new Button();
            tsEspecialidad = new ToolStrip();
            buttonNew = new ToolStripButton();
            buttonUpdate = new ToolStripButton();
            buttonDelete = new ToolStripButton();
            tlEspecialidad.ContentPanel.SuspendLayout();
            tlEspecialidad.TopToolStripPanel.SuspendLayout();
            tlEspecialidad.SuspendLayout();
            tableLayoutEspecialidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).BeginInit();
            tsEspecialidad.SuspendLayout();
            SuspendLayout();
            // 
            // tlEspecialidad
            // 
            // 
            // tlEspecialidad.ContentPanel
            // 
            tlEspecialidad.ContentPanel.Controls.Add(tableLayoutEspecialidad);
            tlEspecialidad.ContentPanel.Size = new Size(484, 436);
            tlEspecialidad.Dock = DockStyle.Fill;
            tlEspecialidad.Location = new Point(0, 0);
            tlEspecialidad.Name = "tlEspecialidad";
            tlEspecialidad.Size = new Size(484, 461);
            tlEspecialidad.TabIndex = 0;
            tlEspecialidad.Text = "toolStripContainer1";
            // 
            // tlEspecialidad.TopToolStripPanel
            // 
            tlEspecialidad.TopToolStripPanel.Controls.Add(tsEspecialidad);
            tlEspecialidad.TopToolStripPanel.Click += tlEspecialidad_TopToolStripPanel_Click;
            // 
            // tableLayoutEspecialidad
            // 
            tableLayoutEspecialidad.ColumnCount = 2;
            tableLayoutEspecialidad.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutEspecialidad.ColumnStyles.Add(new ColumnStyle());
            tableLayoutEspecialidad.Controls.Add(dgvEspecialidad, 0, 0);
            tableLayoutEspecialidad.Controls.Add(buttonActualizar, 0, 1);
            tableLayoutEspecialidad.Controls.Add(buttonVolver, 1, 1);
            tableLayoutEspecialidad.Dock = DockStyle.Fill;
            tableLayoutEspecialidad.Location = new Point(0, 0);
            tableLayoutEspecialidad.Name = "tableLayoutEspecialidad";
            tableLayoutEspecialidad.RowCount = 2;
            tableLayoutEspecialidad.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutEspecialidad.RowStyles.Add(new RowStyle());
            tableLayoutEspecialidad.Size = new Size(484, 436);
            tableLayoutEspecialidad.TabIndex = 0;
            // 
            // dgvEspecialidad
            // 
            dgvEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutEspecialidad.SetColumnSpan(dgvEspecialidad, 2);
            dgvEspecialidad.Dock = DockStyle.Fill;
            dgvEspecialidad.Location = new Point(3, 3);
            dgvEspecialidad.Name = "dgvEspecialidad";
            dgvEspecialidad.Size = new Size(478, 401);
            dgvEspecialidad.TabIndex = 0;
            dgvEspecialidad.CellContentClick += dgvEspecialidad_CellContentClick;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonActualizar.Location = new Point(325, 410);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(75, 23);
            buttonActualizar.TabIndex = 1;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(406, 410);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(75, 23);
            buttonVolver.TabIndex = 2;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // tsEspecialidad
            // 
            tsEspecialidad.Dock = DockStyle.None;
            tsEspecialidad.Items.AddRange(new ToolStripItem[] { buttonNew, buttonUpdate, buttonDelete });
            tsEspecialidad.Location = new Point(3, 0);
            tsEspecialidad.Name = "tsEspecialidad";
            tsEspecialidad.Size = new Size(112, 25);
            tsEspecialidad.TabIndex = 0;
            // 
            // buttonNew
            // 
            buttonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonNew.Image = (Image)resources.GetObject("buttonNew.Image");
            buttonNew.ImageTransparentColor = Color.Magenta;
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(23, 22);
            buttonNew.Text = "Nuevo";
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonUpdate.Image = (Image)resources.GetObject("buttonUpdate.Image");
            buttonUpdate.ImageTransparentColor = Color.Magenta;
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(23, 22);
            buttonUpdate.Text = "Editar";
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageTransparentColor = Color.Magenta;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(23, 22);
            buttonDelete.Text = "Eliminar";
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormEspecialidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 461);
            Controls.Add(tlEspecialidad);
            Location = new Point(0, 0);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "FormEspecialidad";
            Text = "Academia/Especialidades";
            Load += FormEspecialidad_Load;
            tlEspecialidad.ContentPanel.ResumeLayout(false);
            tlEspecialidad.TopToolStripPanel.ResumeLayout(false);
            tlEspecialidad.TopToolStripPanel.PerformLayout();
            tlEspecialidad.ResumeLayout(false);
            tlEspecialidad.PerformLayout();
            tableLayoutEspecialidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).EndInit();
            tsEspecialidad.ResumeLayout(false);
            tsEspecialidad.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer tlEspecialidad;
        private TableLayoutPanel tableLayoutEspecialidad;
        private ToolStrip tsEspecialidad;
        private DataGridView dgvEspecialidad;
        private Button buttonActualizar;
        private Button buttonVolver;
        private ToolStripButton buttonNew;
        private ToolStripButton buttonUpdate;
        private ToolStripButton buttonDelete;
    }
}