using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace AccesDatos.Correo
{
    public abstract class ServidorCorreoMaestro
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }//correo del remitente
        protected string password { get; set; }
        protected string host { get; set;  }
        protected int port { get; set;  }
        protected bool ssl { get; set; }

        protected void inicializarSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;

        }
        //Metodo ENVIAR CORREO
        public void sendMail(string subject,string body,List<string> recipientMail)//PARAMETROS:Asunto,Cuerpo,lista o coleccion  de correos electronicos
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch(Exception ex)
            {

            }
            finally//desechar los objetos creados para liberar recursos
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
       
    }
}
