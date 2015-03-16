using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses1
{
    class DefClasses
    {
        static void Main(string[] args)
        {
            ClassGSM firstGSM = new ClassGSM();
            firstGSM.Model = "Nokia";
            firstGSM.Manufacturer = "Germany";

            Console.WriteLine("{0} made in {1}!", firstGSM.Model, firstGSM.Manufacturer);

            ClassGSM probenGSM = new ClassGSM(new Battery(BatteryType.NiCd, "Alcatel"));
            Console.WriteLine(probenGSM.ToString());

            ClassGSM secondGSM = new ClassGSM();
            secondGSM.Battery.TypeBattery = BatteryType.Li_Ion;
            Console.WriteLine(secondGSM.Battery.TypeBattery);

        }
    }
}
