using System.Net;
using System.Net.Mail;

namespace QueueProcessor.SendMail
{
    public class SendingMail
    {
        public static void SendMail(string email)
        {
            var sendemail = "apiVeiculos@outlook.com";
            var pass = "3ux56bFx";

            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
            client.Port = 587; // or 25
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            NetworkCredential credentials = new NetworkCredential(sendemail, pass);
            client.EnableSsl = true;
            client.Credentials = credentials;
            try
            {                
                var mail = new MailMessage(sendemail, email);
                mail.Subject = "Veiculo Cadastrado com sucesso";
                mail.Body = "<b>Veiculo Cadastrado com sucesso";
                mail.IsBodyHtml = true;
                client.Send(mail);
                Console.WriteLine("Email Enviado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
