using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    //if the class is static then we cannot create the object of this class
    //when the class is static all the members of this class is static - checked
    public static class ClassStatic
    {
        public static int i = 10;

        public static void Test()
        {
        }
    }

    //if the class is nonstatic (normal class), we can create as much object as we want
    //the members might be static
    //if the member is static, it can be accessed by any members
    //if the member is static, then it can only access static members
    public class ClassNonStatic
    {
        public int i = 0;
        public static int j = 0;

        public void Add()
        {
            i++;
            j++;

            Console.WriteLine($"i= {i}, j= {j}");
        }
    }
}