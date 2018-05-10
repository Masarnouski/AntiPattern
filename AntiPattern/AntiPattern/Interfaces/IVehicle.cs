using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    interface IVehicle
    {
        void Drive(int distance);
        void FuelUp(int number);
        void Dig();
    }
}
