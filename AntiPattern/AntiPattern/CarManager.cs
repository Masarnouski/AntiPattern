﻿using System;
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
            if (!(CarList.Contains(audi)))
            {
                CarList.Add(audi);
                logger.Log($"Car {audi.model} have added");
            }
            else
            {
                throw new Exception($"{nameof(audi)} already exists");
            }
            
        }
     
        public void AddPeugeot(Peugeot peugeot)
        {
            if (!(CarList.Contains(peugeot)))
            {
                CarList.Add(peugeot);
                logger.Log($"Car {peugeot.model} have added");
            }
            else
            {
                throw new Exception($"{nameof(peugeot)} already exists");
            }
        }
    }
}
