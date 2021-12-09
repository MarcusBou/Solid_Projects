using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    /// <summary>
    /// a filter For brewing
    /// </summary>
    public class Filter
    {
        private TypesOfLiquid typeForBrew;
        public TypesOfLiquid TypeForBrew { get { return typeForBrew; } set { typeForBrew = value; } }
        
        public Filter()
        {
            
        }

        /// <summary>
        /// Prepares Filter With the beans needed for the liquid
        /// </summary>
        /// <param name="types"></param>
        public void PrepareBrewInFilter(TypesOfLiquid types)
        {
            this.typeForBrew = types;
        }
        
    }
}
