using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    /// <summary>
    /// containers for liquid
    /// </summary>
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

        /// <summary>
        /// for filling a container with a certain amount
        /// </summary>
        /// <param name="fill"></param>
        /// <param name="types"></param>
        public void fillContainer(double fill, TypesOfLiquid types)
        {
            if (fill > size)
            {
                this.filled = fill;
                this.liquid = types;
            }
        }
    }
}
