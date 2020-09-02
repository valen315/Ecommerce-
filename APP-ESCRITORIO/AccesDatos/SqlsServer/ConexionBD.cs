using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace AccesDatos
{
    public abstract class ConexionBD
    {
       static private string cadenaconexion=ConfigurationManager.ConnectionStrings["conectarBD"].ConnectionString;

    
        protected SqlConnection GetSqlConnection()
        {
            //parametro:cadena de conexion
            return new SqlConnection(cadenaconexion);
        }
        
    
    }
}
