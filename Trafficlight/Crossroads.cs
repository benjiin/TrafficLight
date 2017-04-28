using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafficlight
{
    class Crossroads
    {
        Signal SignalN = new Signal();
        Signal SignalS = new Signal();
        Signal SignalW = new Signal();
        Signal SignalO = new Signal();

        public Crossroads()
        {

        }
        public void Switch()
        {
            Console.WriteLine("wsw");
        }
    }
}
