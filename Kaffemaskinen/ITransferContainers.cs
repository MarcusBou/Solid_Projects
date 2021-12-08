using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public interface ITransferContainers
    {
        /// <summary>
        /// for transferring to the next process of the brewing, for those that is chained to another container
        /// </summary>
        /// <param name="container"></param>
        /// <param name="fill"></param>
        /// <param name="types"></param>
        public void TransferToNextContainer(Container container, double fill, TypesOfLiquid types);
    }
}
