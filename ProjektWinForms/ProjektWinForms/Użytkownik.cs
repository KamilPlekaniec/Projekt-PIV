using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWinForms
{
    public class Użytkownik
    {
        public int ID_użytkownika { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Imię { get; set; }
        public override string ToString()
        {
            var details = string.Format("{0} - {1} z numerem telefonu {2} i imieniem {3}", ID_użytkownika, Email, Telefon, Imię);
            return details;
        }
    }
}
