using System;
namespace Inheritance {
    class Publication {
        private string name;
        public int PageCount {get;set;}
        public decimal Price {get;set;}
        public Publication(string name, int pageCount, decimal price) {
            this.name = name;
            PageCount = pageCount;
            Price = price;
        }

        public string Name {
            get {return this.name;}
            // using setter to validate the new property value
            set {
                if (value == "") {
                    throw new ArgumentException("Name cannot be blank");
                }
                this.name = value;

            }
        }

        // To create a method that the subclasses can overwrite, use the 'virtual' keyword
        public virtual string GetDescription() {
            return $"{Name}, {PageCount} pages.";
        }
    }
}