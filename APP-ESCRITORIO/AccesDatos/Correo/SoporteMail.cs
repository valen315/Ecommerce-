using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesDatos.Correo
{
    class SoporteMail:ServidorCorreoMaestro
    {
        //CONSTRUCTOR
        public SoporteMail()
        {
            senderMail =  "preuebaenviodemail@gmail.com";
            password = "password1_";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicializarSmtpClient();
        }
    }
}
