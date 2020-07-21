using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaComun.Cache;
using AccesDatos.Correo;

namespace AccesDatos
{
    //hereda de la clase ConexionBD
   public class UserDatos:ConexionBD
    {
        public void EditarPefil(int id,string nombre ,string apellido , string email,string user,string pass,int telefono)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update DatosUsuario set  " + 
                        "Nombre=@nombre,Apellido=@apellido,Email=@email,Usuario=@user,Pass=@pass,Telefono=@telefono where id=@id" ;

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido",apellido);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }
        public bool Login(string user ,string pass)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from DatosUsuario where Usuario=@user and Pass=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheInicioSesionUser.Id = reader.GetInt32(0);
                            CacheInicioSesionUser.Nombre = reader.GetString(1);
                            CacheInicioSesionUser.Apellido = reader.GetString(2);
                            CacheInicioSesionUser.Email = reader.GetString(3);
                            CacheInicioSesionUser.Usuario = reader.GetString(4);
                            CacheInicioSesionUser.Pass = reader.GetString(5);
                            CacheInicioSesionUser.Perfil = reader.GetInt32(6);
                            CacheInicioSesionUser.Telefono = reader.GetInt32(7);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public string RecuperarContraseña(string useRequesting) 
        {
            using (var connection= GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from DatosUsuario where Usuario=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", useRequesting);
                    command.Parameters.AddWithValue("@mail",useRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string Nombre = reader.GetString(1).Trim()+" "+reader.GetString(2).Trim();
                        string userMail = reader.GetString(3);
                        string accountPassword = reader.GetString(5);
                        
                        var mailServer = new SoporteMail();
                        mailServer.sendMail(
                            subject: "Recuperaro de contraseña",
                            body: "Hola, "+Nombre+"\nha solicitado recuperar su contraseña, para mayor seguridad recuerde cambiarlo una vez iniciada la sesion.\n"+"\nContraseña: "
                            + accountPassword, recipientMail: new List<string> { userMail }
                            );

                        return "Hola," + Nombre + "\nRevise su casilla de mensajes, para mayor seguridad recuerde cambiar la contraseña\n";
                            
                    }
                    else return "Usuario/correo incorrecto ";
                }
            }
        }
        public void Perfil()
        {
            
            if (CacheInicioSesionUser.Perfil ==Convert.ToInt32(CachePerfil.Administrador))
            {
                //codigo
            }
            else if(CacheInicioSesionUser.Perfil==Convert.ToInt32(CachePerfil.Usuario))
            {
                //codigo
            }
        }
    }
}
