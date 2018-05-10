using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Audi audi = new Audi();
            Peugeot peugeot = new Peugeot();
            MotorCycle mCycle = new MotorCycle();
            CarManager carmanager = new CarManager();
            carmanager.AddAudi(audi);
            carmanager.AddPeugeot(peugeot);
            carmanager.AddPeugeot(mCycle);
            Peugeot peugeot1 = new MotorCycle();
            Console.WriteLine(peugeot1.amountOfWheels);
            Console.ReadLine();

            peugeot.FuelUp(30);
            peugeot.Drive(100);
            peugeot.Save();
            Console.ReadLine();
        }
    }
}
