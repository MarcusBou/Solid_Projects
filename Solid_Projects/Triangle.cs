using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Triangle: Shape
    {
        private double sideA, sideB, sideC;
        public double SideA { get { return sideA; } set { sideA = value; } }
        public double SideB { get { return sideB; } set { sideB = value; } }
        public double SideC { get { return sideC; } set { sideC = value; } }

        public Triangle(double a, double b)
        {
            this.sideA = a;
            this.sideB = b; 
            this.sideC = (Math.Sqrt((a * a) + (b * b)));
        }

        public override double Area()
        {
            return ((sideA * sideB)/2);
        }

        public override double Circumference()
        {
            return (sideA + sideB + sideC);
        }
    }
}
