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

        public Excavator()
        {
            this.model = "JCB";
            this.dateOfManufacture = 2005;
        }

        public void Dig()
        {}

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
