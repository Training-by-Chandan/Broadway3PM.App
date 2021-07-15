using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public class TemplateClass<T1, T2>
    {
        public void Function1(T1 a, T2 b, T1 c)
        {
            Console.WriteLine($"Type of a is {a.GetType()}");
            Console.WriteLine($"Type of b is {b.GetType()}");
            Console.WriteLine($"Type of c is {c.GetType()}");
        }
    }

    public class ContraintsTemplateClass<T> where T : ITemplated
    {
    }

    public class InterfacedTemplate<T1> : ContraintsTemplateClass<Inheritance.LivingThing>

        where T1 : IShape
    {
    }

    public interface ITemplated
    {
    }
}