using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    /// <summary>
    /// A brew funnel for creating our brew
    /// </summary>
    public class BrewFunnel: Container, ITransferContainers
    {
        private Filter filter;
        public Filter Filter { get { return filter; } } 
        public BrewFunnel(double siz) : base(siz)
        {

        }

        /// <summary>
        /// For Changing filter
        /// </summary>
        /// <param name="filt"></param>
        public void NewFilter(Filter filt)
        {
            filter = filt;
        }

        public void TransferToNextContainer(Container container, double fill, TypesOfLiquid types)
        {
            container.fillContainer(fill, types);
            this.filled = 0;
        }
    }
}
