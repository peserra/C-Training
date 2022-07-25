using System;
using DefiningClasses;

namespace DefiningClasses
{
    // classes have a unique name within a namespace
    public class Book
    {
        // atributes
        string _name;
        string _author;
        string _pageCount;

        // classes have one or more constructors
        public Book(string name, string author, string pages)
        {
            _name = name;
            this._author = author;
            _pageCount = pages;
        }
        // methods
        public string GetDescription()
        {
            return $"{_name} by {_author}";
        }
    }
}