namespace Academia.Desktop.Views.Especialidades
{
    partial class EspecialidadesForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspecialidadesForm));
            toolStripContainerEspecialidades = new ToolStripContainer();
            tableLayoutPanelEspecialidades = new TableLayoutPanel();
            dataGridViewEspecialidades = new DataGridView();
            buttonActualizar = new Button();
            buttonVolver = new Button();
            toolStripEspecialidades = new ToolStrip();
            toolStripButtonNuevo = new ToolStripButton();
            toolStripButtonEditar = new ToolStripButton();
            toolStripButtonEliminar = new ToolStripButton();
            toolTip1 = new ToolTip(components);
            toolStripContainerEspecialidades.ContentPanel.SuspendLayout();
            toolStripContainerEspecialidades.TopToolStripPanel.SuspendLayout();
            toolStripContainerEspecialidades.SuspendLayout();
            tableLayoutPanelEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEspecialidades).BeginInit();
            toolStripEspecialidades.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainerEspecialidades
            // 
            // 
            // toolStripContainerEspecialidades.ContentPanel
            // 
            toolStripContainerEspecialidades.ContentPanel.Controls.Add(tableLayoutPanelEspecialidades);
            toolStripContainerEspecialidades.ContentPanel.Size = new Size(800, 425);
            toolStripContainerEspecialidades.Dock = DockStyle.Fill;
            toolStripContainerEspecialidades.Location = new Point(0, 0);
            toolStripContainerEspecialidades.Name = "toolStripContainerEspecialidades";
            toolStripContainerEspecialidades.Size = new Size(800, 450);
            toolStripContainerEspecialidades.TabIndex = 0;
            toolStripContainerEspecialidades.Text = "toolStripContainer1";
            // 
            // toolStripContainerEspecialidades.TopToolStripPanel
            // 
            toolStripContainerEspecialidades.TopToolStripPanel.Controls.Add(toolStripEspecialidades);
            // 
            // tableLayoutPanelEspecialidades
            // 
            tableLayoutPanelEspecialidades.ColumnCount = 2;
            tableLayoutPanelEspecialidades.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelEspecialidades.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelEspecialidades.Controls.Add(dataGridViewEspecialidades, 0, 0);
            tableLayoutPanelEspecialidades.Controls.Add(buttonActualizar, 0, 1);
            tableLayoutPanelEspecialidades.Controls.Add(buttonVolver, 1, 1);
            tableLayoutPanelEspecialidades.Dock = DockStyle.Fill;
            tableLayoutPanelEspecialidades.Location = new Point(0, 0);
            tableLayoutPanelEspecialidades.Name = "tableLayoutPanelEspecialidades";
            tableLayoutPanelEspecialidades.RowCount = 2;
            tableLayoutPanelEspecialidades.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelEspecialidades.RowStyles.Add(new RowStyle());
            tableLayoutPanelEspecialidades.Size = new Size(800, 425);
            tableLayoutPanelEspecialidades.TabIndex = 0;
            // 
            // dataGridViewEspecialidades
            // 
            dataGridViewEspecialidades.AllowUserToAddRows = false;
            dataGridViewEspecialidades.AllowUserToDeleteRows = false;
            dataGridViewEspecialidades.AllowUserToResizeColumns = false;
            dataGridViewEspecialidades.AllowUserToResizeRows = false;
            dataGridViewEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelEspecialidades.SetColumnSpan(dataGridViewEspecialidades, 2);
            dataGridViewEspecialidades.Dock = DockStyle.Fill;
            dataGridViewEspecialidades.Location = new Point(3, 3);
            dataGridViewEspecialidades.MultiSelect = false;
            dataGridViewEspecialidades.Name = "dataGridViewEspecialidades";
            dataGridViewEspecialidades.Size = new Size(794, 390);
            dataGridViewEspecialidades.TabIndex = 0;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonActualizar.Location = new Point(641, 399);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(75, 23);
            buttonActualizar.TabIndex = 1;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(722, 399);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(75, 23);
            buttonVolver.TabIndex = 2;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // toolStripEspecialidades
            // 
            toolStripEspecialidades.Dock = DockStyle.None;
            toolStripEspecialidades.GripStyle = ToolStripGripStyle.Hidden;
            toolStripEspecialidades.Items.AddRange(new ToolStripItem[] { toolStripButtonNuevo, toolStripButtonEditar, toolStripButtonEliminar });
            toolStripEspecialidades.Location = new Point(5, 0);
            toolStripEspecialidades.Name = "toolStripEspecialidades";
            toolStripEspecialidades.Size = new Size(103, 25);
            toolStripEspecialidades.TabIndex = 0;
            toolStripEspecialidades.Text = "Nuevo/Editar/Borrar";
            // 
            // toolStripButtonNuevo
            // 
            toolStripButtonNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNuevo.Image = (Image)resources.GetObject("toolStripButtonNuevo.Image");
            toolStripButtonNuevo.ImageTransparentColor = Color.Magenta;
            toolStripButtonNuevo.Name = "toolStripButtonNuevo";
            toolStripButtonNuevo.Size = new Size(23, 22);
            toolStripButtonNuevo.Text = "Nuevo";
            toolStripButtonNuevo.Click += toolStripButtonNuevo_Click;
            // 
            // toolStripButtonEditar
            // 
            toolStripButtonEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditar.Image = (Image)resources.GetObject("toolStripButtonEditar.Image");
            toolStripButtonEditar.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditar.Name = "toolStripButtonEditar";
            toolStripButtonEditar.Size = new Size(23, 22);
            toolStripButtonEditar.Text = "Editar";
            toolStripButtonEditar.Click += toolStripButtonEditar_Click;
            // 
            // toolStripButtonEliminar
            // 
            toolStripButtonEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEliminar.Image = (Image)resources.GetObject("toolStripButtonEliminar.Image");
            toolStripButtonEliminar.ImageTransparentColor = Color.Magenta;
            toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            toolStripButtonEliminar.Size = new Size(23, 22);
            toolStripButtonEliminar.Text = "Eliminar";
            toolStripButtonEliminar.Click += toolStripButtonEliminar_Click;
            // 
            // EspecialidadesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(toolStripContainerEspecialidades);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EspecialidadesForm";
            Text = "Academia/Especialidades";
            Load += EspecialidadesForm_Load;
            toolStripContainerEspecialidades.ContentPanel.ResumeLayout(false);
            toolStripContainerEspecialidades.TopToolStripPanel.ResumeLayout(false);
            toolStripContainerEspecialidades.TopToolStripPanel.PerformLayout();
            toolStripContainerEspecialidades.ResumeLayout(false);
            toolStripContainerEspecialidades.PerformLayout();
            tableLayoutPanelEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEspecialidades).EndInit();
            toolStripEspecialidades.ResumeLayout(false);
            toolStripEspecialidades.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainerEspecialidades;
        private ToolStrip toolStripEspecialidades;
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanelEspecialidades;
        private DataGridView dataGridViewEspecialidades;
        private Button buttonActualizar;
        private Button buttonVolver;
        private ToolStripButton toolStripButtonNuevo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonEliminar;
    }
}