using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP_STRUCT
{
    class Program
    {
        struct Book
        {
            public string title;
            public string author;
            public decimal price;
            public bool paperback;
            public Book(string Title, string Author, decimal Price, bool Paperback)
            {
                title = Title;
                author = Author;
                price = Price;
                paperback = Paperback;
            }
            //매개변수 없는 생성자는 생성 불가능.
        }

        static void Main(string[] args)
        { 
            Book book = new Book();
        }
    }
}
