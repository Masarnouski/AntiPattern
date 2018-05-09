using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    class Audi:IVehicle
    {
        public string model;
        public int dateOfManufacture;
        public Audi()
        {
            this.model = "a5";
            this.dateOfManufacture = 2017;
        }

        public void Dig()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void FuelUp()
        {
            throw new NotImplementedException();
        }
    }
}
