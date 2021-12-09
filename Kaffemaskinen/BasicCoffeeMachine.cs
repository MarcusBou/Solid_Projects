using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public class BasicCoffeeMachine: Machine
    {
        private WaterContainer wc;
        private BrewFunnel bf;
        private BrewPot bp;
        public WaterContainer Wc { get { return wc; } }
        public BrewFunnel Bf { get { return bf; } }
        public BrewPot Bp { get { return bp;} }

        public BasicCoffeeMachine(int SizeOfTank) : base()
        {
            wc = new WaterContainer(SizeOfTank);
            bf = new BrewFunnel(SizeOfTank);
            bp = new BrewPot(SizeOfTank);
        }

        public void RunCycle()
        {
            wc.TransferToNextContainer(bf, wc.Filled, TypesOfLiquid.Water);
            if (bf.Filter != null)
            {
                bf.TransferToNextContainer(Bp, bf.Filled, bf.Filter.TypeForBrew);
            }
            else
            {
                bf.TransferToNextContainer(Bp, bf.Filled, TypesOfLiquid.Water);
            }
        }

        public void ChageBrewingPot(BrewPot container)
        {
            bp = container;
        }
    }
}
