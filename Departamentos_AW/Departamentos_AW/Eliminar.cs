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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server = localhost; Database=AdventureWorks2014; User Id=Jacki; 
                                    Password=12345;");

            String eliminar = "exec sp_eliminar_departamentos @nombre";

            SqlCommand cmd = new SqlCommand(eliminar, conn);

            try
            {
                conn.Open();

                using (cmd)
                {
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtNombre.Text;
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
