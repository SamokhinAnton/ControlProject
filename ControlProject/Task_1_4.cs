using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProject
{
    class Task_1_4
    {
        public static void PrintBooks(IEnumerable<Book> books)
        {
            var result = books.GroupBy(b => b.Author);

            foreach (var item in result)
            {
                Console.WriteLine("Author {0} wrote {1} books", item.Key, item.Count());
            }
        }
    }
}
