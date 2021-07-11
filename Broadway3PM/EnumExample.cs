using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway3PM
{
    public enum DaysEnum
    {
        Monday = 2,
        Tuesday = 3,
        Sunday = 1,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7
    }

    public enum MonthEnum
    {
        Jan = 0,
        Feb = 1,
        Mar = 2,
        Apr = 3,
        May = 4,
        Jun = 5,
        Jul = 6,
        Aug = 7,
        Sep = 8,
        Oct = 9,
        Nov = 10,
        Dec = 11
    }

    public enum Color
    {
        White = 0XFFFFFF, // hexadecimal number
        Black = 0X000000,
        Red = 0XFF0000,
        Green = 0X00FF00,
        Blue = 0X0000FF
    }

    public enum Gender
    {
        Male,
        Female,
        ThirdGender,
        Others
    }

    public enum Roles
    {
        Student,
        Teacher,
        Admin,
        Parent
    }

    public enum Shape
    {
        None,
        Square,
        Rectangle,
        Circle,
        IsoscelesTriangle,
    }
}