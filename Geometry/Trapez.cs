using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Trapez: Square
    {
        private double sideB, sideC, sideD;
        public double SideB { get { return sideB; } set { sideB = value; } }
        public double SideC { get { return sideC; } set { sideC = value; } }
        public double SideD { get { return sideD; } set { sideD = value; } }

        public Trapez(double a, double b, double c, double d)
        {
            this.SideA = a;
            this.SideB = b;
            this.SideC = c;
            this.SideD = d;
        }

        public override double Circumference()
        {
            return (SideA + SideB + SideC + SideD);
        }

        public override double Area()
        {
            double area, height;
            height = (((SideA + sideB-SideC + SideD))/2);//Calculate height
            area = (2/(SideA - sideC)*(Math.Sqrt(height*(height-SideA+sideC)*(height-sideB)*(height-sideD))));//calculte area
            return area;
        }
    }
}
