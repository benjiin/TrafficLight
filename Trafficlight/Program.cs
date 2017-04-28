using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafficlight
{
    class Program
    {
        static void Main(string[] args)
        {

            Crossroads crossroads = new Crossroads();
            if (crossroads.SignalN.Color == Signal.GREEN)
            {
                Console.WriteLine("N: Green");
            }
            else if (crossroads.SignalN.Color == Signal.RED)
            {
                Console.WriteLine("N: Red");
            }
            if (crossroads.SignalS.Color == Signal.GREEN)
            {
                Console.WriteLine("S: Green");
            }
            else if (crossroads.SignalS.Color == Signal.RED)
            {
                Console.WriteLine("S: Red");
            }

            if (crossroads.SignalW.Color == Signal.GREEN)
            {
                Console.WriteLine("W: Green");
            }
            else if (crossroads.SignalW.Color == Signal.RED)
            {
                Console.WriteLine("W: Red");
            }

            if (crossroads.SignalO.Color == Signal.GREEN)
            {
                Console.WriteLine("O: Green");
            }
            else if (crossroads.SignalO.Color == Signal.RED)
            {
                Console.WriteLine("O: Red");
            }

            crossroads.Switch();
            Console.WriteLine("-");

            if (crossroads.SignalN.Color == Signal.GREEN)
            {
                Console.WriteLine("N: Green");
            }
            else if (crossroads.SignalN.Color == Signal.RED)
            {
                Console.WriteLine("N: Red");
            }
            if (crossroads.SignalS.Color == Signal.GREEN)
            {
                Console.WriteLine("S: Green");
            }
            else if (crossroads.SignalS.Color == Signal.RED)
            {
                Console.WriteLine("S: Red");
            }

            if (crossroads.SignalW.Color == Signal.GREEN)
            {
                Console.WriteLine("W: Green");
            }
            else if (crossroads.SignalW.Color == Signal.RED)
            {
                Console.WriteLine("W: Red");
            }

            if (crossroads.SignalO.Color == Signal.GREEN)
            {
                Console.WriteLine("O: Green");
            }
            else if (crossroads.SignalO.Color == Signal.RED)
            {
                Console.WriteLine("O: Red");
            }
            Console.ReadLine();
        }
    }
}
