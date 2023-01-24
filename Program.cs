using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._19_Diziler
{
    class Program
    {
        static void Main(string[] args)
        //diziler temel veri yapısıdır. sabit boyutludur.
        //diziler "[]" ile ifade edilir. diziler tek boyutlu olduğu gibi çok boyutlu da olabilir.
        {
            //int[]numaralar = new int[3];
            //numaralar[0] = 3;
            //numaralar[1] = 5;
            //numaralar[2] = 7;

            int[] numaralar = new int[3] { 3, 5, 7 };
            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine(numaralar[i]);
            }

            Console.ReadKey();
        }
    }
}
