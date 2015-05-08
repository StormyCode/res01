using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Controller_Patienten
    {
        public List<Model_Patient> Patienten { get; set; }

        public Controller_Patienten()
        {
            this.Patienten = new List<Model_Patient>();
        }

        public void PatientHinzufuegen(string _v, string _n, string _g)
        {
            this.Patienten.Add(new Model_Patient(_v, _n, _g));
        }
    }
}
