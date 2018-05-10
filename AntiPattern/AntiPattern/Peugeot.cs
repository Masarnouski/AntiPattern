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
        public int amountOfWheels=4;
        public int gas;

        public Peugeot()
        {
            this.model = "406";
            this.dateOfManufacture = 2018;
        }

        public void CountMileage() { }

        public void Save() { }
        public void Delete() { }

        public void Dig()
        {
        }

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
