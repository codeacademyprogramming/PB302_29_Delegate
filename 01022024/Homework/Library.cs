using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Library
    {
        private List<string> _books = new List<string>();
        public IEnumerable<string> Books { get { return _books; } }

        public int BookLimit=4;
        public void AddBook(string bookName)
        {
            if (_books.Count >= BookLimit) throw new Exception("Library is full");
            //if (Books.IndexOf(bookName) == -1) throw new Exception();
            if(_books.Contains(bookName)) throw new Exception("Book already exists!");

            _books.Add(bookName);
        }

        public bool RemoveBook(string bookName)
        {
            return _books.Remove(bookName);
        }

        public IEnumerable<string> Search(string str)
        {
            foreach (var item in _books)
            {
                if (item.Contains(str)) yield return item;
            }
        }
        
    }
}
