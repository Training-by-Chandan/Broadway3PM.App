using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public class Program
    {
        //accessmodifier returntype functionname(parameters)
        //accessmodifier => public, private, protected, internal, internal protected
        //return type => void, int, any data type or model
        //functionname => anything/ should not have same signature
        //parameters => anything (zero to many)
        private static void Main(string[] args)
        {
            var res = "y";
            do
            {
                //Branching();

                //Looping();

                CastingExamples();

                Console.WriteLine("Do you want to continue more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");

            Console.ReadLine();
        }

        private static void CastingExamples()
        {
        }

        private static void Branching()
        {
            Console.WriteLine("Enter the Day Number");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Sunday");
                    break;

                case "2":
                    Console.WriteLine("Monday");
                    break;

                case "3":
                    Console.WriteLine("Tuesday");
                    break;

                case "4":
                    Console.WriteLine("Wednesday");
                    break;

                case "5":
                    Console.WriteLine("Thursday");
                    break;

                case "6":
                    Console.WriteLine("Friday");
                    break;

                case "7":
                    Console.WriteLine("Saturday");
                    break;

                default:
                    break;
            }

            switch (choice)
            {
                case "1":
                case "7":
                    Console.WriteLine("Its Weekend");
                    break;

                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                    Console.WriteLine("Its Weekdays");
                    break;

                default:
                    break;
            }
        }

        private static void Looping()
        {
            ////pattern generation
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("Enter any number");
            var num = Convert.ToInt32(Console.ReadLine());

            string[] s = new string[num];
            s[0] = "Jay";
            s[1] = "Raj";
            s[2] = "Joshi";
            s[3] = "Jasmine";
            s[4] = "Shrestha";

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}