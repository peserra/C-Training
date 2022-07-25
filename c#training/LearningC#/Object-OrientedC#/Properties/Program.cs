using System;
// CHECK DOCUMENTATION FOR PROPERTIES
namespace Props
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Correct way to control acces is using properties
            Book b = new Book("War and Peace", "Tolstoy L.", 825);

            // set ISBN and price
            b.ISBN = "100140447938";
            b.Price = 24.95m;

            //change the name and page count
            b.Name = "Crime and Punishment";
            b.PageCount = 625;

            System.Console.WriteLine(b.ISBN);
            System.Console.WriteLine(b.Price);
            System.Console.WriteLine(b.Name);
            System.Console.WriteLine(b.PageCount);
            System.Console.WriteLine(b.Description);
        }

    }

}