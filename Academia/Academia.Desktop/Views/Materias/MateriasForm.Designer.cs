namespace Academia.Desktop.Views.Materias
{
    partial class MateriasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriasForm));
            toolStripContainerMaterias = new ToolStripContainer();
            tableLayoutPanelMaterias = new TableLayoutPanel();
            dataGridViewMaterias = new DataGridView();
            buttonActualizar = new Button();
            buttonVolver = new Button();
            toolStripMaterias = new ToolStrip();
            toolStripButtonNuevo = new ToolStripButton();
            toolStripButtonEditar = new ToolStripButton();
            toolStripButtonEliminar = new ToolStripButton();
            toolStripContainerMaterias.ContentPanel.SuspendLayout();
            toolStripContainerMaterias.TopToolStripPanel.SuspendLayout();
            toolStripContainerMaterias.SuspendLayout();
            tableLayoutPanelMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).BeginInit();
            toolStripMaterias.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainerMaterias
            // 
            // 
            // toolStripContainerMaterias.ContentPanel
            // 
            toolStripContainerMaterias.ContentPanel.Controls.Add(tableLayoutPanelMaterias);
            toolStripContainerMaterias.ContentPanel.Size = new Size(800, 425);
            toolStripContainerMaterias.Dock = DockStyle.Fill;
            toolStripContainerMaterias.Location = new Point(0, 0);
            toolStripContainerMaterias.Name = "toolStripContainerMaterias";
            toolStripContainerMaterias.Size = new Size(800, 450);
            toolStripContainerMaterias.TabIndex = 0;
            toolStripContainerMaterias.Text = "toolStripContainer1";
            // 
            // toolStripContainerMaterias.TopToolStripPanel
            // 
            toolStripContainerMaterias.TopToolStripPanel.Controls.Add(toolStripMaterias);
            // 
            // tableLayoutPanelMaterias
            // 
            tableLayoutPanelMaterias.ColumnCount = 2;
            tableLayoutPanelMaterias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMaterias.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelMaterias.Controls.Add(dataGridViewMaterias, 0, 0);
            tableLayoutPanelMaterias.Controls.Add(buttonActualizar, 0, 1);
            tableLayoutPanelMaterias.Controls.Add(buttonVolver, 1, 1);
            tableLayoutPanelMaterias.Dock = DockStyle.Fill;
            tableLayoutPanelMaterias.Location = new Point(0, 0);
            tableLayoutPanelMaterias.Name = "tableLayoutPanelMaterias";
            tableLayoutPanelMaterias.RowCount = 2;
            tableLayoutPanelMaterias.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMaterias.RowStyles.Add(new RowStyle());
            tableLayoutPanelMaterias.Size = new Size(800, 425);
            tableLayoutPanelMaterias.TabIndex = 0;
            // 
            // dataGridViewMaterias
            // 
            dataGridViewMaterias.AllowUserToAddRows = false;
            dataGridViewMaterias.AllowUserToDeleteRows = false;
            dataGridViewMaterias.AllowUserToResizeColumns = false;
            dataGridViewMaterias.AllowUserToResizeRows = false;
            dataGridViewMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelMaterias.SetColumnSpan(dataGridViewMaterias, 2);
            dataGridViewMaterias.Dock = DockStyle.Fill;
            dataGridViewMaterias.Location = new Point(3, 3);
            dataGridViewMaterias.Name = "dataGridViewMaterias";
            dataGridViewMaterias.ReadOnly = true;
            dataGridViewMaterias.Size = new Size(794, 390);
            dataGridViewMaterias.TabIndex = 0;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonActualizar.ImageAlign = ContentAlignment.BottomRight;
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
            // toolStripMaterias
            // 
            toolStripMaterias.Dock = DockStyle.None;
            toolStripMaterias.GripStyle = ToolStripGripStyle.Hidden;
            toolStripMaterias.Items.AddRange(new ToolStripItem[] { toolStripButtonNuevo, toolStripButtonEditar, toolStripButtonEliminar });
            toolStripMaterias.Location = new Point(3, 0);
            toolStripMaterias.Name = "toolStripMaterias";
            toolStripMaterias.Size = new Size(103, 25);
            toolStripMaterias.TabIndex = 0;
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
            // MateriasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainerMaterias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MateriasForm";
            Text = "Form1";
            Load += MateriasForm_Load;
            toolStripContainerMaterias.ContentPanel.ResumeLayout(false);
            toolStripContainerMaterias.TopToolStripPanel.ResumeLayout(false);
            toolStripContainerMaterias.TopToolStripPanel.PerformLayout();
            toolStripContainerMaterias.ResumeLayout(false);
            toolStripContainerMaterias.PerformLayout();
            tableLayoutPanelMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterias).EndInit();
            toolStripMaterias.ResumeLayout(false);
            toolStripMaterias.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainerMaterias;
        private ToolStrip toolStripMaterias;
        private ToolStripButton toolStripButtonNuevo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonEliminar;
        private TableLayoutPanel tableLayoutPanelMaterias;
        private DataGridView dataGridViewMaterias;
        private Button buttonActualizar;
        private Button buttonVolver;
    }
}