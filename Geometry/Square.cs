using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Square: Shape
    {
        private double sideA;

        public double SideA { get { return sideA; } set { sideA = value; } }

        public Square() { }
        public Square(double a)
        {
            this.sideA = a;
        }

        public override double Circumference()
        {
            return (sideA + sideA + sideA + sideA);
        }

        public override double Area()
        {
            return (sideA * sideA);
        }
    }
}
