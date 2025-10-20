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
        menuStripMain = new System.Windows.Forms.MenuStrip();
        inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        organizacionAcademicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        IrEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
        espeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        menuStripMain.SuspendLayout();
        SuspendLayout();
        // 
        // menuStripMain
        // 
        menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { inicioToolStripMenuItem, organizacionAcademicaToolStripMenuItem });
        menuStripMain.Location = new System.Drawing.Point(0, 0);
        menuStripMain.Name = "menuStripMain";
        menuStripMain.Size = new System.Drawing.Size(800, 24);
        menuStripMain.TabIndex = 4;
        menuStripMain.Text = "menuStripMain";
        // 
        // inicioToolStripMenuItem
        // 
        inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { salirToolStripMenuItem });
        inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
        inicioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
        inicioToolStripMenuItem.Text = "Archivo";
        // 
        // salirToolStripMenuItem
        // 
        salirToolStripMenuItem.Name = "salirToolStripMenuItem";
        salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        salirToolStripMenuItem.Text = "Salir";
        salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
        // 
        // organizacionAcademicaToolStripMenuItem
        // 
        organizacionAcademicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { IrEspecialidades, espeToolStripMenuItem, materiasToolStripMenuItem });
        organizacionAcademicaToolStripMenuItem.Name = "organizacionAcademicaToolStripMenuItem";
        organizacionAcademicaToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
        organizacionAcademicaToolStripMenuItem.Text = "Organizacion Academica";
        // 
        // IrEspecialidades
        // 
        IrEspecialidades.Name = "IrEspecialidades";
        IrEspecialidades.Size = new System.Drawing.Size(180, 22);
        IrEspecialidades.Text = "Especialidades";
        IrEspecialidades.Click += IrEspecialidades_Click;
        // 
        // espeToolStripMenuItem
        // 
        espeToolStripMenuItem.Name = "espeToolStripMenuItem";
        espeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        espeToolStripMenuItem.Text = "Planes";
        espeToolStripMenuItem.Click += espeToolStripMenuItem_Click;
        // 
        // materiasToolStripMenuItem
        // 
        materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
        materiasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        materiasToolStripMenuItem.Text = "Materias";
        materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(menuStripMain);
        IsMdiContainer = true;
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
}