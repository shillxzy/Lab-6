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
            Author = author;
            Title = title;
            Price = price;
        }


        public void Display()
        {
            Console.Write("Author: ");
            Console.WriteLine(Author);
            Console.Write("Title: ");
            Console.WriteLine(Title);
            Console.Write("Price: $");
            Console.WriteLine(Price); 
        }

        public string Author
        {
            get { return author; }

            set
            {
                if (char.IsNumber(value[0]))
                {
                    throw new("Author not valid!");
                }
                else
                {
                    author = value;
                }
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length <= 3)
                {
                    throw new("Title not valid!");
                }
                else
                {
                    title = value;
                }
            }
        }

        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0 || value > 999999999999)
                {
                    throw new("The price is not valid!");
                }
                else
                {
                    price = value;
                }
            }
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
