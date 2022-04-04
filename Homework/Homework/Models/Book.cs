using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    class Book
    {
        private static int _idCounter;
        public int Id { get; private set; }
        public string Code { get; private set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        static Book()
        {
            _idCounter = 0;
        }
        private Book()
        {
            Id = ++_idCounter;
            Code = Name[0].ToString().ToUpper() + Id;
        }
        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }

    }
}
