using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProject
{
    class Task_2_3
    {
        public static void Pairs(int[] ints)
        {
            var a = ints.Join(ints, i1 => i1, i2 => i2, (i1, i2) => new { i1, i2 });
        }
    }
}
