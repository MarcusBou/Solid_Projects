using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    /// <summary>
    /// A fill in for water so it can be made for drink
    /// </summary>
    public class WaterContainer: Container ,ITransferContainers
    {
         public WaterContainer(double siz) : base(siz)
            {
            
            }

        public void TransferToNextContainer(Container container, double fill, TypesOfLiquid types)
        {
            container.fillContainer(fill, types);
            this.filled = 0;
        }
    }
}
