using System;
namespace AccessModifiers {
    class Book {
        // access modifiers control how properties and methods are accessed
        // public members can be cesssed by any other class, but its not the right way to expose internal data
        public string _name;
        protected string _author;
        // private is the default inside classes
        private int _pageCount;

        public Book (string name, string author, int pages) {
            _name = name;
            _author = author;
            _pageCount = pages;
        }
        public string GetDescription() {
            return $"{_name} by {_author}, {_pageCount} pages";
        }

        // Variables should be acessed via methods (get, set)
        public string GetName() {
            return _name;
        }
        public void SetName(string s) {
            _name = s;
        }

        public void SetAuthor (string s) {
            _author = s;
        }
        public void SetPageCount(int c) {
            _pageCount = c;
        }
    }
}