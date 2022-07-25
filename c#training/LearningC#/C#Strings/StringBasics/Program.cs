// C# Strings
// Declaration of strings
string outstr;
string str1 = "The quick brown fox jumps over the lazy dog";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// length of a string
int sizeString1 = str1.Length;
// access individual characters
char character = str1[14];
// iterate over a string like any other sequence of values
foreach (char c in str1) {
    System.Console.WriteLine(c);
    if (c == 'b') {
        System.Console.WriteLine();
        break;
    }
}
// string cocatenation
outstr = String.Concat(strs); //using the String class

// joining strings together with join
// creates a single strings from multiple strings, we can specify a character to separate each of them
outstr = String.Join('.', strs); // each string will be joined with a . in between them, can be a string between them too

// String comparison
// use directy from String class

/* compare will perform an ordnal comparison and return:
    < 0: first string comes before second in sort order
    0: first and second strings are same position in sort order
    > 0: fist string comes after the second in sort order
*/
int result = String.Compare(str2, "This is a string"); //returns 0
// Equals just returns a regular boolean
bool isEqual = str2.Equals(str3); //returns false
// String searching
int index = str1.IndexOf('e'); //will search the index of char or string, otherwise -1
int lastIndex = str1.LastIndexOf("fox"); // search the last index of char or string

str1.Replace("fox", "cat"); // replaces the content of strings

// STRING FORMATTING
int[] quarters = {1,2,3,4};
int[] sales = {100000,150000,200000,225000};
double[] intlMixPct = {.368, .413, .421, .457};
int val1 = 1234;
decimal val2 = 1234.5678m;

//Basic formatting information
System.Console.WriteLine("{0}", str1);

// specifying numerical formatting
// general format is {index[,alignment]:[format]}
/*  Common types are N(number),  G(general), F(fixed-point), E(exponential),
    D(decimal), P(percent), X(hexadecimal), C(currency in local format)
*/
System.Console.WriteLine("{0:D}, {0:P}, {0:N}, {0:X}", val1);
// add a number after the format to specify precision
System.Console.WriteLine("{0:D6}, {0:P2}, {0:N2}", val2);

// formatting with alignment and spacing
System.Console.WriteLine("{0,12} {1,12} {2,12} {3,12}", quarters[0],     quarters[1], quarters[2],quarters[3]);
// output 1 <12 spaces> 2<12 spaces> 3<12 spaces> 4
System.Console.WriteLine("{0,12:C0} {1,12:C0} {2,12:C0} {3,12:C0}", sales[0], sales[1], sales[2],sales[3]);
//output $100,000    $150,000    $200,000    $225,000   
System.Console.WriteLine("{0,12:P0} {1,12:P0} {2,12:P1} {3,12:P2}", 
        intlMixPct[0], intlMixPct[1], intlMixPct[2],intlMixPct[3]);
//output 39%         41%        42.1%       45.70%

//FAZER ISSO DEPOIS EM OUTRO ARQUIVO

//STRING INTERPOLATION
// put variables and expressions directly inside the string
string make = "Mercedes";
string model = "G Class";
int year = 2020;
float miles = 8_450.27f;
decimal price = 60_275.0m;

// outputing with interpolation:
System.Console.WriteLine($"This car is a {year} {make} {model}, with {miles} miles and cost {price:C2}");

// with inline expressions
System.Console.WriteLine($"This car is a {year} {make} {model}, with {miles * 1.6:F2} Km and cost {{{price:C2}}}"); // the {{}} is to put the curly braces into the strings