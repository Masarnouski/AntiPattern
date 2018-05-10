using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    class Audi: IVehicle
    {
        public string model;
        public int dateOfManufacture;
        public int AmountOfWheels = 4;
        public int gas;
        public int consumption;
        public int gasTankCapacity;
        public int mileage;

        public Audi()
        {
            this.model = "a5";
            this.dateOfManufacture = 2017;
            gasTankCapacity = 50;
            consumption = 8;
        }

        public void CountMileage(int distance)
        {
            mileage += distance;
        }

        public void Save() { }
        public void Load() { }

        public void Dig()
        { }

        public void Drive(int distance)
        {
            int temp = distance / 100 * consumption;
            if ((gas -= temp) < 0)
            {
                gas = 0;
            }
            else
            {
                gas -= temp;
            }
            CountMileage(distance);
        }

        public void FuelUp(int number)
        {
            if ((gas += number) > gasTankCapacity)
            {
                gas = gasTankCapacity;
            }
            else
            {
                gas += number;
            }
        }
    }
}
