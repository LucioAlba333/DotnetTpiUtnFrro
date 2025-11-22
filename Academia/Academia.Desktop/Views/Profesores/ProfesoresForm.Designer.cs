using System.ComponentModel;

namespace Academia.Desktop.Views.Profesores;

partial class ProfesoresForm
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(ProfesoresForm));
        toolStripContainerProfesores = new ToolStripContainer();
        tableLayoutPanelProfesores = new TableLayoutPanel();
        dataGridViewProfesores = new DataGridView();
        buttonActualizar = new Button();
        buttonVolver = new Button();
        toolStripMaterias = new ToolStrip();
        toolStripButtonNuevo = new ToolStripButton();
        toolStripButtonEditar = new ToolStripButton();
        toolStripButtonEliminar = new ToolStripButton();
        toolStripButtonGenerarUsuario = new ToolStripButton();
        toolStripContainerProfesores.ContentPanel.SuspendLayout();
        toolStripContainerProfesores.TopToolStripPanel.SuspendLayout();
        toolStripContainerProfesores.SuspendLayout();
        tableLayoutPanelProfesores.SuspendLayout();
        ((ISupportInitialize)dataGridViewProfesores).BeginInit();
        toolStripMaterias.SuspendLayout();
        SuspendLayout();
        // 
        // toolStripContainerProfesores
        // 
        // 
        // toolStripContainerProfesores.ContentPanel
        // 
        toolStripContainerProfesores.ContentPanel.Controls.Add(tableLayoutPanelProfesores);
        toolStripContainerProfesores.ContentPanel.Size = new Size(800, 425);
        toolStripContainerProfesores.Dock = DockStyle.Fill;
        toolStripContainerProfesores.Location = new Point(0, 0);
        toolStripContainerProfesores.Name = "toolStripContainerProfesores";
        toolStripContainerProfesores.Size = new Size(800, 450);
        toolStripContainerProfesores.TabIndex = 0;
        toolStripContainerProfesores.Text = "toolStripContainer1";
        // 
        // toolStripContainerProfesores.TopToolStripPanel
        // 
        toolStripContainerProfesores.TopToolStripPanel.Controls.Add(toolStripMaterias);
        // 
        // tableLayoutPanelProfesores
        // 
        tableLayoutPanelProfesores.ColumnCount = 2;
        tableLayoutPanelProfesores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanelProfesores.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanelProfesores.Controls.Add(dataGridViewProfesores, 0, 0);
        tableLayoutPanelProfesores.Controls.Add(buttonActualizar, 0, 1);
        tableLayoutPanelProfesores.Controls.Add(buttonVolver, 1, 1);
        tableLayoutPanelProfesores.Dock = DockStyle.Fill;
        tableLayoutPanelProfesores.Location = new Point(0, 0);
        tableLayoutPanelProfesores.Name = "tableLayoutPanelProfesores";
        tableLayoutPanelProfesores.RowCount = 2;
        tableLayoutPanelProfesores.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanelProfesores.RowStyles.Add(new RowStyle());
        tableLayoutPanelProfesores.Size = new Size(800, 425);
        tableLayoutPanelProfesores.TabIndex = 0;
        // 
        // dataGridViewProfesores
        // 
        dataGridViewProfesores.AllowUserToAddRows = false;
        dataGridViewProfesores.AllowUserToDeleteRows = false;
        dataGridViewProfesores.AllowUserToResizeColumns = false;
        dataGridViewProfesores.AllowUserToResizeRows = false;
        dataGridViewProfesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableLayoutPanelProfesores.SetColumnSpan(dataGridViewProfesores, 2);
        dataGridViewProfesores.Dock = DockStyle.Fill;
        dataGridViewProfesores.Location = new Point(3, 3);
        dataGridViewProfesores.Name = "dataGridViewProfesores";
        dataGridViewProfesores.ReadOnly = true;
        dataGridViewProfesores.Size = new Size(794, 390);
        dataGridViewProfesores.TabIndex = 0;
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
        toolStripMaterias.Items.AddRange(new ToolStripItem[] { toolStripButtonNuevo, toolStripButtonEditar, toolStripButtonEliminar, toolStripButtonGenerarUsuario });
        toolStripMaterias.Location = new Point(3, 0);
        toolStripMaterias.Name = "toolStripMaterias";
        toolStripMaterias.Size = new Size(126, 25);
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
        // toolStripButtonGenerarUsuario
        // 
        toolStripButtonGenerarUsuario.DisplayStyle = ToolStripItemDisplayStyle.Image;
        toolStripButtonGenerarUsuario.Image = (Image)resources.GetObject("toolStripButtonGenerarUsuario.Image");
        toolStripButtonGenerarUsuario.ImageTransparentColor = Color.Magenta;
        toolStripButtonGenerarUsuario.Name = "toolStripButtonGenerarUsuario";
        toolStripButtonGenerarUsuario.Size = new Size(23, 22);
        toolStripButtonGenerarUsuario.Text = "generar usuario";
        toolStripButtonGenerarUsuario.Click += ToolStripButtonGenerarUsuarioClick;
        // 
        // ProfesoresForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(toolStripContainerProfesores);
        FormBorderStyle = FormBorderStyle.None;
        Name = "ProfesoresForm";
        Text = "Form1";
        Load += CursosForm_Load;
        toolStripContainerProfesores.ContentPanel.ResumeLayout(false);
        toolStripContainerProfesores.TopToolStripPanel.ResumeLayout(false);
        toolStripContainerProfesores.TopToolStripPanel.PerformLayout();
        toolStripContainerProfesores.ResumeLayout(false);
        toolStripContainerProfesores.PerformLayout();
        tableLayoutPanelProfesores.ResumeLayout(false);
        ((ISupportInitialize)dataGridViewProfesores).EndInit();
        toolStripMaterias.ResumeLayout(false);
        toolStripMaterias.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private ToolStripContainer toolStripContainerProfesores;
        private ToolStrip toolStripMaterias;
        private ToolStripButton toolStripButtonNuevo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonEliminar;
        private TableLayoutPanel tableLayoutPanelProfesores;
        private DataGridView dataGridViewProfesores;
        private Button buttonActualizar;
        private Button buttonVolver;
    private ToolStripButton toolStripButtonGenerarUsuario;
}