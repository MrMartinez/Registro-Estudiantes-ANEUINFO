using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entity;
using BL.Helpers;
//using System.Data.Entity;

namespace Registro
{
    public partial class Login : Form
    {

        string strcon = string.Empty;
        public Login()
        {
            InitializeComponent();
            strcon = SingletonConnection.Instance._connection;
        }
        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            IniciarSession();           

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IniciarSession()
        {
            Usuarios user = new Usuarios();
            user.Nombre = txtUsuario.Text;
            user.Clave = txtContraseña.Text;

            string sql = "Select * From Usuarios Where " +
                            "Identificador = '" + user.Nombre + "' " +
                             "and (pwdCompare('" + user.Clave + "',Clave) > 0)";
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader resultado;
            resultado = cmd.ExecuteReader();
            if (resultado.HasRows)
            {
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lo siento! Credenciales invalidas");
            }
            cn.Close();
        }


        private void Login_Load(object sender, EventArgs e)
        {
           

        }
    }
}
