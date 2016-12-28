using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProject
{
    static class Task_1_1
    {
        public static IEnumerable<Book> AllBooks(IEnumerable<Book> books)
        {
            return books.Where(b => b.Name.Contains("LINQ") && ((b.Year % 4 == 0 && b.Year % 100 != 0) || b.Year % 400 == 0));
        }
    }
}
