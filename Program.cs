using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class Program
    {
        public static double Maximum(double[] tomb)
        {
            double max = tomb[0];
            for (int i = 0; i < tomb.Length; i++) if (tomb[i] > max) max = tomb[i];
            return max;
        }
        public static double Minimum(double[] tomb)
        {
            double min = tomb[0];
            for (int i = 0; i < tomb.Length; i++) if (tomb[i] < min) min = tomb[i];
            return min;
        }
        public static double Atlag(double[] tomb)
        {
            double osszeg = 0;
            for (int i = 0; i < tomb.Length; i++) osszeg += tomb[i];
            return osszeg / tomb.Length;
        }
        static void Main(string[] args)
        {
            int N = 10;
            double[] HOMERSEKLET = new double[N];
            Random R = new Random();
            for (int i = 0; i < HOMERSEKLET.Length; i++)
            {
                HOMERSEKLET[i] = R.Next(-20, 20);
                Console.Write(HOMERSEKLET[i] + " ");
            }
            int HIGHDB = 0, LOWDB = 0;
            double[] HIGH = new double[N];
            double[] LOW = new double[N];
            for (int i = 0; i < HOMERSEKLET.Length; i++)
            {
                if (HOMERSEKLET[i] > 0)
                {
                    HIGHDB++;
                    HIGH[HIGHDB] = HOMERSEKLET[i];
                }
                else if (HOMERSEKLET[i] < 0)
                {
                    LOWDB++;
                    LOW[LOWDB] = HOMERSEKLET[i];
                }
            }
            Console.WriteLine("\n");
            for (int i = 1; i <= HIGHDB; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(HIGH[i] + " ");
            }
            Console.WriteLine("\n");
            for (int i = 1; i <= LOWDB; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(LOW[i] + " ");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\nA legnagyobb hőmérséklet: {0} °C", Maximum(HOMERSEKLET));
            Console.WriteLine("\nA legksiebb hőmérséklet: {0} °C", Minimum(HOMERSEKLET));
            Console.WriteLine("\nAz átlaghőmérséklet: {0:0.000} °C", Atlag(HOMERSEKLET));
            Console.ReadKey();
        }
    }
}
