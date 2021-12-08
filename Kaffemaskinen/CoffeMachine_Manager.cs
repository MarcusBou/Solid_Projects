using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public class CoffeMachine_Manager
    {
        BasicCoffeeMachine cm = new BasicCoffeeMachine(100);    
        
        /// <summary>
        ///  For Turnin coffe machine on
        /// </summary>
        public void TurnOnCoffeeBrewer()
        {
            cm.ChangePowestate(true);
        }
        /// <summary>
        ///  For Turnin coffe machine off
        /// </summary>
        public void TurnOffCoffeeBrewer()
        {
            cm.ChangePowestate(false);
        }

        /// <summary>
        /// For inserting a new filter, and since it is not the coffemachine creating the filters they are created by the manager
        /// </summary>
        public void ChangeFilter()
        {
            Filter filter = new Filter();
            cm.Bf.NewFilter(filter);
        }

        /// <summary>
        /// fill filter with a type to make the liquid
        /// </summary>
        /// <param name="types"></param>
        public void FillFilterWith(TypesOfLiquid types)
        {
            cm.Bf.Filter.PrepareBrewInFilter(types);
        }
    }
}
