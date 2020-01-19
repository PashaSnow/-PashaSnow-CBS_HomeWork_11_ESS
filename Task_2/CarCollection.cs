using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class CarCollection<T> : ICarCollection<T> where T : Car, new()
    {
        Car[] carParking = new Car[0];

        public string this[int index]
        {
            get
            {
                if (index < this.carParking.Length)
                    return $"{this.carParking[index].Name} + {this.carParking[index].CreatorDate} craft year";

                return "На парковке нет такого автомобиля";
            }
        }

        public void Add(T newCar)
        {
            Car[] bufCarParking = new Car[carParking.Length + 1];
            for (int i = 0; i < bufCarParking.Length; i++)
            {
                if (this.carParking.Length > i)
                {
                    bufCarParking[i] = carParking[i];
                    continue;
                }
                bufCarParking[i] = newCar;
            }
            this.carParking = bufCarParking;
        }

        public int Count
        {
            get { return carParking.Length; }
        }
    }
}
