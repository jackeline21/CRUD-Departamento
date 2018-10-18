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
    public partial class ListarDepartamentos : Form
    {
        public ListarDepartamentos()
        {
            InitializeComponent();
        }

        private void ListarDepartamentos_Load_1(object sender, EventArgs e)
        {
            // Crear conexion 
            string connString = @"Server = localhost; Database=AdventureWorks2014; User Id=Jacki; 
                                    Password=12345;";
            // Integrated Security = true;

            // Query 
            string sql = @"SELECT TOP(1000) [DepartmentID],[Name],[GroupName],[ModifiedDate]
                FROM [AdventureWorks2014].[HumanResources].[Department]";

            // Crear la conexion
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Crear el data Adapter

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = new SqlCommand(sql, conn);

                // crear y popukar el DataSet
                DataSet ds = new DataSet();
                da.Fill(ds, "HumanResources.Department");

                // Obtener los datos de la tabla de referencia
                DataTable dt = ds.Tables["HumanResources.Department"];

                //Crear el DataView
                DataView vista1 = new DataView(dt);

                // Desplegar los contactos del DataView en el DataGrid
                dv.DataSource = vista1;

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepcion");
            }
            finally
            {
                // Cerrar la conexion
                conn.Close();
            }
        }

      
    }
}
