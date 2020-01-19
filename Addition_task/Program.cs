using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*В коллекцию  ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись? */

namespace Addition_task
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList x = new ArrayList();

            double[] y = new double[2];
            x.Add(3.15);
            x.Add(null);
            //x.Sort();
            for (int i = 0; i < x.Count; i++)
            {
                Console.WriteLine(x[i]);
                if (!Equals(x[i], (object)3.15))
                {
                    y[i] = (double)x[i];
                }
                Console.WriteLine(y[i]);
            }
        }
    }
}
