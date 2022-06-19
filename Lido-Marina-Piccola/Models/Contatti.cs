using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lido_Marina_Piccola.Models
{
    public class Contatti
    {
        public string Nome { get; set; }
        [Email]
        public string Email{ get; set; }
        public string Telefono { get; set; }
        public string Messaggio { get; set; }
    }
}