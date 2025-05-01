using System.Reflection.Metadata.Ecma335;
using Day09;
namespace Day09
{
    public delegate string DEl1(Book B);
    public delegate string DEl2<T>(T B);
    public delegate String DEl3(Book B);
    internal class Program
    {
        //user defined delegate
      

        static void Main(string[] args)
        {
            // list of books
            List<Book> books = new List<Book>
        {
            new Book
            {
                ISBN = "978-1-59327-584-6",
                Title = "Eloquent JavaScript",
                Authors = new string[] { "Marijn Haverbeke" },
                PublicationDate = new DateTime(2018, 12, 4),
                Price = 30.00m
            },
            new Book
            {
                ISBN = "978-0-13-235088-4",
                Title = "Clean Code",
                Authors = new string[] { "Robert C. Martin" },
                PublicationDate = new DateTime(2008, 8, 1),
                Price = 40.00m
            },
            new Book
            {
                ISBN = "978-0-321-63537-8",
                Title = "Design Patterns: Elements of Reusable Object-Oriented Software",
                Authors = new string[] { "Erich Gamma", "Richard Helm", "Ralph Johnson", "John Vlissides" },
                PublicationDate = new DateTime(1994, 10, 31),
                Price = 54.95m
            },
            new Book
            {
                ISBN = "978-1-118-74931-9",
                Title = "The Pragmatic Programmer",
                Authors = new string[] { "Andrew Hunt", "David Thomas" },
                PublicationDate = new DateTime(1999, 10, 20),
                Price = 42.00m
            }
        };

            //user defined delegate
            DEl1 dpt=new DEl1(BookFunctions.GetPrice);
           

            Console.WriteLine($"Price:{dpt.Invoke(books[0])}");
            dpt = BookFunctions.GetAuthors;
            Console.WriteLine($"Authors:{dpt(books[0])}");
            DEl2<Book> dep2 = new DEl2<Book>(BookFunctions.GetTitle);
            Console.WriteLine($"Title:{dep2(books[0])}");


            //BCL
            Func<Book, string> fun1 = BookFunctions.GetTitle;
            Console.WriteLine($"Title:{fun1.Invoke(books[1])}");
            Console.WriteLine("---------------------------");

            //Library Engine 

            DEl3 del = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, del);


            del= BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, del);

            del = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(books, del);


            //anonymous method
            Func<Book, string> fptr = delegate (Book B) { return B.ISBN; };
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"ISBN:{fptr(books[i])}");
            }


            // Lambda Expression
            Func<Book,DateTime> fptr2= B=>B.PublicationDate;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Publication Date:{fptr2?.Invoke(books[i])}");
            }
        }
    }
}
