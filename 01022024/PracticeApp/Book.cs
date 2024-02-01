using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    internal class Book
    {
        public Book(string name, double price, string author)
        {
            Name = name;
            Price = price;
            Author = author;
        }
        public string Name;
        public double Price;
        public string Author;

        public override string ToString()
        {
            return this.Name + "-" + this.Author + "-" + this.Price;
        }
    }
}
