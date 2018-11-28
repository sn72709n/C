using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oratesttomegbolv2
{
    class Program
    {
        static void Main(string[] args)
        {    
            try
            {
                StreamReader adatok = new StreamReader("tti.txt", Encoding.Default); 

                FileInfo fi = new FileInfo("tti.txt");
                string[] nev = new string[fi.Length];
                int db = 0;
                double[] tti=new double[fi.Length];
                int[] magassag = new int[fi.Length];
                //double[] magassag =
                double[] tomeg = new double[fi.Length];
                double[] tomb = new double[fi.Length];
                double[] sovany= new double[fi.Length];
                double[] normal = new double[fi.Length];
                double[] elhizott = new double[fi.Length];

              
                
                while (!adatok.EndOfStream)
                {
                    string beolvas = adatok.ReadLine();
                    string[] tab = beolvas.Split('\t');
                    nev[db] = tab[0];
                    magassag[db] = Convert.ToInt32(tab[1]);
                    tomeg[db] = Convert.ToInt32(tab[2]);
                    db++;
                }
                adatok.Close();
                var lineCount = File.ReadLines("tti.txt").Count();
                
                Console.WriteLine("\nennyi sor van: {0}", lineCount);
             

                for (int i = 0; i < lineCount; i++)
                {
                   
                    tti[i] = tomeg[i] / ((magassag[i])*(magassag[i]));
                    
                    
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", nev[i], magassag[i], tomeg[i],tti[i]*10000);
                   
                }
                int a = 0;
                for (int i = 0; i < lineCount; i++)
                { 
                   
                if(tti[i]*10000<18)

                {
                     sovany[a++] = tti[i];
                }
                }                
                Console.WriteLine("soványok száma:{0}", a);
                int b = 0;
                int c = 0;
                for (int i = 0; i < lineCount; i++)
                {

                    if (tti[i] * 10000 < 25)
                    {
                        normal[b++] = tti[i];
                    }
                    else if (tti[i] * 10000 > 25)
                    {
                        elhizott[c++] = tti[i];
                    }
                }
                Console.WriteLine("normális (darab):{0}", b);
                Console.WriteLine("elhízott (darab:{0})",c);


                int max;
          //      int n = 37;  //Az n a tömb mérete
              //  int max;

                //Maximum kiválasztás tétele
                max = magassag[0];
                for (int i = 0; i < lineCount; i++)
                    if (magassag[i] > max)
                        max = magassag[i];



                //Kiíratás rendezés előtt
                for (int i = 0; i < lineCount; i++)
                    Console.Write("{0} ", magassag[i]);
                Console.WriteLine();

                //Buborék rendezés
                for (int i = lineCount - 1; i > 0; i--)
                    for (int j = 0; j < i; j++)
                        if (magassag[j] > magassag[j + 1])
                        {
                            int tmp = magassag[j + 1];
                            magassag[j + 1] = magassag[j];
                            magassag[j] = tmp;
                        }

                //Kiíratás rendezés után
              //  for (int i = 0; i < lineCount; i++)
                //    Console.Write("{0} ", magassag[i]);


                  
               
                //onsole.WriteLine();





                    Console.WriteLine("a legnyagyobb elemhez tartozó index: {0}", lineCount);
                Console.WriteLine("A legmagasabb: {0}",max);
                Console.WriteLine(nev[37]);









                    Console.ReadKey();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
 