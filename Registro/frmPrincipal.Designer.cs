namespace Registro
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMantenimientos = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnEstudiantes = new System.Windows.Forms.ToolStripButton();
            this.btnProfesores = new System.Windows.Forms.ToolStripButton();
            this.btnCursos = new System.Windows.Forms.ToolStripButton();
            this.btnUniversidades = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAcerca = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.toolStripButton2,
            this.toolStripSeparator7,
            this.tsbMantenimientos,
            this.toolStripSeparator3,
            this.tsbSalir,
            this.toolStripSeparator1,
            this.tsbAcerca,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 71);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 68);
            this.toolStripButton2.Text = "Inscripciones";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbMantenimientos
            // 
            this.tsbMantenimientos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEstudiantes,
            this.btnProfesores,
            this.btnCursos,
            this.btnUniversidades});
            this.tsbMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("tsbMantenimientos.Image")));
            this.tsbMantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbMantenimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMantenimientos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMantenimientos.Name = "tsbMantenimientos";
            this.tsbMantenimientos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbMantenimientos.Size = new System.Drawing.Size(77, 68);
            this.tsbMantenimientos.Text = "Mantenimientos";
            this.tsbMantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbMantenimientos.ToolTipText = "Mantenimientos";
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("btnEstudiantes.Image")));
            this.btnEstudiantes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstudiantes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEstudiantes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(103, 36);
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Image = ((System.Drawing.Image)(resources.GetObject("btnProfesores.Image")));
            this.btnProfesores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProfesores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(98, 36);
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCursos.Image = ((System.Drawing.Image)(resources.GetObject("btnCursos.Image")));
            this.btnCursos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCursos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(79, 36);
            this.btnCursos.Text = "Cursos";
            // 
            // btnUniversidades
            // 
            this.btnUniversidades.Image = ((System.Drawing.Image)(resources.GetObject("btnUniversidades.Image")));
            this.btnUniversidades.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUniversidades.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUniversidades.Name = "btnUniversidades";
            this.btnUniversidades.Size = new System.Drawing.Size(116, 36);
            this.btnUniversidades.Text = "Universidades";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbSalir
            // 
            this.tsbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(65, 68);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // tsbAcerca
            // 
            this.tsbAcerca.Image = ((System.Drawing.Image)(resources.GetObject("tsbAcerca.Image")));
            this.tsbAcerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAcerca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAcerca.Name = "tsbAcerca";
            this.tsbAcerca.Size = new System.Drawing.Size(95, 68);
            this.tsbAcerca.Text = "Acerca de";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 547);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Registro ANEUINFO";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbAcerca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripDropDownButton tsbMantenimientos;
        private System.Windows.Forms.ToolStripButton btnEstudiantes;
        private System.Windows.Forms.ToolStripButton btnProfesores;
        private System.Windows.Forms.ToolStripButton btnCursos;
        private System.Windows.Forms.ToolStripButton btnUniversidades;
    }
}