using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudentenApp
{
    class Student
    {
        public List<Testresultat> Noten
        {
            get; set;
        }

        public GetNotendurchschnitt(List<Testresultat> resultate)
        {
            double durchschnitt = resultate.Average(innerList => innerList[0]);

            return;
        }
    }
}
