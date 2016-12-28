using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProject
{
    class Task_2_1
    {
        public static int AgrCount(int[] ints)
        {
            return ints.Aggregate(0, (acc, el) => acc + el);
        }
        public static int AgrMax(int[] ints)
        {
            return ints.Aggregate(int.MinValue, (acc, el) => acc > el ? acc : el);
        }
        public static int AgrAvg(int[] ints)
        {
            return AgrCount(ints) / ints.Length;
        }
    }
}
