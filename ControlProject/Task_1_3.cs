using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProject
{
    class Task_1_3
    {
        public static IEnumerable<int> OrderArray(int[] nums)
        {
            return nums.OrderBy(n => n % 10).ThenByDescending(n => n/10);
        }
    }
}
