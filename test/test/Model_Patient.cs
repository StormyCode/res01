using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Model_Patient
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Geburtstag { get; set; }

        public Model_Patient(string _vorname, string _nachname, string _geb)
        {
            this.Vorname = _vorname;
            this.Nachname = _nachname;
            this.Geburtstag = _geb;
        }
    }
}
