using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section3
{
    public delegate bool ConditionFuncDelegate(int X);
    internal class ConditionFunctions
    {
        public static bool CheckOdd(int X) { return X % 2 != 0; }
        public static bool CheckEven(int X) { return X % 2 == 0; }
        public static bool CheckDivisableBy4(int X) { return X % 4 == 0; }
    }
}
