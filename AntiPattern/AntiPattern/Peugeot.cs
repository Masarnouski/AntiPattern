using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    class Peugeot: IVehicle
    {
        public string model;
        public int dateOfManufacture;
        public int amountOfWheels = 4;
        public int gas;
        public int consumption;
        public int gasTankCapacity;
        public int mileage;

        public Peugeot()
        {
            consumption = 8;
            gasTankCapacity = 40;
            this.model = "406";
            this.dateOfManufacture = 2018;
        }

        public void CountMileage (int distance)
        {
            mileage += distance;
        }

        public void Save() { }
        public void Delete() { }

        public void Dig()
        {}

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
                gas = gasTankCapacity;
            else 
                gas += number;
        }
    }
}
