using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudentenApp
{
    class Student : Person
    {

        public List<Testresultat> Noten
        {
            get; set;
        }

        double durchschnitt;

        public Student(string _vorname, string _name)
        {
            this.Vorname = _vorname;
            this.Name = _name;
        }

        public double GetNotendurchschnitt(List<Testresultat> resultate)
        {
            durchschnitt = Noten.Average();
            Console.WriteLine(durchschnitt.ToString);
        }
    }
}
