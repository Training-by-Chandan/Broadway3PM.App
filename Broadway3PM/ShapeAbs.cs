using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public abstract class ShapeAbs
    {
        public void Area()
        {
            Console.WriteLine($"Area is : {AreaOfShape}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter is : {PerimeterOfShape}");
        }

        public abstract void GetInput();

        public double AreaOfShape;
        public double PerimeterOfShape;

        protected void Test()
        {
            Console.WriteLine("Method called");
        }
    }

    public class SquareAbs : ShapeAbs
    {
        public double Length { get; set; }

        public override void GetInput()
        {
            Console.WriteLine("Enter the length : ");
            Length = Convert.ToDouble(Console.ReadLine());
            AreaOfShape = Math.Pow(Length, 2);
            PerimeterOfShape = 4 * Length;
        }
    }

    public class RectangleAbs : ShapeAbs
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public override void GetInput()
        {
            Console.WriteLine("Enter the length");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth");
            Breadth = Convert.ToDouble(Console.ReadLine());
            AreaOfShape = Length * Breadth;
            PerimeterOfShape = 2 * (Length + Breadth);
        }
    }
}