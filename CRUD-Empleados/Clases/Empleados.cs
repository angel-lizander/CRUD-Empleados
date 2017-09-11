using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Empleados.Clases
{
    class Empleados
    {
        SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }

        public Empleados()
        {

        }

        public Empleados(string nombre, string apellido, string cedula, string direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Direccion = direccion;
        }

       public bool registrar()
        {
            string query = "INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, CEDULA, DIRECCION)";
            query += " VALUES (@NOMBRE, @APELLIDO, @CEDULA, @DIRECCION)";

            try
            {
                cn.Open();
                SqlCommand myCommand = new SqlCommand(query, cn);
                myCommand.Parameters.AddWithValue("@NOMBRE", Nombre);
                myCommand.Parameters.AddWithValue("@APELLIDO", Apellido);
                myCommand.Parameters.AddWithValue("@DIRECCION", Direccion);
                myCommand.Parameters.AddWithValue("@CEDULA", Cedula);
                myCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Datos insertados correctamente");
            }

            catch (SqlException p)
            {

                MessageBox.Show(p.Message);
            }
            return true;
        }

    }



   
        }
    

