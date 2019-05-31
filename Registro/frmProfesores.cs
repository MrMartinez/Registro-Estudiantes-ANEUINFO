using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.Helpers;
using Entity;

namespace Registro
{
    public partial class frmProfesores : Form
    {
        public string strcon = string.Empty;

        public frmProfesores()
        {
            InitializeComponent();
            try
            {
                strcon = SingletonConnection.Instance._connection;
            }
            catch (Exception)
            {

                MessageBox.Show("Error conectando a la base de datos");
            }
        }
      

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Profesores profe = new Profesores();
            //Nota: como voy hacer con los IDs Profesor y cursos? Una coleccion?
            // creando un objeto de tipo list de estas dos entidades para relacionarlos
            //con el estudiante?

            
            profe.Cedula = txtCedula.Text;
            profe.Nombres = txtNombres.Text;
            profe.Apellidos = txtApellidos.Text;
            profe.Celular = txtCelular.Text;
            profe.Telefono = txtTelefono.Text;
            profe.Direccion = txtDireccion.Text;
            profe.Comentario = txtComentario.Text;


            //Esta parte del codigo esta de la manera tradicional; preguntar a Francis como es
            // mejor? si es valido usar las sentencias de SQL como SELECT, INSERT o por el ADD
            // del objeto instanciado de las clases?
            try
            {
                string sql = "";
                SqlConnection con = new SqlConnection(strcon);

                sql = "INSERT INTO tblProfesores (Cedula, Nombres, Apellidos, Sexo, Telefono, Celular, Direccion, Comentario ) " +
                      "VALUES (@Cedula, @Nombres, @Apellidos, @Sexo, @Telefono, @Celular, @Direccion, @Comentario )";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                // cmd.Parameters.AddWithValue("@Id", es.IdEstudiante);
                cmd.Parameters.AddWithValue("@Cedula", profe.Cedula);
                cmd.Parameters.AddWithValue("@Nombres", profe.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", profe.Apellidos);
                cmd.Parameters.AddWithValue("@Sexo", profe.Sexo);
                cmd.Parameters.AddWithValue("@Telefono", profe.Telefono);
                cmd.Parameters.AddWithValue("@Celular", profe.Celular);
                //cmd.Parameters.AddWithValue("@FechaIngreso", dtpFechaIngreso.Value);
                //cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                cmd.Parameters.AddWithValue("@Direccion", profe.Direccion);
                cmd.Parameters.AddWithValue("@Comentario", profe.Comentario);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Registro ingresado!!!");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ingresando profesor" + ex);
            }
            cargarDataGrid();
        
    }
        private void cargarDataGrid()
        {
            dgvProfesores.DataSource = null;
            SqlConnection cn = new SqlConnection(strcon);
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Profesores", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvProfesores.DataSource = ds.Tables[0];
            cn.Close();

        }
        private void frmProfesores_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            this.Close();
            principal.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
