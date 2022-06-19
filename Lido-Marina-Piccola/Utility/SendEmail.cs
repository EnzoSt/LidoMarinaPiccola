using AegisImplicitMail;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;


namespace Lido_Marina_Piccola.Utilities
{
    public class SendEmail
    {

        /*public static void SendMail(string HtmlBody,string Oggetto,string destinatari, string messaggio)*/
        public static string SendMail(string Nome, string Telefono, string Email, string Messaggio)
        {
            try
            {
                var SmtpServer = new MimeMailer();
                var mail = new MimeMailMessage();
                string Io = "stellavatoe@gmail.com";
            /*    mail.From = new MailAddress(Email);*/
                mail.From = new MailAddress(ConfigurationManager.AppSettings["User"]);
                mail.To.Add(Io);
                mail.Subject = $"Ciao sono {Nome} ed il mio numero è {Telefono} la mia mail è {Email}";
                mail.Body = Messaggio;
                mail.IsBodyHtml = true;

                SmtpServer.Host = "out.postassl.it";
                SmtpServer.Port = Convert.ToInt16(ConfigurationManager.AppSettings["Port"]);
                SmtpServer.AuthenticationMode = AuthenticationType.Base64;
                SmtpServer.SslType = SslMode.Ssl;
                SmtpServer.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["User"], ConfigurationManager.AppSettings["Password"]);
                SmtpServer.EnableImplicitSsl = true;

                //Controllo se ci sono più destinatari della mail
                /*if (Email.Contains(";"))
                {
                    String[] stringaSplittata = Email.Split(';');
                    for (int i = 0; i < stringaSplittata.Length; i++)
                    {
                        mail.To.Add(stringaSplittata[i]);
                    }
                }
                else
                {
                    mail.To.Add(Email);
                }*/
                
                //invio la mail
                SmtpServer.Send(mail);

                return "OK";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "KO";
            }
            
        }

        
    }
}