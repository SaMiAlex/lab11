using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{

    class Program
    {
        static void Main(string[] args)
        {
            LinUr linur = new LinUr();
            linur.SetParams();
            linur.Root();
            Console.ReadKey();
        }
    }
    struct LinUr
    {
        public double k;
        public double b;
        public double x;

        public LinUr(int K, int B, int X)
        {
            k = K;
            b = B;
            x = X;
        }

        public void SetParams()
        {
            try
            {
                Console.WriteLine("Введите k");
                k = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите b");
                b = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Root()
        {
            try
            {
                x = -b / k;
                Console.WriteLine("При решении линейного уравнения 0=kx+b с заданными коэффициентами x равно {0:f2}", x);
            }
            catch (DivideByZeroException ex) //не могу понять почему не отлавливается исключение для вещественных чисел. С int все срабатывает
            {
                Console.WriteLine(ex.Message);
            }
            
        }



    }
}
