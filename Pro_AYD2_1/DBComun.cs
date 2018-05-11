using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Pro_AYD2_1
{
    public class DBComun
    {

        public SqlConnection conexion;

        public DBComun()
        {

            conexion = new SqlConnection("Data Source=DESKTOP-9NOAC3K;Initial Catalog=Prueba;Integrated Security=True");

        }
        public SqlConnection getconexion
        {

            get
            {
                return conexion;
            }

        }
        public void insertardatos(String cadena)
        {


            SqlCommand comando = new SqlCommand(cadena, conexion);
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }
    }
}