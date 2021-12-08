using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public class CoffeMachine_Manager
    {
        Machine cm;
        private static Container bp = new BrewPot(100);
        private static Container bf = new BrewFunnel(100);
        private static Container wc = new WaterContainer(100);
        Container[] Containers = { wc, bf, bp};
        public CoffeMachine_Manager()
        {
            cm = new Machine(Containers);
        }

        public void TurnOnMachine()
        {
            cm.ChangePowestate(true);
        }

        public void TurnOffMachine()
        {
            cm.ChangePowestate(false);
        }

        
    
    }
}
