using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudentenApp
{
    class Klasse
    {
        public String Klassenbezeichnung { get; set; }

        public List<Student> Studenten { get; set; }

        public Klasse(string _bezeichnung)
        {
            this.Studenten = new List<Student>();
            this.Klassenbezeichnung = _bezeichnung;
        }
    }

    
}
