using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    internal class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.author = author;
            this.title = title;
            this.price = price;
        }


        public void Display()
        {
            Console.Write("Author: ");
            Console.WriteLine(author);
            Console.Write("Title: ");
            Console.WriteLine(title);
            Console.Write("Price: $");
            Console.WriteLine(Price); 
        }

        public virtual decimal Price
        {
            get { return price; }
        }

    }

    internal class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) 
            : base (author, title, price)
        {
        }

        public override decimal Price => base.Price * 1.3m;
         
    }
}
