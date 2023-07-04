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
            Console.WriteLine($"The numbers are: a = {a} and b = {b}.");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"The numbers were swaped: a = {a} and b = {b}.");
        }

        public void PrintMultiplicationThreeNumbers6(int a, int b, int c)
        {
            Console.WriteLine($"The result for {a} times {b} times {c} is: {a * b * c}.");
        }

        public void PrintResultAll7(double a, double b)
        {
            string text = string.Empty;
            text = $"The sum of {a} + {b} is: {a + b}.\r\nSubstracting {a} - {b} is: {a - b}.\r\nThe result for {a} times {b} is: {a * b}.";
            Console.WriteLine(text);
            DivideTwoNumbers3(a, b);
        }

        public void MultiplicationTable8(int number)
        {
            Console.WriteLine($"Multiplication table for {number}.");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}.");
            }
        }

        public void AverageFourNumbers9(double[] numbers)
        {
            double avg;
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            avg = sum / numbers.Length;

            Console.WriteLine($"The average of the numbers is: {avg}.");
        }

        public void OperantionsXYZ10(int x, int y, int z)
        {
            var first = (x + y) * z;
            var second = (x * y) + (y * z);
            Console.WriteLine($"The output of ({x} + {y}) * {z} is: {first} and {x} * {y} + {y} * {z} is: {second}.");
        }
    }
}
