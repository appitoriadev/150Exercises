using SolveExercises.Solve60;
using System.Xml.Linq;

namespace TestExercises
{
    public class First60
    {
        public Exercises60 _60;
        public Random rnd;
        public First60()
        {
            _60 = new Exercises60();
            rnd = new Random();
        }

        [Theory]
        [InlineData("Laura", "Hello Laura!!")]
        [InlineData("Pedro", "Hello Pedro!!")]
        public void _1HelloName(string name, string output)
        {
            //1. Write a program to print Hello and your name in a separate line.
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.HelloName1(name);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(output, actualMessage);
            }
        }

        [Theory]
        [InlineData(1, 2, "The sum of 1 + 2 is: 3.")]
        [InlineData(3, 8, "The sum of 3 + 8 is: 11.")]
        [InlineData(-1, 15, "The sum of -1 + 15 is: 14.")]
        public void _2SumNumbers(int a, int b, string output)
        {
            //2. Write a program to print the sum of two numbers.
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.SumNumbers2(a, b);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(output, actualMessage);
            }
        }

        [Theory]
        [InlineData(45, 5, "Dividing 45 over 5 result is: 9.")]
        [InlineData(0, 1, "Dividing 0 over 1 result is: 0.")]
        [InlineData(1, 0, "Can't divide by 0.")]
        public void _3DivideTwoNumbers(int a, int b, string output)
        {
            //3. Write a program to print the result of dividing two numbers.
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                _60.DivideTwoNumbers3(a, b);
                string actualMessage = sw.ToString().Trim();
                Assert.Equal(output, actualMessage);
            }

        }

        [Theory]
        [InlineData("+", 45, 5, "The sum of 45 + 5 is: 50.")]
        [InlineData("-", 45, 5, "Substracting 45 - 5 is: 40.")]
        [InlineData("/", 45, 5, "Dividing 45 over 5 result is: 9.")]
        [InlineData("*", 45, 5, "The result for 45 times 5 is: 225.")]
        public void _4PrintResultOperation(string operation, int a, int b, string output)
        {
            //4. Write a program to print the result of the specified operations.
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.PrintResultOperation4(operation, a, b);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(output, actualMessage);
            }
        }

        [Theory]
        [InlineData(4, 5, "The numbers are: a = 4 and b = 5.\r\nThe numbers were swaped: a = 5 and b = 4.")]
        [InlineData(9, 1, "The numbers are: a = 9 and b = 1.\r\nThe numbers were swaped: a = 1 and b = 9.")]
        [InlineData(7, 2, "The numbers are: a = 7 and b = 2.\r\nThe numbers were swaped: a = 2 and b = 7.")]
        public void _5SwapNumbers(int a, int b, string output)
        {
            //5. Write a program to swap two numbers.
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                _60.SwapNumbers5(a, b);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(output, actualMessage);
            }

        }

        [Theory]
        [InlineData(7, 2, 6, "The result for 7 times 2 times 6 is: 84.")]
        [InlineData(1, 0, 9, "The result for 1 times 0 times 9 is: 0.")]
        [InlineData(3, 5, 8, "The result for 3 times 5 times 8 is: 120.")]
        public void _6MultiplyThreeNumbers(int a, int b, int c, string output)
        {
            //6. Write a program to print the output of multiplication of three numbers which will be entered by the user.
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                _60.PrintMultiplicationThreeNumbers6(a, b, c);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(output, actualMessage);

            }
        }

        [Theory]
        [InlineData(1, 5, "The sum of 1 + 5 is: 6.\r\nSubstracting 1 - 5 is: -4.\r\nThe result for 1 times 5 is: 5.\r\nDividing 1 over 5 result is: 0.2.")]
        [InlineData(4, 8, "The sum of 4 + 8 is: 12.\r\nSubstracting 4 - 8 is: -4.\r\nThe result for 4 times 8 is: 32.\r\nDividing 4 over 8 result is: 0.5.")]
        [InlineData(9, 3, "The sum of 9 + 3 is: 12.\r\nSubstracting 9 - 3 is: 6.\r\nThe result for 9 times 3 is: 27.\r\nDividing 9 over 3 result is: 3.")]
        [InlineData(6, 2, "The sum of 6 + 2 is: 8.\r\nSubstracting 6 - 2 is: 4.\r\nThe result for 6 times 2 is: 12.\r\nDividing 6 over 2 result is: 3.")]
        public void _7PrintResultAll(int a, int b, string output)
        {
            //7. Write a program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.PrintResultAll7(a, b);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(output, actualMessage);
            }
        }

        [Theory]
        [InlineData(2, "Multiplication table for 2.\r\n2 * 1 = 2.\r\n2 * 2 = 4.\r\n2 * 3 = 6.\r\n2 * 4 = 8.\r\n2 * 5 = 10.\r\n2 * 6 = 12.\r\n2 * 7 = 14.\r\n2 * 8 = 16.\r\n2 * 9 = 18.\r\n2 * 10 = 20.")]
        [InlineData(5, "Multiplication table for 5.\r\n5 * 1 = 5.\r\n5 * 2 = 10.\r\n5 * 3 = 15.\r\n5 * 4 = 20.\r\n5 * 5 = 25.\r\n5 * 6 = 30.\r\n5 * 7 = 35.\r\n5 * 8 = 40.\r\n5 * 9 = 45.\r\n5 * 10 = 50.")]
        [InlineData(9, "Multiplication table for 9.\r\n9 * 1 = 9.\r\n9 * 2 = 18.\r\n9 * 3 = 27.\r\n9 * 4 = 36.\r\n9 * 5 = 45.\r\n9 * 6 = 54.\r\n9 * 7 = 63.\r\n9 * 8 = 72.\r\n9 * 9 = 81.\r\n9 * 10 = 90.")]
        public void _8MultiplicationTable(int number, string output)
        {
            //8. Write a program that takes a number as input and print its multiplication table.
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.MultiplicationTable8(number);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(output, actualMessage);
            }
        }

        [Theory]
        [InlineData(new double[] { 1, 3, 5, 7 }, "The average of the numbers is: 4.")]
        [InlineData(new double[] { 2, 4, 6, 8 }, "The average of the numbers is: 5.")]
        [InlineData(new double[] { 5, 7, 9, 1 }, "The average of the numbers is: 5.5.")]
        public void _9AverageFourNumbers(double[] nums, string output)
        {
            //9. Write a program that takes four numbers as input to calculate and print the average.
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                _60.AverageFourNumbers9(nums);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(output, actualMessage);
            }
        }

        [Theory]
        [InlineData(1, 3, 5, "The output of (1 + 3) * 5 is: 20 and 1 * 3 + 3 * 5 is: 18.")]
        [InlineData(2, 4, 6, "The output of (2 + 4) * 6 is: 36 and 2 * 4 + 4 * 6 is: 32.")]
        [InlineData(5, 7, 9, "The output of (5 + 7) * 9 is: 108 and 5 * 7 + 7 * 9 is: 98.")]
        public void _10OperationsXYZ(int x, int y, int z, string output)
        {
            //10. Write a program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                _60.OperantionsXYZ10(x,y,z);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(output, actualMessage);
            }
        }
    }
}
