﻿using System;
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
//using Data;

namespace Registro
{
    public partial class Estudiante : Form
    {
        public string strcon = string.Empty;

        SqlDataAccess helper = new SqlDataAccess();

        public Estudiante()
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
            CrearEstudiante();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void dgvEstudiantes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvEstudiantes.CurrentRow.Cells["IdEstudiante"].Value.ToString();
            txtCedula.Text = dgvEstudiantes.CurrentRow.Cells["Cedula"].Value.ToString();
            txtNombres.Text = dgvEstudiantes.CurrentRow.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = dgvEstudiantes.CurrentRow.Cells["Apellidos"].Value.ToString();
            //dtpFechaNacimiento.Value =Convert.ToDateTime(dgvEstudiantes.CurrentRow.Cells["FechaNacimiento"].Value.);
            //dtpFechaIngreso.Value = Convert.ToDateTime(dgvEstudiantes.CurrentRow.Cells["FechaIngreso"].Value);
            if (dgvEstudiantes.CurrentRow.Cells["Sexo"].Value.ToString() == "M")
            {
                txtSexo.SelectedIndex = 1;
            }
            else
            {
                txtSexo.SelectedItem = 2;
            }
            ;
            txtTelefono.Text = dgvEstudiantes.CurrentRow.Cells["Telefono"].Value.ToString();
            txtCelular.Text = dgvEstudiantes.CurrentRow.Cells["Celular"].Value.ToString();
            txtDireccion.Text = dgvEstudiantes.CurrentRow.Cells["Direccion"].Value.ToString();
            txtComentario.Text = dgvEstudiantes.CurrentRow.Cells["Comentario"].Value.ToString();
            activarBotones();
            tabControl1.TabPages[0].Focus();
            txtNombres.Focus();
        }

        private void CrearEstudiante()
        {
            Estudiantes es = new Estudiantes();

            #region Asignando valores a las propiedades del obj Estudiante

            es.Cedula = txtCedula.Text.Replace(@"-", "");
            es.Nombres = txtNombres.Text;
            es.Apellidos = txtApellidos.Text;
            es.Celular = txtCelular.Text.Replace(@"(", "").Replace(@")", "").Replace(@"-", "");
            es.Telefono = txtTelefono.Text.Replace(@"(", "").Replace(@")", "").Replace(@"-", "");
            es.Direccion = txtDireccion.Text;
            es.Comentario = txtComentario.Text;
            if (txtSexo.SelectedIndex > 0)
            {
                if (txtSexo.SelectedIndex == 1)
                {
                    es.Sexo = 'M';
                }
                if (txtSexo.SelectedIndex == 2)
                {
                    es.Sexo = 'F';
                }

            }
            else
            {
                errorProviderEstudiantes.SetError(txtSexo, "Debe seleccionar un genero");
                txtSexo.Focus();
                return;
            }
            #endregion

            try
            {
                if (txtNombres.Text == "")
                {
                    errorProviderEstudiantes.SetError(txtNombres, "Ingrese un nombre");
                    txtNombres.Focus();
                    return;
                }
                errorProviderEstudiantes.SetError(txtNombres, "");

                if (txtApellidos.Text == "")
                {
                    errorProviderEstudiantes.SetError(txtApellidos, "Ingrese un nombre");
                    txtNombres.Focus();
                    return;
                }
                errorProviderEstudiantes.SetError(txtApellidos, "");

                #region Creando los parametros que se enviaran al helper
                SqlParameter[] parameters = {
                    new SqlParameter("@Cedula", es.Cedula),
                    new SqlParameter("@Nombres", es.Nombres),
                    new SqlParameter("@Apellidos", es.Apellidos),
                    new SqlParameter("@Sexo", es.Sexo),
                    new SqlParameter("@Telefono", es.Telefono),
                    new SqlParameter("@Celular", es.Celular),
                    new SqlParameter("@FechaIngreso", dtpFechaIngreso.Value),
                    new SqlParameter("@FechaNacimiento", dtpFechaNacimiento.Value),
                    new SqlParameter("@Direccion", es.Direccion),
                    new SqlParameter("@Comentario", es.Comentario),
                }; 
                #endregion

                helper.executeNonQuery("INSERT INTO Estudiantes (Cedula, Nombres, Apellidos, Sexo, Telefono, Celular, FechaNacimiento, FechaIngreso, Direccion, Comentario ) " +
                                          "VALUES (@Cedula, @Nombres, @Apellidos, @Sexo, @Telefono, @Celular, CONVERT(DATETIME,@FechaNacimiento, 103), CONVERT(DATETIME,@FechaIngreso, 103), @Direccion, @Comentario )", CommandType.Text, parameters);

                #region Codigo anterior para guardar un estudiante
                //string sql = "";
                //SqlConnection con = new SqlConnection(strcon);

                //sql = "INSERT INTO Estudiantes (Cedula, Nombres, Apellidos, Sexo, Telefono, Celular, FechaNacimiento, FechaIngreso, Direccion, Comentario ) " +
                //      "VALUES (@Cedula, @Nombres, @Apellidos, @Sexo, @Telefono, @Celular, CONVERT(DATETIME,@FechaNacimiento, 103), CONVERT(DATETIME,@FechaIngreso, 103), @Direccion, @Comentario )";

                //SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@Cedula", es.Cedula);
                //cmd.Parameters.AddWithValue("@Nombres", es.Nombres);
                //cmd.Parameters.AddWithValue("@Apellidos", es.Apellidos);
                //cmd.Parameters.AddWithValue("@Sexo", es.Sexo);
                //cmd.Parameters.AddWithValue("@Telefono", es.Telefono);
                //cmd.Parameters.AddWithValue("@Celular", es.Celular);
                //cmd.Parameters.AddWithValue("@FechaIngreso", dtpFechaIngreso.Value);
                //cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                //cmd.Parameters.AddWithValue("@Direccion", es.Direccion);
                //cmd.Parameters.AddWithValue("@Comentario", es.Comentario);
                //con.Open();
                //int i = cmd.ExecuteNonQuery();
                //if (i > 0)
                //{
                //    MessageBox.Show("Registro ingresado!!!");
                //} 
                #endregion
                cargarDataGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ingresando Estudiantes" + ex);
            }

            limpiarDatos();
        }

        private void limpiarDatos()
        {
            txtID.Text = "";
            txtCedula.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtSexo.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
            txtComentario.Text = "";
            txtNombres.Focus();
        }
        
        private void Estudiante_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
            activarBotones();
        }

        private void cargarDataGrid()
        {
            dgvEstudiantes.DataSource = null;
            var dataSource = helper.executeQuery("Select * from Estudiantes", CommandType.Text, null);


            #region Codigo anterior para llenar el grid
            //SqlConnection cn = new SqlConnection(strcon);
            //cn.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Estudiantes", cn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //cn.Close(); 
            #endregion

            dgvEstudiantes.DataSource = dataSource.Tables[0];

        }

        private void activarBotones()
        {

         
            if (txtID.Text == "")
            {
                btnLimpiar.Enabled = false;
                btnModificar.Enabled = false;
                btnCrear.Enabled = false;
            }
            else
            {
                btnLimpiar.Enabled = true;
                btnCrear.Enabled = false;
                btnModificar.Enabled = true;
                return;
            }

            var nombre = string.IsNullOrEmpty(txtNombres.Text) ? btnCrear.Enabled = false : btnCrear.Enabled = true;
        
          
            
            
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            activarBotones();
        }
    }
}
