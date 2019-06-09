using BL.Helpers;
using Entity;
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

namespace Registro
{
    public partial class frmCurso : Form
    {
        SqlDataAccess helper = new SqlDataAccess();
        public frmCurso()
        {
            InitializeComponent();
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            cbProfesor.DataSource = helper.GetCursos();
            cbProfesor.DisplayMember = "Nombres";
            cbProfesor.ValueMember = "IdProfesor";
            cargarDataGrid();
            limpiarDatos();
            activarBotones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void limpiarDatos()
        {
            txtID.Text = "";    
            txtNombre.Text = "";           
            txtComentario.Text = "";    
            txtHorario.Text = "";
            txtNombre.Focus();
        }

        private void cargarDataGrid()
        {
            dgvCursos.DataSource = null;
            var dataSource = helper.executeQuery("Select * from Cursos", CommandType.Text, null);

            dgvCursos.DataSource = dataSource.Tables[0];

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

            var nombre = string.IsNullOrEmpty(txtNombre.Text) ? 
                        btnCrear.Enabled = false : btnCrear.Enabled = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearCurso();
        }

        private void CrearCurso()
        {
            Curso curso = new Curso();
            #region Asignando valores a las propiedades del obj Estudiante
        
            curso.Nombre = txtNombre.Text;
            curso.ProfesorId = Convert.ToInt32(cbProfesor.SelectedValue);
            curso.Horario = txtHorario.Text;
            curso.Comentario = txtComentario.Text;
            #endregion

            try
            {
                if (txtNombre.Text == "")
                {
                    errorProviderCurso.SetError(txtNombre, "Ingrese un nombre");
                    txtNombre.Focus();
                    return;
                }
                errorProviderCurso.SetError(txtNombre, "");         

          
                #region Creando los parametros que se enviaran al helper
                SqlParameter[] parameters = {
                    
                    new SqlParameter("@Id", curso.IdCurso),
                    new SqlParameter("@Profesor", curso.ProfesorId),
                    new SqlParameter("@Nombre", curso.Nombre),
                    new SqlParameter("@Horario", curso.Horario),                 
                    new SqlParameter("@Comentario", curso.Comentario),
               
                };
                #endregion

                helper.executeNonQuery("INSERT INTO Cursos (Nombre, IdProfesor, Horario, Comentario) " +
                                          "VALUES (@Nombre, @Profesor, @Horario, @Comentario )", CommandType.Text, parameters);

                
                cargarDataGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ingresando Estudiantes" + ex);
            }

            limpiarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            activarBotones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Con este codigo guardaba el campo foto como IMAGE en la DB.
                //byte[] foto = new byte[0];
                //foto = (byte[])dgvEstudiantes.CurrentRow.Cells["Foto"].Value;

                //MemoryStream ms = new MemoryStream();
                //pictureBoxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); 
                #endregion
                //Creo los parametros a enviar en el helper
                SqlParameter[] parameters = {
                new SqlParameter("@Id",txtID.Text),               
                new SqlParameter("@IdProfesor", cbProfesor.SelectedValue.ToString()),         
                new SqlParameter("@Nombre", txtNombre.Text),         
                new SqlParameter("@Horario", txtHorario.Text),
                new SqlParameter("@Comentario", txtComentario.Text),
               
            };
                var resultado = helper.executeNonQuery("UPDATE Cursos SET IdProfesor = @IdProfesor, Nombre = @Nombre," +
                                          "Horario =@Horario, Comentario=@Comentario WHERE IdCurso =@Id", CommandType.Text, parameters);
                cargarDataGrid();
                limpiarDatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error accediendo al curso " + ex);
            }
        }

        private void dgvCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BuscarCurso();
        }

        private void BuscarCurso()
        {
            limpiarDatos();   
            txtID.Text = dgvCursos.CurrentRow.Cells["IdCurso"].Value.ToString();
            cbProfesor.SelectedValue = Convert.ToInt32(dgvCursos.CurrentRow.Cells["IdProfesor"].Value);

            txtNombre.Text = dgvCursos.CurrentRow.Cells["Nombre"].Value.ToString();
            txtHorario.Text = dgvCursos.CurrentRow.Cells["Horario"].Value.ToString();           
            txtComentario.Text = dgvCursos.CurrentRow.Cells["Comentario"].Value.ToString();

            activarBotones();
            tabControl1.SelectedIndex = 0;
            txtNombre.Focus();
        }
    }
}
