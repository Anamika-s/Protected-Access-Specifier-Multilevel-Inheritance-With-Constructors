using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo2
{
     static class NumericFunctions
    {
        public static int Add(int x, int y)
        {

            return x + y;
        }
        public static bool IsEven(int x)
        {

            if (x % 2 == 0) return true;
            else
                return false;

        }
    }
}
