using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    class CarManager
    {
        FileLogger logger;
        public List<object> CarList;

        public CarManager()
        {
            logger = new FileLogger();
            CarList = new List<object>();
        }
        
        public void AddAudi(Audi audi)
        {
            CarList.Add(audi);
        }
     
        public void AddPeugeot(Peugeot peugeot)
        {
            CarList.Add(peugeot);
        }
    }
}
