using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiPattern
{
    class Peugeot: IVehicle
    {
        //hello
        //hello partial
        public string model;
        public int dateOfManufacture;
        public int amountOfWheels = 4;
        public int gas; // hello
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

        public void Save()
        {
            string path = "File.txt";
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (var writer = new BinaryWriter(stream))
                {
                        writer.Write(this.amountOfWheels);
                        writer.Write(this.consumption);
                        writer.Write(this.dateOfManufacture);
                        writer.Write(this.gas);
                        writer.Write(this.gasTankCapacity);
                        writer.Write(this.mileage);
                        writer.Write(this.model);

                        writer.Flush();
                }
            }
        }
        public List<Peugeot> Load()
        {
            string path = "File.txt";
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            using (var writer = new BinaryWriter(stream))
            {
                var reader = new BinaryReader(stream);
                List<Peugeot> peugeotList = new List<Peugeot>();
                while (reader.PeekChar() > -1)
                {
                    peugeotList.Add(
                     new Peugeot()
                     {
                         amountOfWheels = reader.ReadInt32(),
                         consumption = reader.ReadInt32(),
                         dateOfManufacture = reader.ReadInt32(),
                         gas = reader.ReadInt32(),
                         gasTankCapacity = reader.ReadInt32(),
                         mileage = reader.ReadInt32(),
                         model = reader.ReadString(),
                     });
                }
                return peugeotList;
            }
        }

        public void Dig()
        {}

        public void Drive(int distance)
        {
            int temp = distance / 100 * consumption;
            if ((gas - temp) < 0)
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
            if ((gas + number) > gasTankCapacity)
                gas = gasTankCapacity;
            else 
                gas += number;
        }
    }
}
