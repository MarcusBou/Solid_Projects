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
        public double Size { get { return size; } }
        public double Filled { get { return filled; } }

        public Container(double siz)
        {
            this.size = siz;
            this.filled = 0;
        }
    }
}
