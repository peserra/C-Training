using System;

// functions cant change the value of an argument outside the function.
// the parameter is changed temporarily inside the function
namespace RefAndOutParams
{
    class Program
    {
        static void TestFunc1(int arg1)
        {
            arg1 += 10;
            System.Console.WriteLine(arg1);
        }

        //the ref keyword means that the argument is passed by refference, not by copying the value
        static void TestFunc2(ref int arg1)
        {
            arg1 += 10;
            System.Console.WriteLine(arg1);
        }
        // out keyword means those are the returns
        public static void PlusTimes(int arg1, int arg2, out int sum, out int product)
        {
            sum = arg1 + arg2;
            product = arg2 * arg1;
        }

        public static void Main(string[] args)
        {
            int val1 = 10;
            int val2 = 20;
            // normaly the value of val1 is not modified
            TestFunc1(val1);
            System.Console.WriteLine(val1);

            // but passing parameters by reference allows the function to modify the value of the argument outside the context of the function
            //the ref keyword means that the argument is passed by refference, not by copying the value
            TestFunc2(ref val1);
            System.Console.WriteLine(val1);

            // use the 'out' keyword to specify that the parameter is used to return a value instad of provide a value to the function
            int sum;
            int product;
            PlusTimes(val1, val2, out sum, out product);
            System.Console.WriteLine($"SUM: {sum}, PROD: {product}");
            // the main use of out parameter is to enable a function to return multiple values, but its not recomended.
        }
    }
}