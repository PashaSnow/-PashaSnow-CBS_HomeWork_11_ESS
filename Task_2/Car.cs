using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Car : ICar
    {
        public Car(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "bmw x5";
            }
            this.name = name;
            creationDate = DateTime.Now;
        }

        public Car():this(null)
        { }

        string name;
        DateTime creationDate;

        public string Name { get { return name; } }
        public DateTime CreatorDate { get; }

    }
}
