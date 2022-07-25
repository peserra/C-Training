//Basic logical decisions
//basic if:
int val = 50;
if (val == 50) {
    Console.WriteLine("val is 50");
} else if (val >= 51 && val <= 60) {
    Console.WriteLine ("val is between 51 and 60");
} else {
    Console.WriteLine("val is not 50");
}

//ternary operator (shortened if-else)
//structure statement ? true : false
Console.WriteLine(val < 50 ? "val is small" : "val is large");

//Switch
// syntax: switch(<any non null thing i want to check>)
//              case <is this value>:
//                  <do something>
//                  break
switch (val) {
    case 50:
        Console.WriteLine("Val is 50");
        break;
    case 51:
    case 52:
    case 53:
        Console.WriteLine("val is between 51 and 53");
        break;
    default:
        Console.WriteLine("Val is something else");
        break;
}

// For Loop
// execute code a specific number of times
int  myVal = 15;
int [] nums = new int[] {3,14,15,92,6};
string str = "The quick brown fox jumps over the lazy dog";

System.Console.WriteLine("The basic for loop: ");
for (int i = 0; i < myVal; i++) {
    System.Console.WriteLine($"i is curently {i}");
}
//for each used to a list of value

foreach (int i in nums) {
    System.Console.WriteLine($"i is currently {i}");
}
var count = 0;
//can be used on strings too
foreach (char c in str) {
    if (c == 'o') {
        count++;
    }
}

//while loops
string inputStr = "";
while (inputStr != "exit") {
    inputStr = Console.ReadLine();
    System.Console.WriteLine($"You entered: {inputStr}");
}

//doWhile: execute atleast once
do {
    inputStr = Console.ReadLine();
    System.Console.WriteLine($"You entered: {inputStr}");
} while (inputStr != "exit");

// Using break and continue
int[] values = {15,7,23,12,41,28};
foreach (int value in values) {
    if (value >= 20 && value <= 29) {
        continue; //if the number is between 20-29, skip to next iteration
    }
    if (value >= 40) {
        break; //doesnt allow the code to finish if we met the condition
    }
}

//Exceptions
// catch errors before they go to the user
//using trycatch try{thatCode}catch{if error, do this}+ finally{optional, always runs}

int x = 100;
int y = 0;
int result;

try {
    if (x > 1000) {
        throw new ArgumentOutOfRangeException("x", "x has to be smaller than 1000");
    }
    result = x/y;
    System.Console.WriteLine($"Result is: {result}");  
} catch (DivideByZeroException e) {
    System.Console.WriteLine("Oops! We cant divide by zero yet");
    System.Console.WriteLine(e.Message);
} catch (ArgumentOutOfRangeException e) {
    System.Console.WriteLine("Sorry, 1000 is the limit");
    System.Console.WriteLine(e.Message);
} finally {
    System.Console.WriteLine("this code always runs");
}