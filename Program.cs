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

            Student michael = new Student("Michael", "Stratighiou");
            michael.Noten.Add(new Testresultat(5.0));
            michael.Noten.Add(new Testresultat(3.3));
            michael.Noten.Add(new Testresultat(1.5));

            Console.WriteLine(michael.GetNotendurchschnitt().ToString());

        }
    }
}
