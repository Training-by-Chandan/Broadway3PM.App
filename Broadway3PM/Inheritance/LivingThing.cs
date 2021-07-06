using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM.Inheritance
{
    public class LivingThing
    {
        protected string Respire { get; set; }
        public string Consume { get; set; }
        private string Reproduce { get; set; }
    }

    public class Animal : LivingThing
    {
        private void test()
        {
            this.Consume = "Plant";
            this.Respire = "o2 in and co2 out";
            //this.Reproduce = "yes";
        }
    }

    public class Plant : LivingThing
    {
        private void test()
        {
            this.Consume = "Sunlight, minerals";
            this.Respire = "co2 in and o2 out";
            //this.Reproduce = "yes";
        }
    }

    public sealed class HumanBeing : Animal
    {
        private void test()
        {
        }
    }

    //public class NewHuman : HumanBeing
    //{
    //}
}