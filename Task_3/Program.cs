using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создайте класс Dictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен System.Collections.Generic. 
 *Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, индексатор для получения значения элемента по указанному индексу и свойство 
 *только для чтения элемента по указанному индексу и свойство только для получения общего количества пар элементов.  
 */
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("car", "автомобиль");
            dic.Add("city", "город");
            dic.Add("work", "работа");

            for (int i = 0; i < dic.Count; i++)
            {
                Console.WriteLine($"Index{i}: {dic[i]}");
            }

            Console.WriteLine(new string('-', 16));
            Console.WriteLine(dic.ToString());
        }
    }
}
