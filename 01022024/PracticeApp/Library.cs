using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeApp
{
    internal class Library
    {
        public List<Book> Books = new List<Book>();

        public void Add(Book book)
        {
            if(!Books.Exists(x=>x.Name == book.Name))
                Books.Add(book);
        }

        public Book FindByName(string name)
        {
            foreach (var item in Books)
            {
                if (item.Name == name) return item;
            }
            return null;
        }

        public Book FindByAuthor(string author)
        {
            foreach (var item in Books)
            {
                if (item.Author == author) return item;
            }
            return null;
        }
        
        public Book FindBySearch(string search)
        {
            foreach (var item in Books)
            {
                if (item.Name.Contains(search)) return item;
            }
            return null;
        }

        //public Book Find(Func<Book,bool> checkBook)
        //{
        //    foreach (var item in Books)
        //    {
        //        if (checkBook(item)) return item;
        //    }
        //    return null;
        //}

        public Book Find(Predicate<Book> checkBook)
        {
            foreach (var item in Books)
            {
                if (checkBook(item)) return item;
            }
            return null;
        }

        public IEnumerable<Book> Search(Predicate<Book> check)
        {
            foreach (var item in Books)
            {
                if(check(item)) yield return item;
            }
        }



    }
}
