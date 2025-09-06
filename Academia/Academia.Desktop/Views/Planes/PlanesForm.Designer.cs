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
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            tableLayoutPanelPlanes = new System.Windows.Forms.TableLayoutPanel();
            dataGridViewPlanes = new System.Windows.Forms.DataGridView();
            buttonActualizar = new System.Windows.Forms.Button();
            buttonVolver = new System.Windows.Forms.Button();
            toolStripPlanes = new System.Windows.Forms.ToolStrip();
            toolStripButtonNuevo = new System.Windows.Forms.ToolStripButton();
            toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
            toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            tableLayoutPanelPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlanes).BeginInit();
            toolStripPlanes.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // 
            // 
            toolStripContainer1.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.BottomToolStripPanel.Name = "";
            toolStripContainer1.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            toolStripContainer1.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // 
            // 
            toolStripContainer1.ContentPanel.Controls.Add(tableLayoutPanelPlanes);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 450);
            toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            toolStripContainer1.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.LeftToolStripPanel.Name = "";
            toolStripContainer1.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            toolStripContainer1.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            // 
            // 
            // 
            toolStripContainer1.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.RightToolStripPanel.Name = "";
            toolStripContainer1.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            toolStripContainer1.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // 
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStripPlanes);
            toolStripContainer1.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            toolStripContainer1.TopToolStripPanel.Name = "";
            toolStripContainer1.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            toolStripContainer1.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            toolStripContainer1.TopToolStripPanel.Size = new System.Drawing.Size(800, 25);
            // 
            // tableLayoutPanelPlanes
            // 
            tableLayoutPanelPlanes.ColumnCount = 2;
            tableLayoutPanelPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelPlanes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanelPlanes.Controls.Add(dataGridViewPlanes, 0, 0);
            tableLayoutPanelPlanes.Controls.Add(buttonActualizar, 0, 1);
            tableLayoutPanelPlanes.Controls.Add(buttonVolver, 1, 1);
            tableLayoutPanelPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelPlanes.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelPlanes.Name = "tableLayoutPanelPlanes";
            tableLayoutPanelPlanes.RowCount = 2;
            tableLayoutPanelPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelPlanes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanelPlanes.Size = new System.Drawing.Size(800, 450);
            tableLayoutPanelPlanes.TabIndex = 0;
            // 
            // dataGridViewPlanes
            // 
            dataGridViewPlanes.AllowUserToAddRows = false;
            dataGridViewPlanes.AllowUserToDeleteRows = false;
            dataGridViewPlanes.AllowUserToResizeColumns = false;
            dataGridViewPlanes.AllowUserToResizeRows = false;
            dataGridViewPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanelPlanes.SetColumnSpan(dataGridViewPlanes, 2);
            dataGridViewPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewPlanes.Location = new System.Drawing.Point(3, 3);
            dataGridViewPlanes.Name = "dataGridViewPlanes";
            dataGridViewPlanes.ReadOnly = true;
            dataGridViewPlanes.Size = new System.Drawing.Size(794, 415);
            dataGridViewPlanes.TabIndex = 0;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            buttonActualizar.Location = new System.Drawing.Point(641, 424);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new System.Drawing.Size(75, 23);
            buttonActualizar.TabIndex = 1;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new System.Drawing.Point(722, 424);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new System.Drawing.Size(75, 23);
            buttonVolver.TabIndex = 2;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // toolStripPlanes
            // 
            toolStripPlanes.Dock = System.Windows.Forms.DockStyle.None;
            toolStripPlanes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStripPlanes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripButtonNuevo, toolStripButtonEditar, toolStripButtonEliminar });
            toolStripPlanes.Location = new System.Drawing.Point(13, 0);
            toolStripPlanes.Name = "toolStripPlanes";
            toolStripPlanes.Size = new System.Drawing.Size(72, 25);
            toolStripPlanes.TabIndex = 0;
            toolStripPlanes.Text = "Crear/Editar/Eliminar";
            // 
            // toolStripButtonNuevo
            // 
            toolStripButtonNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonNuevo.Image = ((System.Drawing.Image)resources.GetObject("toolStripButtonNuevo.Image"));
            toolStripButtonNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonNuevo.Name = "toolStripButtonNuevo";
            toolStripButtonNuevo.Size = new System.Drawing.Size(23, 22);
            toolStripButtonNuevo.Text = "Nuevo";
            toolStripButtonNuevo.Click += toolStripButtonNuevo_Click;
            // 
            // toolStripButtonEditar
            // 
            toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonEditar.Image = ((System.Drawing.Image)resources.GetObject("toolStripButtonEditar.Image"));
            toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonEditar.Name = "toolStripButtonEditar";
            toolStripButtonEditar.Size = new System.Drawing.Size(23, 22);
            toolStripButtonEditar.Text = "Editar";
            toolStripButtonEditar.Click += toolStripButtonEditar_Click;
            // 
            // toolStripButtonEliminar
            // 
            toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripButtonEliminar.Image = ((System.Drawing.Image)resources.GetObject("toolStripButtonEliminar.Image"));
            toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            toolStripButtonEliminar.Size = new System.Drawing.Size(23, 22);
            toolStripButtonEliminar.Text = "Eliminar";
            toolStripButtonEliminar.Click += toolStripButtonEliminar_Click;
            // 
            // PlanesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            ControlBox = false;
            Controls.Add(toolStripContainer1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Text = "Form1";
            Load += PlanesForm_Load;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
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