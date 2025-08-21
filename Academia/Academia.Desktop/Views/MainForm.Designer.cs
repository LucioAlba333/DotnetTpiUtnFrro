using System.ComponentModel;

namespace Academia.Desktop.Views;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        toolStripContainerMain = new ToolStripContainer();
        menuStripMain = new MenuStrip();
        inicioToolStripMenuItem = new ToolStripMenuItem();
        organizacionAcademicaToolStripMenuItem = new ToolStripMenuItem();
        planesToolStripMenuItem = new ToolStripMenuItem();
        espeToolStripMenuItem = new ToolStripMenuItem();
        salirToolStripMenuItem = new ToolStripMenuItem();
        toolStripContainerMain.SuspendLayout();
        menuStripMain.SuspendLayout();
        SuspendLayout();
        // 
        // toolStripContainerMain
        // 
        // 
        // toolStripContainerMain.ContentPanel
        // 
        toolStripContainerMain.ContentPanel.Size = new Size(800, 401);
        toolStripContainerMain.Dock = DockStyle.Fill;
        toolStripContainerMain.Location = new Point(0, 24);
        toolStripContainerMain.Name = "toolStripContainerMain";
        toolStripContainerMain.Size = new Size(800, 426);
        toolStripContainerMain.TabIndex = 1;
        toolStripContainerMain.Text = "toolStripContainerMain";
        // 
        // menuStripMain
        // 
        menuStripMain.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, organizacionAcademicaToolStripMenuItem });
        menuStripMain.Location = new Point(0, 0);
        menuStripMain.Name = "menuStripMain";
        menuStripMain.Size = new Size(800, 24);
        menuStripMain.TabIndex = 2;
        menuStripMain.Text = "menuStripMain";
        // 
        // inicioToolStripMenuItem
        // 
        inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
        inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
        inicioToolStripMenuItem.Size = new Size(60, 20);
        inicioToolStripMenuItem.Text = "Archivo";
        // 
        // organizacionAcademicaToolStripMenuItem
        // 
        organizacionAcademicaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { planesToolStripMenuItem, espeToolStripMenuItem });
        organizacionAcademicaToolStripMenuItem.Name = "organizacionAcademicaToolStripMenuItem";
        organizacionAcademicaToolStripMenuItem.Size = new Size(151, 20);
        organizacionAcademicaToolStripMenuItem.Text = "Organizacion Academica";
        // 
        // planesToolStripMenuItem
        // 
        planesToolStripMenuItem.Name = "planesToolStripMenuItem";
        planesToolStripMenuItem.Size = new Size(180, 22);
        planesToolStripMenuItem.Text = "Especialidades";
        // 
        // espeToolStripMenuItem
        // 
        espeToolStripMenuItem.Name = "espeToolStripMenuItem";
        espeToolStripMenuItem.Size = new Size(180, 22);
        espeToolStripMenuItem.Text = "Planes";
        // 
        // salirToolStripMenuItem
        // 
        salirToolStripMenuItem.Name = "salirToolStripMenuItem";
        salirToolStripMenuItem.Size = new Size(180, 22);
        salirToolStripMenuItem.Text = "Salir";
        salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(toolStripContainerMain);
        Controls.Add(menuStripMain);
        IsMdiContainer = true;
        MainMenuStrip = menuStripMain;
        Name = "MainForm";
        Text = "MainForm";
        toolStripContainerMain.ResumeLayout(false);
        toolStripContainerMain.PerformLayout();
        menuStripMain.ResumeLayout(false);
        menuStripMain.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
    private System.Windows.Forms.MenuStrip menuStripMain;

    #endregion

    private ToolStripMenuItem inicioToolStripMenuItem;
    private ToolStripMenuItem organizacionAcademicaToolStripMenuItem;
    private ToolStripMenuItem planesToolStripMenuItem;
    private ToolStripMenuItem espeToolStripMenuItem;
    private ToolStripMenuItem salirToolStripMenuItem;
}