using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    public class Parallelogram: Rectangle//i take use of rectangle, since both parrallelogram and rectangle, take uses of 4 sides both with 2 which is the same length so i am able to reuse code 
    {
        private double angle;
        public double Angle { get { return angle; } set { angle = value; } }
        public Parallelogram(double a, double b, double angle)
        {
            this.SideA = a;
            this.SideB = b;
            this.Angle = angle;
        }

        public override double Area()
        {
            return (SideA * SideB * Math.Sin(angle));//uses sin to take in the angle
        }
    }
}
