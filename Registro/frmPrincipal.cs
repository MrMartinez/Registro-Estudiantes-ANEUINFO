using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrarEstudiantes_Click(object sender, EventArgs e)
        {
            Estudiante frmEstudiantes = new Estudiante();
            frmEstudiantes.Show();
            this.Hide();
        }

        private void btnRegistrarProfesores_Click(object sender, EventArgs e)
        {
            frmProfesores profesores = new frmProfesores();
            profesores.Show();
            this.Close();
           
        }

        private void tsbRegistroEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante frmEstudiantes = new Estudiante();
            frmEstudiantes.Show();
            this.Hide();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbRegistrarProfesor_Click(object sender, EventArgs e)
        {
            frmProfesores profesores = new frmProfesores();
            profesores.Show();
            this.Hide();
            
        }
    }
}
