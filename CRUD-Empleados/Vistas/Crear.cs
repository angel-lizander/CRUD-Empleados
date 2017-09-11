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
        //Conexion a base de datos
        SqlConnection cn = new SqlConnection(
        ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);


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


           /* string query = "INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, CEDULA, DIRECCION)";
            query += " VALUES (@NOMBRE, @APELLIDO, @CEDULA, @DIRECCION)";

            try
            {
                cn.Open();
                SqlCommand myCommand = new SqlCommand(query, cn);
                myCommand.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
                myCommand.Parameters.AddWithValue("@APELLIDO", txtapellido.Text);
                myCommand.Parameters.AddWithValue("@DIRECCION", txtdireccion.Text);
                myCommand.Parameters.AddWithValue("@CEDULA", txtcedula.Text);
                myCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Datos insertados correctamente");
            }

            catch (SqlException p)
            {
  
                MessageBox.Show(p.Message);
            }*/
                
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
