using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public static class IntExtension
    {
        public static int Add(this int i, int j)
        {
            return i + j;
        }

        public static int AddByNumber(this int i, int j = 1)
        {
            return i + j;
        }

        public static bool GT(this int i, int j)
        {
            return i > j;
        }

        public static bool LT(this int i, int j)
        {
            return i < j;
        }

        public static string AddDot(this string s)
        {
            return s += ".";
        }
    }
}