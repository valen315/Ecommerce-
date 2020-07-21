using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesDatos
{
    public abstract class ConexionBD
    {
        private readonly string cadenaconexion;
        // constructor 
        public ConexionBD()
        {
            cadenaconexion = "Data Source=DESKTOP-HU5GM1D\\SQLEXPRESS;Initial Catalog=Ecommerce;Integrated Security=True;Connect Timeout=30";
        }
        protected SqlConnection GetSqlConnection()
        {
            //parametro:cadena de conexion
            return new SqlConnection(cadenaconexion);
        }
    }
}
