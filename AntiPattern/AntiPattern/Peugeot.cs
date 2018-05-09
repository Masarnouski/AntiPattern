using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    class Peugeot:IVehicle
    {
        public string model;
        public int dateOfManufacture;
        public int gas;
        public Peugeot()
        {
            this.model = "406";
            this.dateOfManufacture = 2018;
        }
        public void Drive() { }
        public void FuelUp() { }

        //Break srp principle(must be on the DAL layer)
        public void Save() { }
        public void Delete() { }

        public void Dig()
        {
            throw new NotImplementedException();
        }
    }
}
