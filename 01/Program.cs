namespace Bookstore
{
    class Program
    {
        static void Main()
        {
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Book book = new Book(author, title, price);
            GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

            line();

            Console.WriteLine("Type: Book");
            book.Display();

            line();

            Console.WriteLine("Type: GoldenEditionBook");
            goldenEditionBook.Display();

        }


        static void line()
        {
            Console.WriteLine("---------------------------");
        }
    }
}