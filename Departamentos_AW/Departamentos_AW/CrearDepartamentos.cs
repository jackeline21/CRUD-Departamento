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
    public partial class CrearDepartamentos : Form
    {
        public CrearDepartamentos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server = localhost; Database=AdventureWorks2014; User Id=Jacki; 
                                    Password=12345;");
            string insertar = @"exec sp_insertar_departamentos @name, @descripcion";

            SqlCommand cmd = new SqlCommand(insertar, conn);

            try
            {
                conn.Open();
                using (cmd)
                {
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescrip.Text;

                    cmd.ExecuteNonQuery();

                    label1.Text = "exito";
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
