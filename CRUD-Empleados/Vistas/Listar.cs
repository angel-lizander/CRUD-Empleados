using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Empleados
{
    public partial class Listar : Form
    {
        SqlConnection cn = new SqlConnection(
      ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            var tabla = new DataTable();
            da = new SqlDataAdapter("SELECT * FROM EMPLEADOS", cn);
            da.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
