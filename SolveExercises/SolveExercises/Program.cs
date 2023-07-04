// See https://aka.ms/new-console-template for more information
using SolveExercises.Solve60;
var sixty = new Exercises60();
Console.WriteLine("Initial.");

sixty.HelloName1("Tu Nombre");
sixty.SumNumbers2(5, 62);
sixty.DivideTwoNumbers3(5, 62);
sixty.PrintResultOperation4("+", 5, 62);
sixty.PrintResultOperation4("-", 5, 62);
sixty.PrintResultOperation4("*", 5, 62);
sixty.PrintResultOperation4("+", 5, 62);
sixty.PrintResultOperation4("%", 5, 62);
sixty.SwapNumbers5(8, 15);
sixty.PrintMultiplicationThreeNumbers6(2, 5, 9);
sixty.PrintResultAll7(74, 63);
sixty.MultiplicationTable8(43);
sixty.AverageFourNumbers9(new double[4] {2,5,8,11});
sixty.OperantionsXYZ10(7, 5, 3);

/*
Hello Tu Nombre!!
The sum of 5 + 62 is: 67.
Dividing 5 over 62 result is: 0.08064516129032258.
The sum of 5 + 62 is: 67.
Substracting 5 - 62 is: -57.
The result for 5 times 62 is: 310.
The sum of 5 + 62 is: 67.
Invalid operation
The numbers are: a = 8 and b = 15.
The numbers were swaped: a = 15 and b = 8.
The result for 2 times 5 times 9 is: 90.
The sum of 74 + 63 is: 137.
Substracting 74 - 63 is: 11.
The result for 74 times 63 is: 4662.
Dividing 74 over 63 result is: 1.1746031746031746.
Multiplication table for 43.
43 * 1 = 43.
43 * 2 = 86.
43 * 3 = 129.
43 * 4 = 172.
43 * 5 = 215.
43 * 6 = 258.
43 * 7 = 301.
43 * 8 = 344.
43 * 9 = 387.
43 * 10 = 430.
The average of the numbers is: 6.5.
The output of (7 + 5) * 3 is: 36 and 7 * 5 + 5 * 3 is: 50.
 */


Console.ReadKey();