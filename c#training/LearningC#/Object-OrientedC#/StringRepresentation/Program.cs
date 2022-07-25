namespace StringRepresentation {
    class Program {
        public static void Main(string[] args) {
            // Every class in C# inherits from Object, wich means that every class injerits the ToString() method
            // int x = 1000;
            // System.Console.WriteLine(x.ToString());

            //if you dont override the method, the default bejavior just prints the name of the class and namespace
            // object a = new object();
            // System.Console.WriteLine(a.ToString());

            //using the ToString method on the book class
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            System.Console.WriteLine(b1.ToString());
            System.Console.WriteLine(b1); //implicit conversion to string
            System.Console.WriteLine(b1.ToString('B'));
            System.Console.WriteLine(b1.ToString('F'));
        }
    }
}