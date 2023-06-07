using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveExercises.Solve60
{
    public class Exercises60
    {
        public Exercises60() { }

        public void HelloName(string _name)
        {
            Console.WriteLine("Hello " + _name + "!!");
        }

        public void SumNumbers(double a, double b)
        {
            var sum = a + b;
            Console.WriteLine($"The sum of {a} + {b} is: " + Convert.ToString(sum) + ".");
        }
    }
}
