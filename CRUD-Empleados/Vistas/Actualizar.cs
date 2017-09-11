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
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {
   
          


        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
             var Empleados = new Clases.Empleados(txtnombre.Text, txtapellido.Text, txtcedula.Text, txtdireccion.Text, Convert.ToInt32(txtidempleado.Text));
            Empleados.Actualizar();
        }
    }
}
