using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    /// <summary>
    /// A Brewpot for when out drink is done.
    /// </summary>
    public class BrewPot : Container
    {
        private string liquidType;
        public string LiquidType { get { return liquidType; } }
        public BrewPot(double siz) : base(siz)
        {

        }
    }
}
