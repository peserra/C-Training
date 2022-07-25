using System;


namespace Defining
{
    class Program
    {
        static void Main(String[] args)
        {
            // to use classes, we have to create instances of classes called objects ('new' operator)
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);
            // calling the method on the object
            System.Console.WriteLine(b1.GetDescription());
            System.Console.WriteLine(b2.GetDescription());

            //trying to set one of the properties will result an error due to protection levels
        }
    }
}