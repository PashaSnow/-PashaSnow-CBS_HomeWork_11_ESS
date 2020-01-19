using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class ArrayList
    {
        private object[] array;

        public ArrayList()
        {
            this.array = new object[0];
        }

        public void Add(object item)
        {
            object[] bufArray = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                bufArray[i] = array[i];
            }
            bufArray[array.Length] = item;
            array = bufArray;
        }

        public object this[int index]
        {
            get
            {
                if (index >= 0 && array.Length > index)
                {
                    return array[index];
                }
                // відтіняємо помилку
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет такого индекса");
                Console.ResetColor();
                return null;
            }
        }

        public int Count
        {
            get { return array.Length; }
        }
    }
}
