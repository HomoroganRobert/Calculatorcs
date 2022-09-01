using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Char op;
            Double num1, num2;
            
            Console.WriteLine("Enter the operator (+, -, *, /)");
            op = Console.ReadLine()[0];

            Console.WriteLine("Enter 2 numbers one by one");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            switch( op)
            {
                case'+':
                    Console.WriteLine("{0} + {1} = {2}", num1,num2,(num1+num2));
                    break;

                case'-':
                    Console.WriteLine("{0} - {1} = {2}", num1,num2,(num1-num2));
                    break;

                case'*':
                    Console.WriteLine("{0} * {1} = {2}", num1,num2,(num1*num2));
                    break;

                case'/':
                    if (num2 == 0.0)
                        Console.WriteLine("Diveded by 0 situation");
                    else
                        Console.WriteLine("{0} / {1} = {2}", num1,num2,(num1/num2));
                    break;

                default:
                    Console.WriteLine("{0} is an invalid operator",op);
                    break;

            }

            Console.WriteLine("Press any key to exit de program");
            Console.ReadKey();
        }
    }
}