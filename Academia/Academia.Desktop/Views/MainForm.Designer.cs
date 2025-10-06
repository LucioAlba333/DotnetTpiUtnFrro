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
        menuStripMain.SuspendLayout();
        SuspendLayout();
        // 
        // menuStripMain
        // 
        menuStripMain.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, organizacionAcademicaToolStripMenuItem });
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
        IrEspecialidades.Size = new Size(180, 22);
        IrEspecialidades.Text = "Especialidades";
        IrEspecialidades.Click += IrEspecialidades_Click;
        // 
        // espeToolStripMenuItem
        // 
        espeToolStripMenuItem.Name = "espeToolStripMenuItem";
        espeToolStripMenuItem.Size = new Size(180, 22);
        espeToolStripMenuItem.Text = "Planes";
        espeToolStripMenuItem.Click += espeToolStripMenuItem_Click;
        // 
        // materiasToolStripMenuItem
        // 
        materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
        materiasToolStripMenuItem.Size = new Size(180, 22);
        materiasToolStripMenuItem.Text = "Materias";
        materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
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

    #endregion

    private MenuStrip menuStripMain;
    private ToolStripMenuItem inicioToolStripMenuItem;
    private ToolStripMenuItem salirToolStripMenuItem;
    private ToolStripMenuItem organizacionAcademicaToolStripMenuItem;
    private ToolStripMenuItem IrEspecialidades;
    private ToolStripMenuItem espeToolStripMenuItem;
    private ToolStripMenuItem materiasToolStripMenuItem;
}