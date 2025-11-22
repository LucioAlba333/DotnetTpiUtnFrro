using System.ComponentModel;

namespace Academia.Desktop.Views.Alumnos;

partial class AlumnosForm
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(AlumnosForm));
        toolStripContainerAlumnos = new ToolStripContainer();
        tableLayoutPanelAlumnos = new TableLayoutPanel();
        dataGridViewAlumnos = new DataGridView();
        buttonActualizar = new Button();
        buttonVolver = new Button();
        toolStripAlumnos = new ToolStrip();
        toolStripButtonNuevo = new ToolStripButton();
        toolStripButtonEditar = new ToolStripButton();
        toolStripButtonEliminar = new ToolStripButton();
        toolStripButtonGenerarUsuario = new ToolStripButton();
        toolStripContainerAlumnos.ContentPanel.SuspendLayout();
        toolStripContainerAlumnos.TopToolStripPanel.SuspendLayout();
        toolStripContainerAlumnos.SuspendLayout();
        tableLayoutPanelAlumnos.SuspendLayout();
        ((ISupportInitialize)dataGridViewAlumnos).BeginInit();
        toolStripAlumnos.SuspendLayout();
        SuspendLayout();
        // 
        // toolStripContainerAlumnos
        // 
        // 
        // toolStripContainerAlumnos.ContentPanel
        // 
        toolStripContainerAlumnos.ContentPanel.Controls.Add(tableLayoutPanelAlumnos);
        toolStripContainerAlumnos.ContentPanel.Size = new Size(800, 425);
        toolStripContainerAlumnos.Dock = DockStyle.Fill;
        toolStripContainerAlumnos.Location = new Point(0, 0);
        toolStripContainerAlumnos.Name = "toolStripContainerAlumnos";
        toolStripContainerAlumnos.Size = new Size(800, 450);
        toolStripContainerAlumnos.TabIndex = 0;
        toolStripContainerAlumnos.Text = "toolStripContainer1";
        // 
        // toolStripContainerAlumnos.TopToolStripPanel
        // 
        toolStripContainerAlumnos.TopToolStripPanel.Controls.Add(toolStripAlumnos);
        // 
        // tableLayoutPanelAlumnos
        // 
        tableLayoutPanelAlumnos.ColumnCount = 2;
        tableLayoutPanelAlumnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanelAlumnos.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanelAlumnos.Controls.Add(dataGridViewAlumnos, 0, 0);
        tableLayoutPanelAlumnos.Controls.Add(buttonActualizar, 0, 1);
        tableLayoutPanelAlumnos.Controls.Add(buttonVolver, 1, 1);
        tableLayoutPanelAlumnos.Dock = DockStyle.Fill;
        tableLayoutPanelAlumnos.Location = new Point(0, 0);
        tableLayoutPanelAlumnos.Name = "tableLayoutPanelAlumnos";
        tableLayoutPanelAlumnos.RowCount = 2;
        tableLayoutPanelAlumnos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanelAlumnos.RowStyles.Add(new RowStyle());
        tableLayoutPanelAlumnos.Size = new Size(800, 425);
        tableLayoutPanelAlumnos.TabIndex = 0;
        // 
        // dataGridViewAlumnos
        // 
        dataGridViewAlumnos.AllowUserToAddRows = false;
        dataGridViewAlumnos.AllowUserToDeleteRows = false;
        dataGridViewAlumnos.AllowUserToResizeColumns = false;
        dataGridViewAlumnos.AllowUserToResizeRows = false;
        dataGridViewAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableLayoutPanelAlumnos.SetColumnSpan(dataGridViewAlumnos, 2);
        dataGridViewAlumnos.Dock = DockStyle.Fill;
        dataGridViewAlumnos.Location = new Point(3, 3);
        dataGridViewAlumnos.Name = "dataGridViewAlumnos";
        dataGridViewAlumnos.ReadOnly = true;
        dataGridViewAlumnos.Size = new Size(794, 390);
        dataGridViewAlumnos.TabIndex = 0;
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
        // toolStripAlumnos
        // 
        toolStripAlumnos.Dock = DockStyle.None;
        toolStripAlumnos.GripStyle = ToolStripGripStyle.Hidden;
        toolStripAlumnos.Items.AddRange(new ToolStripItem[] { toolStripButtonNuevo, toolStripButtonEditar, toolStripButtonEliminar, toolStripButtonGenerarUsuario });
        toolStripAlumnos.Location = new Point(3, 0);
        toolStripAlumnos.Name = "toolStripAlumnos";
        toolStripAlumnos.Size = new Size(126, 25);
        toolStripAlumnos.TabIndex = 0;
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
        Controls.Add(toolStripContainerAlumnos);
        FormBorderStyle = FormBorderStyle.None;
        Name = "AlumnosForm";
        Text = "Form1";
        Load += AlumnosForm_Load;
        toolStripContainerAlumnos.ContentPanel.ResumeLayout(false);
        toolStripContainerAlumnos.TopToolStripPanel.ResumeLayout(false);
        toolStripContainerAlumnos.TopToolStripPanel.PerformLayout();
        toolStripContainerAlumnos.ResumeLayout(false);
        toolStripContainerAlumnos.PerformLayout();
        tableLayoutPanelAlumnos.ResumeLayout(false);
        ((ISupportInitialize)dataGridViewAlumnos).EndInit();
        toolStripAlumnos.ResumeLayout(false);
        toolStripAlumnos.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private ToolStripContainer toolStripContainerAlumnos;
        private ToolStrip toolStripAlumnos;
        private ToolStripButton toolStripButtonNuevo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonEliminar;
        private TableLayoutPanel tableLayoutPanelAlumnos;
        private DataGridView dataGridViewAlumnos;
        private Button buttonActualizar;
        private Button buttonVolver;
    private ToolStripButton toolStripButtonGenerarUsuario;
}