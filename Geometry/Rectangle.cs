using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Rectangle: Square
    {
        private double sideB;
        public double SideB { get { return sideB; } set { sideB = value; } }

        public Rectangle() { }
        public Rectangle(double a, double b)
        {
            this.SideA = a;
            this.SideB = b;
        }

        public override double Circumference()
        {
            return (SideA + sideB + SideA + sideB);
        }
        public override double Area()
        {
            return (SideA * SideB);
        }
    }
}
