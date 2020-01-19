using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    interface ICarCollection<T> where T : Car, new()
    {
        void Add(T car);
        int Count { get; }
        string this[int index] { get; }
        
    }
}
