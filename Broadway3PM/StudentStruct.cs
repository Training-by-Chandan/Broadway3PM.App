using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    //https://www.c-sharpcorner.com/blogs/difference-between-struct-and-class-in-c-sharp follow this link for more information
    public struct StudentStruct
    {
        public string Name;
        public string Email;
        public int Age;
    }

    public class StudentCls
    {
        public StudentCls()
        {
        }

        public string Name;
        public string Email;
        public int Age;
    }
}