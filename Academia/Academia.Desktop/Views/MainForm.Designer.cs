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
        menuStripMain = new MenuStrip();
        inicioToolStripMenuItem = new ToolStripMenuItem();
        salirToolStripMenuItem = new ToolStripMenuItem();
        organizacionAcademicaToolStripMenuItem = new ToolStripMenuItem();
        IrEspecialidades = new ToolStripMenuItem();
        espeToolStripMenuItem = new ToolStripMenuItem();
        materiasToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem1 = new ToolStripMenuItem();
        alumnosToolStripMenuItem = new ToolStripMenuItem();
        menuStripMain.SuspendLayout();
        SuspendLayout();
        // 
        // menuStripMain
        // 
        menuStripMain.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, organizacionAcademicaToolStripMenuItem, alumnosToolStripMenuItem });
        menuStripMain.Location = new Point(0, 0);
        menuStripMain.Name = "menuStripMain";
        menuStripMain.Size = new Size(800, 24);
        menuStripMain.TabIndex = 4;
        menuStripMain.Text = "menuStripMain";
        // 
        // inicioToolStripMenuItem
        // 
        inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
        inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
        inicioToolStripMenuItem.Size = new Size(60, 20);
        inicioToolStripMenuItem.Text = "Archivo";
        // 
        // salirToolStripMenuItem
        // 
        salirToolStripMenuItem.Name = "salirToolStripMenuItem";
        salirToolStripMenuItem.Size = new Size(96, 22);
        salirToolStripMenuItem.Text = "Salir";
        salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
        // 
        // organizacionAcademicaToolStripMenuItem
        // 
        organizacionAcademicaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { IrEspecialidades, espeToolStripMenuItem, materiasToolStripMenuItem });
        organizacionAcademicaToolStripMenuItem.Name = "organizacionAcademicaToolStripMenuItem";
        organizacionAcademicaToolStripMenuItem.Size = new Size(151, 20);
        organizacionAcademicaToolStripMenuItem.Text = "Organizacion Academica";
        // 
        // IrEspecialidades
        // 
        IrEspecialidades.Name = "IrEspecialidades";
        IrEspecialidades.Size = new Size(150, 22);
        IrEspecialidades.Text = "Especialidades";
        IrEspecialidades.Click += IrEspecialidades_Click;
        // 
        // espeToolStripMenuItem
        // 
        espeToolStripMenuItem.Name = "espeToolStripMenuItem";
        espeToolStripMenuItem.Size = new Size(150, 22);
        espeToolStripMenuItem.Text = "Planes";
        espeToolStripMenuItem.Click += espeToolStripMenuItem_Click;
        // 
        // materiasToolStripMenuItem
        // 
        materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
        materiasToolStripMenuItem.Size = new Size(150, 22);
        materiasToolStripMenuItem.Text = "Materias";
        materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(32, 19);
        // 
        // alumnosToolStripMenuItem
        // 
        alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
        alumnosToolStripMenuItem.Size = new Size(67, 20);
        alumnosToolStripMenuItem.Text = "Alumnos";
        alumnosToolStripMenuItem.Click += alumnosToolStripMenuItem_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(menuStripMain);
        IsMdiContainer = true;
        Name = "MainForm";
        Text = "Academia";
        Load += MainForm_Load;
        menuStripMain.ResumeLayout(false);
        menuStripMain.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    #endregion

    private MenuStrip menuStripMain;
    private ToolStripMenuItem inicioToolStripMenuItem;
    private ToolStripMenuItem salirToolStripMenuItem;
    private ToolStripMenuItem organizacionAcademicaToolStripMenuItem;
    private ToolStripMenuItem IrEspecialidades;
    private ToolStripMenuItem espeToolStripMenuItem;
    private ToolStripMenuItem materiasToolStripMenuItem;
    private ToolStripMenuItem alumnosToolStripMenuItem;
}