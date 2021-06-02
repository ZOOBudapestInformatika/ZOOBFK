using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgyeletFigyelo
{
    class BindingSourceClass
    {
        public string userAdmin { get; set; } // sAMAccountName
        public string userName { get; set; } // cn
        public string company { get; set; } // company
        public string department { get; set; } // department -- osztály
        public string registrationNumber { get; set; } // description
        public string title { get; set; } // title -- beosztás
        public string telNumber { get; set; } // telephoneNumber
        public string mail { get; set; } // mail
        // _____________________________speciális tartalmak!!!!!!!!!!______________________________
        public string password { get; set; }
        public string lastLogon { get; set; }
        public string manager { get; set; }
    }
}
