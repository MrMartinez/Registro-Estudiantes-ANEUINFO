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
            this.tsbRegistroEstudiante = new System.Windows.Forms.ToolStripButton();
            this.tsbRegistrarProfesor = new System.Windows.Forms.ToolStripButton();
            this.tsbCrearCurso = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbAcerca = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRegistroEstudiante,
            this.toolStripSeparator3,
            this.tsbRegistrarProfesor,
            this.toolStripSeparator4,
            this.tsbCrearCurso,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.tsbSalir,
            this.toolStripSeparator1,
            this.tsbAcerca,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1286, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRegistroEstudiante
            // 
            this.tsbRegistroEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("tsbRegistroEstudiante.Image")));
            this.tsbRegistroEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbRegistroEstudiante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRegistroEstudiante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegistroEstudiante.Name = "tsbRegistroEstudiante";
            this.tsbRegistroEstudiante.Size = new System.Drawing.Size(177, 36);
            this.tsbRegistroEstudiante.Text = "Registrar Estudiante";
            this.tsbRegistroEstudiante.Click += new System.EventHandler(this.tsbRegistroEstudiante_Click);
            // 
            // tsbRegistrarProfesor
            // 
            this.tsbRegistrarProfesor.Image = ((System.Drawing.Image)(resources.GetObject("tsbRegistrarProfesor.Image")));
            this.tsbRegistrarProfesor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRegistrarProfesor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegistrarProfesor.Name = "tsbRegistrarProfesor";
            this.tsbRegistrarProfesor.Size = new System.Drawing.Size(163, 36);
            this.tsbRegistrarProfesor.Text = "Registrar Profesor";
            this.tsbRegistrarProfesor.Click += new System.EventHandler(this.tsbRegistrarProfesor_Click);
            // 
            // tsbCrearCurso
            // 
            this.tsbCrearCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbCrearCurso.Image = ((System.Drawing.Image)(resources.GetObject("tsbCrearCurso.Image")));
            this.tsbCrearCurso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCrearCurso.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCrearCurso.Name = "tsbCrearCurso";
            this.tsbCrearCurso.Size = new System.Drawing.Size(121, 36);
            this.tsbCrearCurso.Text = "Crear Curso";
            this.tsbCrearCurso.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(74, 36);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsbAcerca
            // 
            this.tsbAcerca.Image = ((System.Drawing.Image)(resources.GetObject("tsbAcerca.Image")));
            this.tsbAcerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAcerca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAcerca.Name = "tsbAcerca";
            this.tsbAcerca.Size = new System.Drawing.Size(111, 36);
            this.tsbAcerca.Text = "Acerca de";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(162, 36);
            this.toolStripButton1.Text = "Crear Universidad";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1286, 673);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripButton tsbRegistroEstudiante;
        private System.Windows.Forms.ToolStripButton tsbRegistrarProfesor;
        private System.Windows.Forms.ToolStripButton tsbCrearCurso;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbAcerca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}