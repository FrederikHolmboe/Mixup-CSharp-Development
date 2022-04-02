using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_BinarysearchRecursive
{
    internal class Class1TryAbstract : abstractClass
    {
        public Class1TryAbstract(int a) : base(a)
        {
        }

        public override int func2(int a)
        {
            return a + 5;
        }

        public override int func3(int a)
        {
            throw new NotImplementedException();
        }
    }
}
