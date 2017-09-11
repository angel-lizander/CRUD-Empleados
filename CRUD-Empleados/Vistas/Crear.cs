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
using System.Configuration;

namespace CRUD_Empleados
{
    public partial class Crear : Form
    {

        public Crear()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            var Empleados = new Clases.Empleados(txtnombre.Text, txtapellido.Text, txtcedula.Text, txtdireccion.Text);
            Empleados.registrar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
