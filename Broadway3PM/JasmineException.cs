using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public class JasmineException : Exception
    {
    }

    public class JayException : Exception
    {
    }

    public class ExceptionExample
    {
        public static string AnalyzeString(string str)
        {
            if (str == "Jasmine")
            {
                throw new JasmineException();
            }
            else if (str == "Jay")
            {
                throw new JayException();
            }
            else if (str == "Chandan")
            {
                throw new Exception();
            }

            return str;
        }
    }
}