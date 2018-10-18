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

namespace Departamentos_AW
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server = localhost; Database=AdventureWorks2014; User Id=Jacki; 
                                    Password=12345;");

            string actualizar = @"exec sp_actualizar_departamentos @nombre, @descripcion";

            SqlCommand cmd = new SqlCommand(actualizar, conn);

            try
            {
                conn.Open();
                using (cmd)
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtGrupo.Text;

                    cmd.ExecuteNonQuery();

                    lblConf.Text = "exito";
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la exepcion");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
