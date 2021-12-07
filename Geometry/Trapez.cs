using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Trapez: Rectangle
    {
        private double sideC, sideD;
        public double SideC { get { return sideC; } set { sideC = value; } }
        public double SideD { get { return sideD; } set { sideD = value; } }

        public Trapez(double a, double b, double c, double d):base(a,b)
        {
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
            height = (((SideA + SideB-SideC + SideD))/2);//Calculate height
            area = (2/(SideA - sideC)*(Math.Sqrt(height*(height-SideA+sideC)*(height-SideB)*(height-sideD))));//calculte area
            return area;
        }
    }
}
