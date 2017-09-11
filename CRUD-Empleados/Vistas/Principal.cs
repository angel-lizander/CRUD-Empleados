using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Empleados.Vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Crear crear = new Crear();
            crear.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listar buscar= new Listar();
            buscar.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
