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
    public partial class frmUniversidad : Form
    {
        SqlDataAccess helper = new SqlDataAccess();
        public frmUniversidad()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearUniversidad();
        }

        private void CrearUniversidad()
        {
            try
            {
                Universidad univ = new Universidad
                {
                    Siglas = this.txtSiglas.Text,
                    Nombre = this.txtNombre.Text,
                    Telefono = this.txtTelefono.Text.Replace(@"(", "").Replace(@")", "").Replace(@"-", ""),
                    Direccion = this.txtDireccion.Text,
                    Comentario = this.txtComentario.Text
                };

                SqlParameter[] parameters = {
                    new SqlParameter("@Siglas", univ.Siglas),
                    new SqlParameter("@Nombre", univ.Nombre),
                    new SqlParameter("@Telefono", univ.Telefono),
                    new SqlParameter("@Direccion", univ.Direccion),
                    new SqlParameter("@Comentario", univ.Comentario),
                };
                helper.executeNonQuery("INSERT INTO Universidades (Siglas, Nombre, Telefono, Direccion, Comentario)" +
                                        "VALUES(@Siglas, @Nombre, @Telefono, @Direccion, @Comentario)", CommandType.Text, parameters);
                cargarDataGrid();
                limpiarDatos();
                activarBotones();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error crando Universidad" + ex);
            }
        }

        private void limpiarDatos()
        {
            txtID.Text = "";
            txtSiglas.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtComentario.Text = "";

            txtSiglas.Focus();
        }

        private void cargarDataGrid()
        {
            dgvUniversidades.DataSource = null;
            var dataSource = helper.executeQuery("Select * from Universidades", CommandType.Text, null);

            dgvUniversidades.DataSource = dataSource.Tables[0];

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

            var nombre = string.IsNullOrEmpty(txtSiglas.Text) ? btnCrear.Enabled = false : btnCrear.Enabled = true;




        }

        private void frmUniversidad_Load(object sender, EventArgs e)
        {
            cargarDataGrid();
            limpiarDatos();
            activarBotones();
        }

        private void txtSiglas_TextChanged(object sender, EventArgs e)
        {
            activarBotones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
            activarBotones();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUniversidad();
        }

        private void ModificarUniversidad()
        {
            try
            {

                SqlParameter[] Parameters = {
                 new SqlParameter("@ID", txtID.Text),
                 new SqlParameter("@Siglas", txtSiglas.Text),
                 new SqlParameter("@Nombre", txtNombre.Text),
                 new SqlParameter("@Telefono", txtTelefono.Text.Replace(@"(", "").Replace(@")", "").Replace(@"-", "")),
                 new SqlParameter("@Direccion",txtDireccion.Text),
                 new SqlParameter("@Comentario", txtComentario.Text),
            };

                helper.executeNonQuery("UPDATE Universidades SET Siglas = @Siglas, Nombre = @Nombre, Telefono = @Telefono," +
                                        "Direccion = @Direccion, Comentario = @Comentario WHERE IdUniversidad = @ID", CommandType.Text, Parameters);

                cargarDataGrid();
                limpiarDatos();
                activarBotones();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error antes de Modificar la Universidad" + ex);
            }
        }

        private void dgvUniversidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BuscarUniversidad();
        }

        private void BuscarUniversidad()
        {
            limpiarDatos();          
            
            txtID.Text = dgvUniversidades.CurrentRow.Cells["IdUniversidad"].Value.ToString();
            txtSiglas.Text = dgvUniversidades.CurrentRow.Cells["Siglas"].Value.ToString();
            txtNombre.Text = dgvUniversidades.CurrentRow.Cells["Nombre"].Value.ToString();       
            txtTelefono.Text = dgvUniversidades.CurrentRow.Cells["Telefono"].Value.ToString();
            txtDireccion.Text = dgvUniversidades.CurrentRow.Cells["Direccion"].Value.ToString();
            txtComentario.Text = dgvUniversidades.CurrentRow.Cells["Comentario"].Value.ToString();
            activarBotones();

            tabControl1.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }
    }
}
