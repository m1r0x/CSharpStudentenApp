using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudentenApp
{
    class Schule
    {
        public string Standort { get; set; }
        public List<Klasse> Klassen { get; set; }
    }

    public Schule()
    {
        this.Klassen = new List<Klasse>();
    }
}
