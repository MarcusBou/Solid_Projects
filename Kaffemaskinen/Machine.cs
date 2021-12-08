using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public class Machine
    {
        private List<Container> containers;
        private bool powerstate = false;
        public List<Container> Containers { get { return containers; } }
        public Machine(Container[] con)
        {
            for (int i = 0; i < con.Length; i++)
            {
                containers.Add(con[i]);
            }
        }
        public void ChangePowestate(bool newPowerState)
        {
            powerstate = newPowerState;
        }
    }
}
