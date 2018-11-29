using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 1, b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.Write("Adja meg N értékét: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Az első {0} Fibonacci szám: ", n);
            for (int i = 0; i < n; i++) Console.Write(Fibonacci(i) + " "); // ha a függvény nem statikus, akkor így hívjuk meg (származtatjuk): new Program().Fibonacci(i)
            Console.ReadKey();
        }
    }
}
