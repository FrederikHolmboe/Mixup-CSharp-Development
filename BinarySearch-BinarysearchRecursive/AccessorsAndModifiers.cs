using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch_BinarysearchRecursive
{
    internal class AccessorsAndModifiers
    {
        private int s1 { get; set; }
        private int s2 { get;}



        public int funk1(int a1)
        {
            s1 = a1;
            return s1;
        }

        public int funk2(int a1)
        {
            return s2;
        }

        // Fint bevis på hvordan read og set funktionerne på private variabler fungerer.

    }
}
