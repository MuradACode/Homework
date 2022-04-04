using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    class Library
    {
        public List<Book> books = new List<Book>();

        public List<Book> FindAllBooksByName(string value)
        {
            return books.FindAll(n => n.Name == value);
        }
        public void RemoveAllBooksByName(string value)
        {
            books.RemoveAll(n => n.Name == value);
        }
        public List<Book> SearchBooks(string value)
        {
            return books.FindAll(n => n.Name == value || n.AuthorName == value || n.PageCount.ToString() == value);
        }
        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return books.FindAll(n => n.PageCount >= min && n.PageCount <= max);
        }
        public void RemoveBookByCode(string value)
        {
            books.Remove(books.Find(n => n.Code == value));
        }
    }
}
