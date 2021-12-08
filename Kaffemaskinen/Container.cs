using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public class Container
    {
        protected double size;
        protected double filled;
        protected TypesOfLiquid liquid;
        public double Size { get { return size; } }
        public double Filled { get { return filled; } }
        public TypesOfLiquid Liquid { get { return liquid; } }

        public Container(double siz)
        {
            this.size = siz;
            this.filled = 0;
        }

        public void fillContainer(double fill, TypesOfLiquid types)
        {
            this.filled = fill;
            this.liquid = types;
        }
    }
}
