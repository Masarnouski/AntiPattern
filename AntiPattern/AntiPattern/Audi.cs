using System;
using System.Collections.Generic;
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

        public Audi()
        {
            this.model = "a5";
            this.dateOfManufacture = 2017;
        }

        public void CountMileage() { }

        public void Save() { }
        public void Delete() { }

        public void Dig()
        { }

        public void Drive()
        {
            gas--;
        }

        public void FuelUp()
        {
            gas++;
        }
    }
}
