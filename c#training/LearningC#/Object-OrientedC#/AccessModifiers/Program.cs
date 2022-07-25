using System;
namespace AccessModifiers {
    class Program {
        public static void Main(string[] args) {
            Book b1 = new Book ("War and Peace", "Leo Tolstoy", 825);

            // since the name is public, we can change in here
            b1._name = "Cat in the hat";

            // using seters to set protected and private data
            b1.SetName("Grapes of wrath");
            b1.SetAuthor("John Steinbeck");
            b1.SetPageCount(464);
        }
    }
}
