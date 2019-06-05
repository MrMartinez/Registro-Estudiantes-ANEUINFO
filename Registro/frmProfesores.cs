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
using System.IO;

namespace Registro
{
    
    public partial class frmProfesores : Form
    {
  
        public string strcon = string.Empty;
        SqlDataAccess helper = new SqlDataAccess();
        
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
      
        private void frmProfesores_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
            activarBotones();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearProfesor();

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            this.Close();
            principal.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void dgvProfesores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BuscarProfesor();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarProfesor();
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxFoto.Load(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error localizando imagen" + ex);
            }
        }

        private void CrearProfesor()
        {
            Profesor profe = new Profesor();

            #region Asignando valores a las propiedades del obj Estudiante

            profe.Cedula = txtCedula.Text.Replace(@"-", "");
            profe.Nombres = txtNombres.Text;
            profe.Apellidos = txtApellidos.Text;
            profe.Celular = txtCelular.Text.Replace(@"(", "").Replace(@")", "").Replace(@"-", "");
            profe.Telefono = txtTelefono.Text.Replace(@"(", "").Replace(@")", "").Replace(@"-", "");
            profe.Direccion = txtDireccion.Text;
            profe.Comentario = txtComentario.Text;

            if (pictureBoxFoto.Image != null)
            {

                profe.Foto = pictureBoxFoto.Image.ToString();
            }

            if (txtSexo.SelectedIndex > 0)
            {
                if (txtSexo.SelectedIndex == 1)
                {
                    profe.Sexo = 'M';
                }
                if (txtSexo.SelectedIndex == 2)
                {
                    profe.Sexo = 'F';
                }

            }
            else
            {
                errorProviderProfesor.SetError(txtSexo, "Debe seleccionar un genero");
                txtSexo.Focus();
                return;
            }
            #endregion

            try
            {
                if (txtNombres.Text == "")
                {
                    errorProviderProfesor.SetError(txtNombres, "Ingrese un nombre");
                    txtNombres.Focus();
                    return;
                }
                errorProviderProfesor.SetError(txtNombres, "");

                if (txtApellidos.Text == "")
                {
                    errorProviderProfesor.SetError(txtApellidos, "Ingrese un nombre");
                    txtNombres.Focus();
                    return;
                }
                errorProviderProfesor.SetError(txtApellidos, "");

                MemoryStream ms = new MemoryStream();

                pictureBoxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                #region Creando los parametros que se enviaran al helper
                SqlParameter[] parameters = {
                    new SqlParameter("@Cedula", profe.Cedula),
                    new SqlParameter("@Nombres", profe.Nombres),
                    new SqlParameter("@Apellidos", profe.Apellidos),
                    new SqlParameter("@Sexo", profe.Sexo),
                    new SqlParameter("@Telefono", profe.Telefono),
                    new SqlParameter("@Celular", profe.Celular),
                    new SqlParameter("@FechaIngreso", dtpFechaIngreso.Value),
                    new SqlParameter("@FechaNacimiento", dtpFechaNacimiento.Value),
                    new SqlParameter("@Direccion", profe.Direccion),
                    new SqlParameter("@Comentario", profe.Comentario),
                    new SqlParameter("@Foto", ms.GetBuffer()),
                };
                #endregion

                helper.executeNonQuery("INSERT INTO Profesores (Cedula, Nombres, Apellidos, Sexo, Telefono, Celular, FechaNacimiento, FechaIngreso, Direccion, Comentario, Foto ) " +
                                          "VALUES (@Cedula, @Nombres, @Apellidos, @Sexo, @Telefono, @Celular, CONVERT(DATETIME,@FechaNacimiento, 103), CONVERT(DATETIME,@FechaIngreso, 103), @Direccion, @Comentario, @Foto )", CommandType.Text, parameters);


                cargarDataGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error creando el Profesor" + ex);
            }

            limpiarDatos();
        }

