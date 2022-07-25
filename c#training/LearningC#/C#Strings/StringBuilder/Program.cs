using System;
using System.Text;
// building strings out of other strings

// Strings are IMUTABLE
// so stringbuilder is used so we can avoid creating n string, wich would reduce the overall performance

int jumpCount = 10;
string[] animals = {"goats", "cats", "pigs"};

// create a StringBuilder
// its possible to specify the inicial or final string, and its total capacity
// ... new StringBuilder("Initial string.", 200);
StringBuilder sb = new StringBuilder();

//print some basic stats about StringBuilder
System.Console.WriteLine($"Capacity: {sb.Capacity}, length: {sb.Length}");

// add some strings to the builder using Append
sb.Append("The quick brown fox ");
sb.Append("jumped over the lazy dog");

// appendline to append a line ending
sb.AppendLine();

// appendFormat to append formated strings
sb.AppendFormat("He did this {0} times", jumpCount);
sb.AppendLine();

// appendjoin to iterate over a set of values
sb.Append("He also jumped over ");
sb.AppendJoin(',', animals);

// to modify the content using replace
sb.Replace("fox", "cat");

// to insert content at any index
sb.Insert(0, "This is the ");

// to convert into a single string

string singleString = sb.ToString();
System.Console.WriteLine(singleString);
