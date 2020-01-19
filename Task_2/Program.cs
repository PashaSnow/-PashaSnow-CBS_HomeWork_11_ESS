using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин. 
 * Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года ее выпуска, индексатор для получения значения элемента по указанному индексу и свойство только для чтения для получения общего количества элементов.  
 * Создайте метод удаления всех машин автопарка. 
*/

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car fotin = new Car("audi q5");
            Car bauman = new Car("audi q5");
            Car klyev = new Car("smart");
            Car taras = new Car("renault duster");

            CarCollection<Car> parking = new CarCollection<Car>();
            parking.Add(fotin);
            parking.Add(bauman);
            parking.Add(klyev);
            parking.Add(taras);

            Console.WriteLine("Count  = {0}", parking.Count);
            for (int i = 0; i < parking.Count; i++)
            {
                Console.WriteLine("Number om parking №{0}, auto {1} - {3}", i, parking[i]);
            }
        }
    }
}