        private void BuscarProfesor()
        {
            limpiarDatos();
            var dataFoto = dgvProfesores.CurrentRow.Cells[11].Value.ToString();
            if (dataFoto != "")
            {
                byte[] foto = new byte[0];
                foto = (byte[])dgvProfesores.CurrentRow.Cells["Foto"].Value;
                MemoryStream ms = new MemoryStream(foto);
                pictureBoxFoto.Image = Bitmap.FromStream(ms);

            }


            txtID.Text = dgvProfesores.CurrentRow.Cells["IdProfesor"].Value.ToString();
            txtCedula.Text = dgvProfesores.CurrentRow.Cells["Cedula"].Value.ToString();
            txtNombres.Text = dgvProfesores.CurrentRow.Cells["Nombres"].Value.ToString();
            txtApellidos.Text = dgvProfesores.CurrentRow.Cells["Apellidos"].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvProfesores.CurrentRow.Cells[4].Value);
            dtpFechaIngreso.Value = Convert.ToDateTime(dgvProfesores.CurrentRow.Cells[5].Value);
            if (dgvProfesores.CurrentRow.Cells["Sexo"].Value.ToString() == "M")

            {
                txtSexo.SelectedIndex = 1;
            }
            else if (dgvProfesores.CurrentRow.Cells["Sexo"].Value.ToString() == "F")
            {
                txtSexo.SelectedIndex = 2;

            }

            txtTelefono.Text = dgvProfesores.CurrentRow.Cells["Telefono"].Value.ToString();
            txtCelular.Text = dgvProfesores.CurrentRow.Cells["Celular"].Value.ToString();
            txtDireccion.Text = dgvProfesores.CurrentRow.Cells["Direccion"].Value.ToString();
            txtComentario.Text = dgvProfesores.CurrentRow.Cells["Comentario"].Value.ToString();
            activarBotones();

            tabControl1.SelectedIndex = 0;
            txtNombres.Focus();
        }

        private void ModificarProfesor()
        {
            try
            {
                //byte[] foto = new byte[0];
                //foto = (byte[])dgvEstudiantes.CurrentRow.Cells["Foto"].Value;

                MemoryStream ms = new MemoryStream();
                pictureBoxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //Creo los parametros a enviar en el helper
                SqlParameter[] parameters = {
                new SqlParameter("@Id",txtID.Text),
                new SqlParameter("@Cedula", txtCedula.Text.Replace(@"-", "")),
                new SqlParameter("@Nombres", txtNombres.Text),
                new SqlParameter("@Apellidos", txtApellidos.Text),
                new SqlParameter("@Sexo", txtSexo.Text.Substring(0,1)),
                new SqlParameter("@Telefono", txtTelefono.Text.Replace(@"(", "").Replace(@")", "").Replace(@"-", "")),
                new SqlParameter("@Celular", txtCelular.Text.Replace(@"(", "").Replace(@")", "").Replace(@"-", "")),
                new SqlParameter("@FechaIngreso", dtpFechaIngreso.Value),
                new SqlParameter("@FechaNacimiento", dtpFechaNacimiento.Value),
                new SqlParameter("@Direccion",txtDireccion.Text),
                new SqlParameter("@Comentario", txtComentario.Text),
                new SqlParameter("@Foto", ms.GetBuffer()),
            };
                var resultado = helper.executeNonQuery("UPDATE Profesores SET Nombres = @Nombres, Apellidos = @Apellidos, Sexo =@Sexo," +
                                          "Telefono =@Telefono, Celular=@Celular, FechaNacimiento = @FechaNacimiento, " +
                                          "Direccion = @Direccion, Comentario = @Comentario, Foto = @Foto WHERE IdProfesor =@Id", CommandType.Text, parameters);
                cargarDataGrid();
                limpiarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error accediendo al Profesor " + ex);
            }
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
            pictureBoxFoto.Image = null;
            dtpFechaNacimiento.Text = "";
            txtNombres.Focus();
        }

        private void cargarDataGrid()
        {
       
            dgvProfesores.DataSource = null;
            var dataSource = helper.executeQuery("Select * from Profesores", CommandType.Text, null);

            dgvProfesores.DataSource = dataSource.Tables[0];


            #region Codigo anterior para llenar el grid antes de crear el helper para estos fines
            /*   SqlConnection cn = new SqlConnection(strcon);
               cn.Open();
               SqlCommand cmd = new SqlCommand("Select * from Profesores", cn);
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               DataSet ds = new DataSet();
               da.Fill(ds);
               dgvProfesores.DataSource = ds.Tables[0];
               cn.Close(); */
            #endregion

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
