using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    class Excavator : IVehicle
    {
        public string model;
        public int dateOfManufacture;
        public int AmountOfWheels = 4;
        public int gas;
        public int consumption;
        public int gasTankCapacity;

        public Excavator()
        {
            this.model = "JCB";
            this.dateOfManufacture = 2005;
            consumption = 16;
            gasTankCapacity = 60;
        }

        public void Dig()
        {
        }

        public void Drive(int distance)
        {

            int temp = distance / 100 * consumption;
            if ((gas -= temp) < 0)
                gas = 0;
            else
                gas -= temp;
        }

        public void FuelUp(int number)
        {
            if ((gas += number) > gasTankCapacity)
                gas = gasTankCapacity;
            else
                gas += number;
        }
    }
}
