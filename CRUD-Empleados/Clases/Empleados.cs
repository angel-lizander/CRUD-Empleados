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
        public int Empleado_ID { get; set; }

        public Empleados(string nombre, string apellido, string cedula, string direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Direccion = direccion;
        }

        public Empleados(string nombre, string apellido, string cedula, string direccion, int empleadoid)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Direccion = direccion;
            this.Empleado_ID = empleadoid;
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

        public bool Actualizar()
        {
          
            string query = ("UPDATE Empleados set NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, CEDULA=@CEDULA, DIRECCION=@DIRECCION WHERE EMPLEADO_ID=@EMPLEADOID");

            try
            {
                cn.Open();
                SqlCommand myCommand = new SqlCommand(query, cn);
                myCommand.Parameters.AddWithValue("@NOMBRE", Nombre);
                myCommand.Parameters.AddWithValue("@APELLIDO", Apellido);
                myCommand.Parameters.AddWithValue("@DIRECCION", Direccion);
                myCommand.Parameters.AddWithValue("@CEDULA", Cedula);
                myCommand.Parameters.AddWithValue("@EMPLEADOID", Empleado_ID);
                myCommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Datos actualizados correctamente");
            }

            catch (SqlException p)
            {

                MessageBox.Show(p.Message);
            }
            return true;
        }

        public bool eliminar()
        {
            try
            {
                string query = ("DELETE FROM EMPLEADOS WHERE EMPLEADO_ID=@EMPLEADOID");
                SqlCommand mycommand = new SqlCommand(query, cn);
                mycommand.Parameters.AddWithValue("@EMPLEADOID", Empleado_ID);
                mycommand.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("El empleado se eliminó correctamente");
                
            }
            catch (SqlException p)
            {

                MessageBox.Show(p.Message);
            }
            return true;
        }

    }



   
        }
    

