using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_BinarysearchRecursive
{
    internal abstract class abstractClass
    {
        static int a1 = 0;
        public abstractClass(int a)
        {
            a1 = a;
        }

        internal int func1(int a)
        {
            a1 = a;

            return a1;
        }
        public virtual int func2(int a)
        {
            a1 -= a;

            return a1;
        }
        public abstract int func3(int a);
    }
}
