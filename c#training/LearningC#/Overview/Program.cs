using System;

namespace HelloWorld {
    class Program {
        public static void Main (string[] args) {
            Console.WriteLine("Hello, World!"); //comand to write Hello, World! on the console
            // line coments are done with double '/
            Console.WriteLine("what is your name?");
            string str = Console.ReadLine();
            Console.WriteLine($"Hello {str}");

            // Variables and Data types
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            //implicit:
            var x = 10;
            var z = "Hello!";

            //Arrays
            int[] vals = new int[5];
            string[] strs = {"one", "two", "three"};
            
            //print with format strings
            Console.WriteLine("{0} {1} {2} {3}", i, c, b, strs[1]);

            //null means 'no value'
            object obj = null;
            Console.WriteLine(obj); //will print nothing

            //Implicit conversion between types
            long bigNum;
            bigNum = i; //now bigNum has a value in long type of i
            //we can convert because long and int are integer types of values

            //Explicit conversion
            float integerToFloat = (float)i;
            int floatToInteger = (int)f;

            Console.WriteLine($"{integerToFloat} {floatToInteger}");

            // Operators
            /*  Basic math: + , - , * , /, % '+ in strings is concatenation'
                Increment/decrement: ++, --, +=, -=
                Logical: &&, ||, !
                Comparison: >, <, >=, <=, ==, !=
                null-coalescing: ??, ??=
                    this if not null??this if it is
                    if this null??= assign this
            */

            //Types of comments
            // single line coments - simple comments
            /*  multiline
                comments
            */
            ///This is a XML documentation, this generates a documentation
            /// allow tags such as:
            /// <summary> text </summary>, <param name = ''> for parameters
            /// <returns> </returns>, etc site: .../csharp/codedoc
            /*to specify to the compiler that we want a documentation, we go to the .csproj
                item and write the tags <GenerateDocumentationFile>true</Generate...>
                and <DocumentationFile>Comments.xml</Documentation...> for the output
                command dotnet build to build with documentation
            */
        }
    }
}



