namespace Academia.Desktop.Views.Planes
{
    partial class PlanesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanesForm));
            toolStripContainer1 = new ToolStripContainer();
            tableLayoutPanelPlanes = new TableLayoutPanel();
            dataGridViewPlanes = new DataGridView();
            buttonActualizar = new Button();
            buttonVolver = new Button();
            toolStripPlanes = new ToolStrip();
            toolStripButtonNuevo = new ToolStripButton();
            toolStripButtonEditar = new ToolStripButton();
            toolStripButtonEliminar = new ToolStripButton();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tableLayoutPanelPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlanes).BeginInit();
            toolStripPlanes.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanelPlanes);
            toolStripContainer1.ContentPanel.Size = new Size(800, 425);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStripPlanes);
            // 
            // tableLayoutPanelPlanes
            // 
            tableLayoutPanelPlanes.ColumnCount = 2;
            tableLayoutPanelPlanes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelPlanes.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelPlanes.Controls.Add(dataGridViewPlanes, 0, 0);
            tableLayoutPanelPlanes.Controls.Add(buttonActualizar, 0, 1);
            tableLayoutPanelPlanes.Controls.Add(buttonVolver, 1, 1);
            tableLayoutPanelPlanes.Dock = DockStyle.Fill;
            tableLayoutPanelPlanes.Location = new Point(0, 0);
            tableLayoutPanelPlanes.Name = "tableLayoutPanelPlanes";
            tableLayoutPanelPlanes.RowCount = 2;
            tableLayoutPanelPlanes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPlanes.RowStyles.Add(new RowStyle());
            tableLayoutPanelPlanes.Size = new Size(800, 425);
            tableLayoutPanelPlanes.TabIndex = 0;
            // 
            // dataGridViewPlanes
            // 
            dataGridViewPlanes.AllowUserToAddRows = false;
            dataGridViewPlanes.AllowUserToDeleteRows = false;
            dataGridViewPlanes.AllowUserToResizeColumns = false;
            dataGridViewPlanes.AllowUserToResizeRows = false;
            dataGridViewPlanes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelPlanes.SetColumnSpan(dataGridViewPlanes, 2);
            dataGridViewPlanes.Dock = DockStyle.Fill;
            dataGridViewPlanes.Location = new Point(3, 3);
            dataGridViewPlanes.Name = "dataGridViewPlanes";
            dataGridViewPlanes.ReadOnly = true;
            dataGridViewPlanes.Size = new Size(794, 390);
            dataGridViewPlanes.TabIndex = 0;
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
            // toolStripPlanes
            // 
            toolStripPlanes.Dock = DockStyle.None;
            toolStripPlanes.GripStyle = ToolStripGripStyle.Hidden;
            toolStripPlanes.Items.AddRange(new ToolStripItem[] { toolStripButtonNuevo, toolStripButtonEditar, toolStripButtonEliminar });
            toolStripPlanes.Location = new Point(3, 0);
            toolStripPlanes.Name = "toolStripPlanes";
            toolStripPlanes.Size = new Size(72, 25);
            toolStripPlanes.TabIndex = 0;
            toolStripPlanes.Text = "Crear/Editar/Eliminar";
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
            // PlanesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(toolStripContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlanesForm";
            Text = "Form1";
            Load += PlanesForm_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tableLayoutPanelPlanes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlanes).EndInit();
            toolStripPlanes.ResumeLayout(false);
            toolStripPlanes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private TableLayoutPanel tableLayoutPanelPlanes;
        private System.Windows.Forms.DataGridView dataGridViewPlanes;
        private Button buttonActualizar;
        private Button buttonVolver;
        private ToolStrip toolStripPlanes;
        private ToolStripButton toolStripButtonNuevo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonEliminar;
    }
}