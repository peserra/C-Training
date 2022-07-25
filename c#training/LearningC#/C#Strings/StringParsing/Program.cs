using System;
using System.Globalization;
// how to parse the content of the string into c# native data types

string numStr1 = "1";
string numStr2 = "2.00";
string numStr3 = "3,000";
string numStr4 = "3,000.00";
int targetNum = 0;

// the parse function might throw an exception, so we have to use it inside a try..catch, so the exception can be handled
try {
    // using parse on a simple integer
    targetNum = int.Parse(numStr1);
    System.Console.WriteLine(targetNum);

    // parsing a float point number into integer, use only if float number has no decimal numbers
    // we have to tell the parser to allow the floating point number format using numberstyles class
    targetNum = int.Parse(numStr2, NumberStyles.Float);
    System.Console.WriteLine(targetNum);

    //using parse to try a number with thousands marker
    targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
    System.Console.WriteLine(targetNum);

    //combining thousands marker and decimal
    targetNum = int.Parse(numStr4, NumberStyles.AllowThousands | NumberStyles.Float);
    System.Console.WriteLine(targetNum);

    // they all are integer numbers, but it works with another data types
    // in boolean
    System.Console.WriteLine($"{bool.Parse("true")}"); //word "true" into bool
    System.Console.WriteLine($"{float.Parse("1.235"):F2}"); // word "1.236" into an float number with 2 decimals

    // using TryParse function to handle exceptions
    bool succeeded = false;
    succeeded = Int32.TryParse(numStr1, out targetNum);
    // we use an out parameter, wich is a parameter on the function call that its acutally the funcion return
    if (succeeded) {
        System.Console.WriteLine($"{targetNum}");
    }

} catch {

}

