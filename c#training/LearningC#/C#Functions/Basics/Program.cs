using System;

// can have a return value type, name and optional parameters
float MilesToKm(float miles) {
    return miles * 1.6f;
}

// a function with no return value is 'void' type
void PrintWithPrefix(string str) {
    System.Console.WriteLine($"::> {str}");

}

// call first function
System.Console.WriteLine($"8.0 miles is {MilesToKm(8.0f)} Km");

// call second function
PrintWithPrefix("Thats an useles prefix");

// NAMED AND DEFAULT PARAMETERS
// convenient features
// functions can povide default values for their parameters
void PrintPrefix(string s, string prefix = "") {
    System.Console.WriteLine($"{prefix} {s}");
}

// so we can call it with or without a prefix value
PrintPrefix("Hey there");
PrintPrefix("Hey there", ":>");

// we can call with named parameters
// used to improve readbility, when functions have a lot of parameters
// we call the function using the name of the parameter along with the values to use
PrintPrefix(prefix:"]% ", s:"Hey there"); //the compiler can match the parameters, in any order we want