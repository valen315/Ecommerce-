using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesDatos;
using CapaComun.Cache;

namespace Dominio
{
    public class ModeloDominioUser
    {
        UserDatos userDatos = new UserDatos();

        //ATRIBUTOS
        private int id;
        private string Nombre;
        private string Apellido;
        private string Usuario;
        private string Pass;
        private string Email;
        private int Telefono;
        //private string PerfilUsuario;

        public ModeloDominioUser(int id,string usuario,string pass,string nombre,string apellido,string email ,int telefono/*,string perfil*/ )
        {
            this.id = id;
            this.Usuario = usuario;
            this.Pass = pass;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Telefono = telefono;
            //this.PerfilUsuario = perfil;
        }
        public ModeloDominioUser()
        {

        }
        public string EditarPerfilUsuario()
        {
            try
            {
                userDatos.EditarPefil(id,Nombre,Apellido,Email,Usuario,Pass,Telefono);
                LoginUser(Usuario, Pass);
                return "Perfil actualizado correctamente";
            }
           catch(Exception ex)
            {
                return "Nombre de Usuario registrado, intente con otro ";
            }

        }
         public bool LoginUser(string user ,string pass)
        {
            return userDatos.Login(user, pass);
        }
        public string recuperarContraseña(string userRequesting)
        {
            return userDatos.RecuperarContraseña(userRequesting);
        }
      
        public void Perfil()
        {
            //Seguridad y permiso
            if (CacheInicioSesionUser.Perfil == Convert.ToInt32(CachePerfil.Administrador))
            {
                //codigo
            }
            else if (CacheInicioSesionUser.Perfil == Convert.ToInt32(CachePerfil.Usuario))
            {
                //codigo
            }
        }
    }
}
