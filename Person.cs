using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudentenApp
{
    abstract class Person
    {
        public string Nachname { get; set; }
        public string Vorname { get; set; }

        public Person(string vorname, string nachname)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
        }
    }
}
