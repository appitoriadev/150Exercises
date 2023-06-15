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

        [Fact]
        public void _1HelloName()
        {
            string name = "Laura";
            var expectedMessage = "Hello Laura!!";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.HelloName1(name);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(expectedMessage, actualMessage);
            }
        }

        [Fact]
        public void _2SumNumbers()
        {
            double a = rnd.Next();
            double b = rnd.Next();
            string expectedMessage = $"The sum of {a} + {b} is: {a + b}.";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.SumNumbers2(a, b);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(expectedMessage, actualMessage);
            }
        }

        [Fact]
        public void _3DivideTwoNumbers_IfNotZero()
        {
            double a = rnd.Next();
            double b = rnd.Next() + 1;
            var expectedMessage = $"Dividing {a} over {b} result is: {a / b}.";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                _60.DivideTwoNumbers3(a, b);
                string actualMessage = sw.ToString().Trim();
                Assert.Equal(expectedMessage, actualMessage);
            }

        }

        [Fact]
        public void _3DivideTwoNumbers_IfZero()
        {
            double a = rnd.Next();
            double b = 0;
            var expectedMessage = "Can't divide by 0.";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                _60.DivideTwoNumbers3(a, b);
                string actualMessage = sw.ToString().Trim();
                Assert.Equal(expectedMessage, actualMessage);
            }

        }

        [Fact]
        public void _4PrintResultOperation4_ShouldPrintCorrectResult_Addition()
        {
            // Arrange

            string operation = "+";
            double a = rnd.NextDouble() * 10;
            double b = rnd.NextDouble() * 10;
            string expectedMessage = $"The sum of {a} + {b} is: {a + b}.";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.PrintResultOperation4(operation, a, b);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(expectedMessage, actualMessage);
            }
        }

        [Fact]
        public void _4PrintResultOperation4_ShouldPrintCorrectResult_Subtraction()
        {
            // Arrange

            string operation = "-";
            double a = rnd.NextDouble() * 10;
            double b = rnd.NextDouble() * 10;
            string expectedMessage = $"Substracting {a} - {b} is: {a - b}.";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.PrintResultOperation4(operation, a, b);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(expectedMessage, actualMessage);
            }
        }

        [Fact]
        public void _4PrintResultOperation4_ShouldPrintCorrectResult_Multiplication()
        {
            // Arrange

            string operation = "*";
            double a = rnd.NextDouble() * 10;
            double b = rnd.NextDouble() * 10;
            string expectedMessage = $"The result for {a} times {b} is: {a * b}.";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.PrintResultOperation4(operation, a, b);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(expectedMessage, actualMessage);
            }
        }

        [Fact]
        public void _4PrintResultOperation4_ShouldPrintInvalidOperationMessage()
        {
            // Arrange

            string operation = "$"; // Invalid operation
            double a = 1;
            double b = 2;
            string expectedMessage = "Invalid operation";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.PrintResultOperation4(operation, a, b);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(expectedMessage, actualMessage);
            }
        }

        [Fact]
        public void _5SwapNumbers_ShouldSwapNumbers()
        {
            // Arrange
            int a = rnd.Next();
            int b = rnd.Next();
            int expectedA = b;
            int expectedB = a;
            string expectedMessage = $"The numbers were swaped: a = {expectedA} and b = {expectedB}.";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw); // Redirect console output to StringWriter
                _60.SwapNumbers5(a, b);
                string actualMessage = sw.ToString().Trim();

                // Assert
                Assert.Equal(expectedMessage, actualMessage);
            }

        }

        [Fact]
        public void _6MultiplyThreeeNumbers()
        {
            double[] numbers = { 2, 3, 4 };
            double expectedProduct = 24;
            string expectedMessage = "The product of 2 * 3 * 4 is: 24.";

            using (StringWriter sw = new StringWriter())
            {
                // Act
                using (StringReader sr = new StringReader(string.Join(Environment.NewLine, numbers)))
                {
                    Console.SetIn(sr); // Redirect console input from StringReader
                    Console.SetOut(sw); // Redirect console output to StringWriter
                    yourObject.PrintMultiplication();
                    string actualMessage = sw.ToString().Trim();

                    // Assert
                    Assert.Equal(expectedMessage, actualMessage);
                }
            }
        }
    }
}
