using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProject
{
    class Task_1_2
    {
        public static int UniqCharCount(string[] names)
        {
            // all works))
            //return names.SelectMany(n => n).Distinct().Count();
            //return string.Join("", names).GroupBy(c => c).Count();
            return string.Join("", names).Distinct().Count();
        }
    }
}
