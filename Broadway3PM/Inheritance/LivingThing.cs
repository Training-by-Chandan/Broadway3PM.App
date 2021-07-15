using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM.Inheritance
{
    public class LivingThing : ITemplated
    {
        public LivingThing(string respire)
        {
            this.Respire = respire;
        }

        public LivingThing(string respire, string consume)
        {
        }

        public void Respiriration()
        {
            Console.WriteLine("I am from living thing class");
        }

        protected string Respire { get; set; }
        public string Consume { get; set; }
        private string Reproduce { get; set; }
    }

    public class Animal : LivingThing
    {
        public Animal() : base("")
        {
        }

        public Animal(string respire) : base(respire)
        {
        }

        public Animal(string respire, string consume) : base(respire, consume)
        {
        }

        public new void Respiriration()
        {
            Console.WriteLine("I am from Animal class");
        }

        private void test()
        {
            this.Consume = "Plant";
            this.Respire = "o2 in and co2 out";
            //this.Reproduce = "yes";
        }
    }

    public class Plant : LivingThing
    {
        public Plant() : base(null)
        {
        }

        private void test()
        {
            this.Consume = "Sunlight, minerals";
            this.Respire = "co2 in and o2 out";
            //this.Reproduce = "yes";
        }
    }

    public sealed class HumanBeing : Animal
    {
        public HumanBeing()
        {
        }

        private void test()
        {
        }
    }

    [Serializable]
    public class MyException : Exception
    {
        public MyException()
        {
        }

        public MyException(string message) : base(message)
        {
        }

        public MyException(string message, Exception inner) : base(message, inner)
        {
        }

        protected MyException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    //public class NewHuman : HumanBeing
    //{
    //}
}