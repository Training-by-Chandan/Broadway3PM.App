using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public class PassBy
    {
        public static void AddByValue(int a, int b)
        {
            a = a + b;
        }

        public static void AddByReference(ref int a, ref int b)
        {
            a = a + b;
        }

        public static void AddInOut(int a, int b, out int res)
        {
            a = a + b;
            b = 1;
            res = a + b;
        }
    }
}