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

        public void HelloName1(string _name)
        {
            Console.WriteLine("Hello " + _name + "!!");
        }

        public void SumNumbers2(double a, double b)
        {
            var sum = a + b;
            Console.WriteLine($"The sum of {a} + {b} is: {sum}.");
        }

        public void DivideTwoNumbers3(double a, double b)
        {
            var isZero = b == 0;
            if (isZero)
            {
                Console.WriteLine("Can't divide by 0.");
            }
            else
            {
                Console.WriteLine($"Dividing {a} over {b} result is: {a / b}.");
            }

        }

        public void PrintResultOperation4(string operation, double a, double b)
        {
            switch (operation)
            {
                case "+":
                    SumNumbers2(a, b);
                    break;
                case "-":
                    Console.WriteLine($"Substracting {a} - {b} is: {a - b}.");
                    break;
                case "*":
                    Console.WriteLine($"The result for {a} times {b} is: {a * b}.");
                    break;
                case "/":
                    DivideTwoNumbers3(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }
        }

        public void SwapNumbers5(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"The numbers were swaped: a = {a} and b = {b}.");
        }
    }
}
