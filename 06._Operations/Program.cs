using System.ComponentModel;

namespace _06._Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();

            double result = 0.00;
            string numberType = string.Empty;

            string outCome = string.Empty;

            if (operators == "+" || operators == "-" || operators == "*")
            {
                if (N1 >=0 && N1 <=40000 && N2 >= 0 && N2 <= 40000)
                {
                    if (operators == "+")
                    {
                        result = N1 + N2;
                    }
                    if (operators == "-")
                    {
                        result = N1 - N2;
                    }
                    if (operators == "*")
                    {
                        result = N1 * N2;
                    }
                    if (result % 2 != 0)
                    {
                        numberType = "odd";
                    }
                    if (result % 2 == 0)
                    {
                        numberType = "even";
                    }
                }
                
                outCome = $"{N1} {operators} {N2} = {result} - {numberType}";
            }
            if (operators == "/")
            {               
                    if (N2 is 0)
                    {
                        outCome = $"Cannot divide {N1} by zero";
                    }
                    else if (N2 != 0)
                    {
                        result = ( N1*1.00 / N2*1.00); 
                        outCome = $"{N1} / {N2} = {result:f2}";
                    }                     
                 
            }
            if ( operators == "%")
            {   
                    if (N2 is 0)
                    {
                        outCome = $"Cannot divide {N1} by zero";
                    }
                    else if (N2 != 0)
                    {
                        result = N1 % N2;
                        outCome = $"{N1} % {N2} = {result:f0}";
                    }
                
            }
            Console.WriteLine(outCome);
        }
    }
}
//Write a program that reads two integers (N1 and N2) along with an operator to perform a mathematical operation between them.
//The possible operations are:
//  V Addition(+),
//  V Subtraction(-),
//  V Multiplication(*),
//  V Division(/)
//  V Modular Division (%).

//For Addition, Subtraction, and Multiplication, the result and whether it is even or odd should be printed on the console.
//For regular Division, the quotient should be printed.
//For Modular Division, the remainder should be displayed.
//It should be considered that the divisor can be equal to 0 (zero), and division by zero is not possible.
//In this case, a special message should be printed.
//Input
//From the console are read 3 lines entered by the user:

//  V •	N1 – an integer value in the range [0...40 000]
//  V •	N2 – an integer value in the range [0...40 000]

//•	Operator – one symbol among the following: "+", "-", "*", "/", "%"
//Output
//Print one line on the console:
//•	If the operation is division:
//   V   "{N1} / {N2} = {result}" - result formatted to second decimal place
//•	If the operation is modular division: 
//    V    "{N1} % {N2} = {remainder}"
//•	In the case of division by 0 (zero): 
//       "Cannot divide {N1} by zero"
