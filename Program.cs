using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Give me a number:");
            int number1 = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("Give me another number:");
            int number2 = Convert.ToInt32 (Console.ReadLine ());
            var sum = number1 + number2;
            var divn = number1 / number2;
            var mult = number1 * number2;
            var subt = number1 - number2;
            Console.WriteLine ("sum is = {0}; divn is = {1}; mult is = {2}; subt is = {3}", sum,divn,mult,subt);
        }
    }
}
