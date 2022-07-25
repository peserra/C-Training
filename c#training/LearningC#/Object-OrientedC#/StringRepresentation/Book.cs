namespace StringRepresentation {
    class Book {
        public string Name {get;set;}
        public string Author {get;set;}
        public int PageCount {get;}

        public Book(string name, string author, int pages) {
            Name = name;
            Author = author;
            PageCount = pages;
        }

        // The toString method generates a string representation of the object
        public override string ToString()
        {
            return $"Book: {Name} by {Author}";
        }

        // ToString can be overloaded to give differente format versions
        //this version is not an override function its an overloaded version, since there is no argument in the original ToString
        public string ToString(char format) {
            if (format == 'B') {
                return $"Book: {Name}:{Author}";
            }
            if (format == 'F') {
                return $"Book: {Name} by {Author} is {PageCount} pages";
            }
            return ToString();
        }
    }
}