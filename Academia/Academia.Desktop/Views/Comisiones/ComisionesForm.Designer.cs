namespace Academia.Desktop.Views.Comisiones
{
    partial class ComisionesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComisionesForm));
            toolStripContainer1 = new ToolStripContainer();
            tableLayoutPanelComisiones = new TableLayoutPanel();
            dataGridViewComisiones = new DataGridView();
            buttonActualizar = new Button();
            buttonVolver = new Button();
            toolStripComisiones = new ToolStrip();
            toolStripButtonNuevo = new ToolStripButton();
            toolStripButtonEditar = new ToolStripButton();
            toolStripButtonEliminar = new ToolStripButton();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            tableLayoutPanelComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComisiones).BeginInit();
            toolStripComisiones.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanelComisiones);
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
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStripComisiones);
            // 
            // tableLayoutPanelComisiones
            // 
            tableLayoutPanelComisiones.ColumnCount = 2;
            tableLayoutPanelComisiones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelComisiones.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelComisiones.Controls.Add(dataGridViewComisiones, 0, 0);
            tableLayoutPanelComisiones.Controls.Add(buttonActualizar, 0, 1);
            tableLayoutPanelComisiones.Controls.Add(buttonVolver, 1, 1);
            tableLayoutPanelComisiones.Dock = DockStyle.Fill;
            tableLayoutPanelComisiones.Location = new Point(0, 0);
            tableLayoutPanelComisiones.Name = "tableLayoutPanelComisiones";
            tableLayoutPanelComisiones.RowCount = 2;
            tableLayoutPanelComisiones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelComisiones.RowStyles.Add(new RowStyle());
            tableLayoutPanelComisiones.Size = new Size(800, 425);
            tableLayoutPanelComisiones.TabIndex = 0;
            // 
            // dataGridViewComisiones
            // 
            dataGridViewComisiones.AllowUserToAddRows = false;
            dataGridViewComisiones.AllowUserToDeleteRows = false;
            dataGridViewComisiones.AllowUserToResizeColumns = false;
            dataGridViewComisiones.AllowUserToResizeRows = false;
            dataGridViewComisiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComisiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelComisiones.SetColumnSpan(dataGridViewComisiones, 2);
            dataGridViewComisiones.Dock = DockStyle.Fill;
            dataGridViewComisiones.Location = new Point(3, 3);
            dataGridViewComisiones.Name = "dataGridViewComisiones";
            dataGridViewComisiones.ReadOnly = true;
            dataGridViewComisiones.Size = new Size(794, 390);
            dataGridViewComisiones.TabIndex = 0;
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
            // toolStripComisiones
            // 
            toolStripComisiones.Dock = DockStyle.None;
            toolStripComisiones.GripStyle = ToolStripGripStyle.Hidden;
            toolStripComisiones.Items.AddRange(new ToolStripItem[] { toolStripButtonNuevo, toolStripButtonEditar, toolStripButtonEliminar });
            toolStripComisiones.Location = new Point(3, 0);
            toolStripComisiones.Name = "toolStripComisiones";
            toolStripComisiones.Size = new Size(72, 25);
            toolStripComisiones.TabIndex = 0;
            toolStripComisiones.Text = "Crear/Editar/Eliminar";
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
            // ComisionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(toolStripContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ComisionesForm";
            Text = "Form1";
            Load += ComisionesForm_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            tableLayoutPanelComisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewComisiones).EndInit();
            toolStripComisiones.ResumeLayout(false);
            toolStripComisiones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private TableLayoutPanel tableLayoutPanelComisiones;
        private System.Windows.Forms.DataGridView dataGridViewComisiones;
        private Button buttonActualizar;
        private Button buttonVolver;
        private ToolStrip toolStripComisiones;
        private ToolStripButton toolStripButtonNuevo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonEliminar;
    }
}