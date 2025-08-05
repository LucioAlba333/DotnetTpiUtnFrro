namespace Academia.Desktop
{
    partial class FormPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlan));
            tlPlanes = new ToolStripContainer();
            tableLayoutPlanes = new TableLayoutPanel();
            dgvPlanes = new DataGridView();
            buttonActualizar = new Button();
            buttonVolver = new Button();
            toolStrip1 = new ToolStrip();
            buttoNew = new ToolStripButton();
            buttonEdit = new ToolStripButton();
            buttonDelete = new ToolStripButton();
            tlPlanes.ContentPanel.SuspendLayout();
            tlPlanes.TopToolStripPanel.SuspendLayout();
            tlPlanes.SuspendLayout();
            tableLayoutPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tlPlanes
            // 
            // 
            // tlPlanes.ContentPanel
            // 
            tlPlanes.ContentPanel.Controls.Add(tableLayoutPlanes);
            tlPlanes.ContentPanel.Size = new Size(484, 436);
            tlPlanes.Dock = DockStyle.Fill;
            tlPlanes.Location = new Point(0, 0);
            tlPlanes.Name = "tlPlanes";
            tlPlanes.Size = new Size(484, 461);
            tlPlanes.TabIndex = 0;
            tlPlanes.Text = "toolStripContainer1";
            // 
            // tlPlanes.TopToolStripPanel
            // 
            tlPlanes.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // tableLayoutPlanes
            // 
            tableLayoutPlanes.ColumnCount = 2;
            tableLayoutPlanes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPlanes.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPlanes.Controls.Add(dgvPlanes, 0, 0);
            tableLayoutPlanes.Controls.Add(buttonActualizar, 0, 1);
            tableLayoutPlanes.Controls.Add(buttonVolver, 1, 1);
            tableLayoutPlanes.Dock = DockStyle.Fill;
            tableLayoutPlanes.Location = new Point(0, 0);
            tableLayoutPlanes.Name = "tableLayoutPlanes";
            tableLayoutPlanes.RowCount = 2;
            tableLayoutPlanes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPlanes.RowStyles.Add(new RowStyle());
            tableLayoutPlanes.Size = new Size(484, 436);
            tableLayoutPlanes.TabIndex = 0;
            // 
            // dgvPlanes
            // 
            dgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPlanes.SetColumnSpan(dgvPlanes, 2);
            dgvPlanes.Dock = DockStyle.Fill;
            dgvPlanes.Location = new Point(3, 3);
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.Size = new Size(478, 401);
            dgvPlanes.TabIndex = 0;
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
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { buttoNew, buttonEdit, buttonDelete });
            toolStrip1.Location = new Point(5, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(81, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // buttoNew
            // 
            buttoNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttoNew.Image = (Image)resources.GetObject("buttoNew.Image");
            buttoNew.ImageTransparentColor = Color.Magenta;
            buttoNew.Name = "buttoNew";
            buttoNew.Size = new Size(23, 22);
            buttoNew.Text = "toolStripButton1";
            buttoNew.Click += buttoNew_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.ImageTransparentColor = Color.Magenta;
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(23, 22);
            buttonEdit.Text = "toolStripButton2";
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageTransparentColor = Color.Magenta;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(23, 22);
            buttonDelete.Text = "toolStripButton3";
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 461);
            Controls.Add(tlPlanes);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "FormPlan";
            Text = "Academia/Planes";
            Load += FormPlan_Load;
            tlPlanes.ContentPanel.ResumeLayout(false);
            tlPlanes.TopToolStripPanel.ResumeLayout(false);
            tlPlanes.TopToolStripPanel.PerformLayout();
            tlPlanes.ResumeLayout(false);
            tlPlanes.PerformLayout();
            tableLayoutPlanes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer tlPlanes;
        private ToolStrip toolStrip1;
        private ToolStripButton buttoNew;
        private ToolStripButton buttonEdit;
        private ToolStripButton buttonDelete;
        private TableLayoutPanel tableLayoutPlanes;
        private DataGridView dgvPlanes;
        private Button buttonActualizar;
        private Button buttonVolver;
    }
}