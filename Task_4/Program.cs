using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте класс ArrayList. 
 * Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections. */
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList x = new ArrayList();
            x.Add(1626);
            x.Add("string");
            x.Add('x');
            x.Add(75.0d);

            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine($"x[{i}] = {x[i]}");
            }
            Console.WriteLine(new string('-', 27));
            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine($"x[{i}] type = {x[i].GetType()}");
            }
        }
    }
}
