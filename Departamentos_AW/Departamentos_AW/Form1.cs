using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Departamentos_AW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarDepartamentos vista = new ListarDepartamentos();
            vista.Show();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearDepartamentos vista = new CrearDepartamentos();
            vista.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar vista = new Actualizar();
            vista.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar vista = new Eliminar();
            vista.Show();
        }
    }
}
