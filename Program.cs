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
            Klasse ti5 = new Klasse("TI5");

            Student michael = new Student("Michael", "Stratighiou");

            
            michael.Resultate.Add(new Testresultat(5.0));
            michael.Resultate.Add(new Testresultat(3.3));
            michael.Resultate.Add(new Testresultat(1.5));

            Console.WriteLine(michael.Resultate);

        }
    }
}
