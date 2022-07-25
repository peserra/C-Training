using System;
namespace Inheritance {
    // book is subclass of publication
    class Book : Publication {
        private string author;
        

        public Book(string name, string author, int pageCount, decimal price) : base(name, pageCount, price) {
            this.author = author;
        }
        public string Author {
            get => this.author;
            set => this.author = value;
        }

        //to override a virtual method, use keyword override
        public override string GetDescription()
        {
            return $"{Name} by {Author}, {PageCount} pages";
        }

    }
}