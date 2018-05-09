using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    class CarManager
    {
        public List<object> CarList;

        public CarManager()
        {
            CarList = new List<object>();
        }
        //Breaking Dependency Inversion Principle Tight coupling code
        public void AddAudi()
        {
            Audi audi = new Audi();
            CarList.Add(audi);
        }
        //Breaking Dependency Inversion Principle Tight coupling code
        public void AddPeugeot()
        {
            Peugeot peugeot = new Peugeot();
            CarList.Add(peugeot);
        }
    }
}
