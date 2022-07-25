// tuple is a lightweighted data structure that allows group multiple values in one place
using System;

namespace MultipleReturns
{
    class Program
    {
        public static void Main(string[] args)
        {
            // tuples are grouped values
            (int a, int b) tup1 = (5, 10);
            var tup2 = ("String", 10.5f);

            // their values are mutable
            tup1.b = 20;
            tup2.Item1 = "Another String";

            // functions can work with tuples
            (int, int) result = PlusTimes(6, 12);
            var another = PlusTimes(6, 12);
            System.Console.WriteLine($"Sum:{result.Item1}, Prod: {result.Item2}");
            System.Console.WriteLine($"Sum:{another.Item1}, Prod: {another.Item2}");
        }
        static (int, int) PlusTimes(int a, int b)
        {
            return (a + b, a * b);
        }
        //the tuple is the 'type' of return, and the return values
    }
}