using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudentenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Schule ibz = new Schule();
            ibz.Standort = "Aarau";

            Student s = new Student();
            s.Noten.Add(new Testresultat(5.0));
            s.Noten.Add(new Testresultat(3.3));



        }
    }
}
