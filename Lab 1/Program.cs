using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {


        public static int Input(string[] args, int i)
        {
            int a;
            try
            {
                if (args.Length != 3)
                    a = Convert.ToInt32(Console.ReadLine());
                else
                {
                    a = Convert.ToInt32(args[i]);

                }
            }
            catch
            {
                Console.WriteLine("Введите число заново ");
                a = Input(args, i);
            }
            return a;
        }
        public static void Solution(string[] args)
        {
            double a, b, c, D, x1, x2;
            Console.WriteLine("Введите коэффиценты квадратного уравнения a,b,c");

            Console.WriteLine("Введите a: ");
            a = Input(args, 0);

            Console.WriteLine("Введите b: ");
            b = Input(args, 1);

            Console.WriteLine("Введите c: ");
            c = Input(args, 2);

            D = Math.Pow(b, 2) - 4 * a * c;
            Console.Write("D = ");
            Console.WriteLine(D);

            if (a == 0)
            {
                x1 = -1 * c / b;
                Console.WriteLine("x = {0}", x1);
                Console.ReadKey();
            }

          
            else if (D > 0 || D == 0)
            {
                x1 = (-1*b + Math.Sqrt(D)) / (2 * a);
                x2 = (-1*b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("У уравнения нет корней");
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            Solution(args);
        }


    }
}
