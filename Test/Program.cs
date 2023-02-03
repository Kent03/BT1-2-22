using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            number1=double.Parse(Console.ReadLine());
            number2 = double.Parse(Console.ReadLine());

            double result = number1 + number2;
            Console.WriteLine("(0)+(1)+(2)", number1, number2, result);
            Console.ReadLine();     
        }
    }
}
