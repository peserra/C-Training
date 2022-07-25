using System;
namespace Props
{
    public class Book
    {
        private string name;
        private string author;
        private int pageCount;


        public Book(string name, string author, int pages)
        {
            this.name = name;
            this.author = author;
            this.pageCount = pages;
        }

        // should use properties to implement access to our internal data
        // called a property with a 'backing field'
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value; //value is a magical variable
            }
        }

        // shorthand to do this using the => operator
        // use to create 'expression-bodied' properties
        public string Author
        {
            get => this.author;
            set => this.author = value;
        }

        public int PageCount
        {
            get => this.pageCount;
            set => this.pageCount = value;
        }

        //one of the great uses of properties is to create a 'computed property'
        // wich get their values out of other properties and expressions
        public string Description
        {
            get => $"{Name} by {Author}, {PageCount} pages";
        }

        //auto generated properties
        // if there's no backing field, the property can hold the data
        public string ISBN { get; set; } //this hold the data with the getter and setter
        public decimal Price { get; set; }
    }
}