using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms.Programs.Inheritance
{
    public class Vehicles
    {
        public Vehicles()
        {

        }

        public void start()
        {
            Console.WriteLine("this vehicle can start.");
        }

        public void StartAtSpeed(int speed)
        {
            Console.WriteLine("this vehicle can run at speed." + speed);
        }

    }
}
