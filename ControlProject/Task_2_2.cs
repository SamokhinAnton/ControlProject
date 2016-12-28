using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProject
{
    class Task_2_2
    {
        public static IEnumerable<BookDto> BooksSequence(IEnumerable<Book> books)
        {
            return books.GroupBy(b => b.Author).Select(g => new BookDto
            {
                Author = g.Key,
                Num = g.Count()
            });
        }
        public struct BookDto
        {
            public int Num { get; set; }
            public string Author { get; set; }
        }
    }
}
