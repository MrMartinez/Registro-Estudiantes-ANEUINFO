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
     
        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            frmEstudiante frmEstudiantes = new frmEstudiante();
            frmEstudiantes.Show();
            this.Hide();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            frmProfesores profesores = new frmProfesores();
            profesores.Show();
            this.Hide();
        }

        private void btnUniversidades_Click(object sender, EventArgs e)
        {
            frmUniversidad universidad = new frmUniversidad();
            universidad.Show();
            this.Hide();
        }
    }
}
