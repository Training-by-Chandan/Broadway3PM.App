using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public interface IArea
    {
        void Area();
    }

    public interface IPerimeter
    {
        void Perimeter();
    }

    public interface IGetInput
    {
        void GetInput();
    }

    public interface IShape : IArea, IPerimeter, IGetInput
    {
    }

    public class Square : IShape
    {
        private double length { get; set; }

        public void Area()
        {
            Console.WriteLine($"Area is : {Math.Pow(length, 2)}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter is : {4 * length}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the length : ");
            length = Convert.ToDouble(Console.ReadLine());
        }

        public void Test()
        {
        }
    }

    public class Rectangle : IShape
    {
        private double length { get; set; }
        private double breadth { get; set; }

        public void Area()
        {
            Console.WriteLine($"Area of Rectangle is : {length * breadth}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of rectangle is : {2 * (length + breadth)}");
        }
    }

    public class Circle : IShape
    {
        private double radius { get; set; }

        public void Area()
        {
            Console.WriteLine($"Area is : { Math.PI * Math.Pow(radius, 2)}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Circumference is : {2 * Math.PI * radius}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the radius : ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Test()
        {
        }
    }
}