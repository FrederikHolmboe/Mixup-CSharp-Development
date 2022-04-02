using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_BinarysearchRecursive.Polymorphi
{
    internal class PolymorphClass
    {
        static int sum = 0;
        public PolymorphClass(int addup)
        {
            sum = addup;
        }

        public int func1(int add)
        {
            sum += add;
            return sum;
        }
    }
}
