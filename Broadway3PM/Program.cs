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

                //CastingExamples();

                //ClassExample();

                //OperatorOverloading();

                //PropertiesExample();

                //IndexerExample();

                DictionaryExample();
                Console.WriteLine("Do you want to continue more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");

            Console.ReadLine();
        }

        private static void DictionaryExample()
        {
            Dictionary<int, string> days = new Dictionary<int, string>();
            days.Add(1, "Sunday");
            days.Add(2, "Sunday");
            days.Add(3, "Tuesday");
            days.Add(4, "Wednesday");
            days.Add(5, "Thursday");
            days.Add(6, "Friday");
            days.Add(7, "Saturday");

            Console.WriteLine("Enter the number of days");
            var res = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("day => " + days[res]);
        }

        private static void IndexerExample()
        {
            Numbers n = new Numbers();
            Console.WriteLine(n[0]);
            Console.WriteLine(n[1]);
            Console.WriteLine(n[2]);
            Console.WriteLine(n[3]);
            Console.WriteLine(n[4]);
            Console.WriteLine(n[5]);

            Days d = new Days();
            Console.WriteLine(d[1]);
            Console.WriteLine(d[2]);
            Console.WriteLine(d[3]);
            Console.WriteLine(d[4]);
            Console.WriteLine(d[5]);
            Console.WriteLine(d[6]);
            Console.WriteLine(d[7]);
        }

        private static void PropertiesExample()
        {
            StudentClass sc = new StudentClass();
            Console.WriteLine("Enter the First name:");
            sc.FName = Console.ReadLine();

            Console.WriteLine("Enter the Middle name:");
            sc.MName = Console.ReadLine();

            Console.WriteLine("Enter the Last name:");
            sc.LName = Console.ReadLine();

            Console.WriteLine("Value in FName is =>" + sc.FullName);

            Console.WriteLine("Enter the Math Marks:");
            sc.MathMarks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Science Marks:");
            sc.ScienceMarks = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Math =>" + sc.MathMarks);
            Console.WriteLine("Science =>" + sc.ScienceMarks);
            Console.WriteLine("Total =>" + sc.TotalMarks);
            Console.WriteLine("Percentage =>" + sc.Percentage);
            Console.WriteLine("Division =>" + sc.Division);
        }

        private static void OperatorOverloading()
        {
            MathExample m1 = new MathExample();
            MathExample m2 = new MathExample();
            MathExample m3 = new MathExample();
            MathExample m4 = new MathExample();
            MathExample m5 = new MathExample();
            int a = 10;
            int b = 20;
            a++;

            var res = a + b;
            var mathRes = m1 + m2 + m3 + m4 + m5;

            m1++;
            //m2++;

            var equalResult = m1 == m2;
            var notequalResult = m1 != m2;
        }

        private static void OverloadExample()
        {
            MathExample m1 = new MathExample();
            var res1 = m1.Add(20);
            var res2 = m1.Add(20, 30);
            var res3 = m1.Add(20, 30, 40);
        }

        private static void ClassExample()
        {
            Human h1 = new Human();
            // Human h2 = new Human();
            Human h3 = new Human("Jay");
            Human h2 = new Human(1, 2);
            Human h4 = new Human("some name", 3, 4);
            h1.Move();
            h2.Move();
            h3.Move();
            h4.Move();
        }

        private static void CastingExamples()
        {
            //implicit casting - automatic
            char a = 'A';
            int b = a;
            long c = b;
            float d = c;
            double e = d;

            //explicit casting - manual
            double f = 10.000423d;
            float g = (float)f;
            long h = (long)g;
            int i = (int)h;
            char j = (char)i;

            //Convert Class - Type Conversion
            Console.WriteLine("Enter a number");
            var data = Console.ReadLine();
            var converted = Convert.ToDouble(data);
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

    public class StudentClass
    {
        public StudentClass()
        {
            this.minMarks = 0;
            this.maxMarks = 100;
        }

        public StudentClass(double minMarks, double maxMarks)
        {
            this.minMarks = minMarks;
            this.maxMarks = maxMarks;
        }

        private string fname = "";

        public string FName
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        private string lName;

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        private string mName;

        public string MName
        {
            get { return mName; }
            set { mName = value; }
        }

        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(MName))
                {
                    return FName + " " + LName;
                }
                else
                {
                    return FName + " " + MName + " " + LName;
                }
            }
        }

        private double minMarks = 0;
        private double maxMarks = 100;

        private double mathMarks;

        public double MathMarks
        {
            get { return mathMarks; }
            set
            {
                if (value < minMarks)
                {
                    mathMarks = minMarks;
                }
                else if (value > maxMarks)
                {
                    mathMarks = maxMarks;
                }
                else
                {
                    mathMarks = value;
                }
            }
        }

        private double scienceMarks;

        public double ScienceMarks
        {
            get { return scienceMarks; }
            set
            {
                if (value < minMarks)
                {
                    scienceMarks = minMarks;
                }
                else if (value > maxMarks)
                {
                    scienceMarks = maxMarks;
                }
                else
                {
                    scienceMarks = value;
                }
            }
        }

        public double TotalMarks
        {
            get
            {
                return this.mathMarks + this.scienceMarks;
            }
        }

        public double Percentage
        {
            get
            {
                return this.TotalMarks / 2;
            }
        }

        public string Division
        {
            get
            {
                var val = "";
                if (this.Percentage >= 80)
                {
                    val = "Distinction";
                }
                else if (this.Percentage >= 60)
                {
                    val = "First Division";
                }
                else if (this.Percentage >= 45)
                {
                    val = "Second Division";
                }
                else
                {
                    val = "Failed";
                }

                return val;
            }
        }
    }

    public class Numbers
    {
        private string[] data = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
        public string this[int i] => data[i];
    }

    public class Days
    {
        private string[] data = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        public string this[int i] => data[i - 1];
    }

    public class Human
    {
        public Human()
        {
            Name = "Babu";
        }

        public Human(string name)
        {
            Name = name;
        }

        public Human(int hand, int ears)
        {
            NumberofEars = ears;
            NumberOfHands = hand;
        }

        public Human(string name, int hand, int ear)
        {
            Name = name;
            NumberOfHands = hand;
            NumberofEars = ear;
        }

        public int NumberOfHands = 2; //Variable
        public int NumberofEars = 2; //Variable
        public string Name { get; set; } //Properties

        public void Move()// void does not return
        {
        }

        public void Move(string direction)
        {
        }

        public void Move(string direction, string distance)
        {
        }
    }

    public class MathExample
    {
        public MathExample()
        {
            a = 10;
            b = 30;
            c = 40;
        }

        public int a;
        public int b;
        public int c;
        public string str;

        public static MathExample operator +(MathExample obj1, MathExample obj2)
        {
            return new MathExample()
            {
                a = obj1.a + obj2.a,
                b = obj1.b + obj2.b,
                c = obj1.c + obj2.c,
                str = obj1.str + obj2.str
            };
        }

        public static MathExample operator ++(MathExample m1)
        {
            return new MathExample()
            {
                a = m1.a + 2,
                b = m1.b + 2,
                c = m1.c + 2,
                str = m1.str + " "
            };
        }

        public static bool operator ==(MathExample m1, MathExample m2)
        {
            return (m1.a == m2.a) && (m1.b == m2.b) && (m1.c == m2.c) && (m1.str == m2.str);
        }

        public static bool operator !=(MathExample m1, MathExample m2)
        {
            return !((m1.a == m2.a) && (m1.b == m2.b) && (m1.c == m2.c) && (m1.str == m2.str));
        }

        public double Add(double a)
        {
            return a + 1;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}