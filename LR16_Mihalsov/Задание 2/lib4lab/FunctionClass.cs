using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib4lab
{
    public class FunctionClass
    {
        public static double f1(float x)
        {
            return Math.Pow(Math.Sin(x), 4);
        }
        public static double f2(float x)
        {
            return Math.Pow(x, 3 - 0.2 * x);
        }
        public static double f3(float x)
        {
            return Math.Pow(x, 2) - 6 * x + 18;
        }
    }
}
