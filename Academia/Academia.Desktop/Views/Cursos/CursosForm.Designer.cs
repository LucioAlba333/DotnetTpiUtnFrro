using System.ComponentModel;

namespace Academia.Desktop.Views.Cursos;

partial class CursosForm
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(CursosForm));
        toolStripContainerCursos = new ToolStripContainer();
        tableLayoutPanelCursos = new TableLayoutPanel();
        dataGridViewCursos = new DataGridView();
        buttonActualizar = new Button();
        buttonVolver = new Button();
        toolStripCursos = new ToolStrip();
        toolStripButtonNuevo = new ToolStripButton();
        toolStripButtonEditar = new ToolStripButton();
        toolStripButtonEliminar = new ToolStripButton();
        toolStripContainerCursos.ContentPanel.SuspendLayout();
        toolStripContainerCursos.TopToolStripPanel.SuspendLayout();
        toolStripContainerCursos.SuspendLayout();
        tableLayoutPanelCursos.SuspendLayout();
        ((ISupportInitialize)dataGridViewCursos).BeginInit();
        toolStripCursos.SuspendLayout();
        SuspendLayout();
        // 
        // toolStripContainerCursos
        // 
        // 
        // toolStripContainerCursos.ContentPanel
        // 
        toolStripContainerCursos.ContentPanel.Controls.Add(tableLayoutPanelCursos);
        toolStripContainerCursos.ContentPanel.Size = new Size(800, 425);
        toolStripContainerCursos.Dock = DockStyle.Fill;
        toolStripContainerCursos.Location = new Point(0, 0);
        toolStripContainerCursos.Name = "toolStripContainerCursos";
        toolStripContainerCursos.Size = new Size(800, 450);
        toolStripContainerCursos.TabIndex = 0;
        toolStripContainerCursos.Text = "toolStripContainer1";
        // 
        // toolStripContainerCursos.TopToolStripPanel
        // 
        toolStripContainerCursos.TopToolStripPanel.Controls.Add(toolStripCursos);
        // 
        // tableLayoutPanelCursos
        // 
        tableLayoutPanelCursos.ColumnCount = 2;
        tableLayoutPanelCursos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanelCursos.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanelCursos.Controls.Add(dataGridViewCursos, 0, 0);
        tableLayoutPanelCursos.Controls.Add(buttonActualizar, 0, 1);
        tableLayoutPanelCursos.Controls.Add(buttonVolver, 1, 1);
        tableLayoutPanelCursos.Dock = DockStyle.Fill;
        tableLayoutPanelCursos.Location = new Point(0, 0);
        tableLayoutPanelCursos.Name = "tableLayoutPanelCursos";
        tableLayoutPanelCursos.RowCount = 2;
        tableLayoutPanelCursos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanelCursos.RowStyles.Add(new RowStyle());
        tableLayoutPanelCursos.Size = new Size(800, 425);
        tableLayoutPanelCursos.TabIndex = 0;
        // 
        // dataGridViewCursos
        // 
        dataGridViewCursos.AllowUserToAddRows = false;
        dataGridViewCursos.AllowUserToDeleteRows = false;
        dataGridViewCursos.AllowUserToResizeColumns = false;
        dataGridViewCursos.AllowUserToResizeRows = false;
        dataGridViewCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableLayoutPanelCursos.SetColumnSpan(dataGridViewCursos, 2);
        dataGridViewCursos.Dock = DockStyle.Fill;
        dataGridViewCursos.Location = new Point(3, 3);
        dataGridViewCursos.Name = "dataGridViewCursos";
        dataGridViewCursos.ReadOnly = true;
        dataGridViewCursos.Size = new Size(794, 390);
        dataGridViewCursos.TabIndex = 0;
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
        // toolStripCursos
        // 
        toolStripCursos.Dock = DockStyle.None;
        toolStripCursos.GripStyle = ToolStripGripStyle.Hidden;
        toolStripCursos.Items.AddRange(new ToolStripItem[] { toolStripButtonNuevo, toolStripButtonEditar, toolStripButtonEliminar });
        toolStripCursos.Location = new Point(3, 0);
        toolStripCursos.Name = "toolStripCursos";
        toolStripCursos.Size = new Size(103, 25);
        toolStripCursos.TabIndex = 0;
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
        // CursosForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(toolStripContainerCursos);
        FormBorderStyle = FormBorderStyle.None;
        Name = "CursosForm";
        Text = "Form1";
        Load += CursosForm_Load;
        toolStripContainerCursos.ContentPanel.ResumeLayout(false);
        toolStripContainerCursos.TopToolStripPanel.ResumeLayout(false);
        toolStripContainerCursos.TopToolStripPanel.PerformLayout();
        toolStripContainerCursos.ResumeLayout(false);
        toolStripContainerCursos.PerformLayout();
        tableLayoutPanelCursos.ResumeLayout(false);
        ((ISupportInitialize)dataGridViewCursos).EndInit();
        toolStripCursos.ResumeLayout(false);
        toolStripCursos.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private ToolStripContainer toolStripContainerCursos;
        private ToolStrip toolStripCursos;
        private ToolStripButton toolStripButtonNuevo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonEliminar;
        private TableLayoutPanel tableLayoutPanelCursos;
        private DataGridView dataGridViewCursos;
        private Button buttonActualizar;
        private Button buttonVolver;
}