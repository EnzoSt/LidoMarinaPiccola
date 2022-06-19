using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lido_Marina_Piccola.Models;
using Lido_Marina_Piccola.Utilities;

namespace Lido_Marina_Piccola.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        /*public void InviaMail(Contatti contact)*/
        public ActionResult InviaMail(Contatti contact)
        {
            SendEmail.SendMail(contact.Nome, contact.Telefono, contact.Email, contact.Messaggio);

            ViewBag.Message = "Messaggio inviato correttamente";

            return View("Event");

            /*return RedirectToAction("Event", "Home");*/
            /*RedirectToAction("Eventi");*/
            /* return ViewBag();*/
        }
        /*       public ActionResult Event()
               {
                   ViewBag.Message = "Your application description page.";
                   SendEmail send = new SendEmail();
                   send.SendEmail()

                   return View();
               }
       */
        /*    [HttpPost]
            public ActionResult Event(Lido_Marina_Piccola.Models.Contatti contatto)
            {
                string name = contatto.Nome;
                var telefono = contatto.Telefono;
                string mail = contatto.Email;
                string gmessaggio = contatto.Messaggio;

                return View();
            }*/

        public ActionResult Event()
        {
            /*ViewBag.Message = "Your contact page.";*/

            return View();
        }  
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}