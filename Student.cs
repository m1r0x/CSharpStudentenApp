using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudentenApp
{
    class Student : Person
    {

        public List<Testresultat> Resultate { get; set; }

        public Student(string vorname, string nachname) : base(vorname,nachname)
        {
            this.Resultate = new List<Testresultat>();
        }

        public double GetNotendurchschnitt()
        {
            double RatingAverage = Resultate.Average(r => r.Note);
            return RatingAverage;
        }
    }
}
