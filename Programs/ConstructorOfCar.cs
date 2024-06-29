using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPrograms
{
    public class ConstructorOfCar
    {
        bool canFly ;
        bool canRide ;
        bool canDrive;
        string color;

        public ConstructorOfCar()
        {
            canFly = false;
            canRide = false;
            canDrive = true;
            color = "red";
        }
        public ConstructorOfCar(string _color)
        {
            canFly = false;
            canRide = false;
            canDrive = true;
            color = _color;
        }

        public void drive()
        {
            if(canDrive)
            Console.WriteLine("car is driving");
        }
        public void whatsTheColor()
        {
           Console.WriteLine("color of the car is" + color);
        }

    }
}
