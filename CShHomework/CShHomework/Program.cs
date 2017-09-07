using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShHomework
{
    class Program
    {
        public static void sumaLosowych()
        {
            int[] tablicaStartowa = new int[1000];
            int[] tablica = new int[50];
            Random los = new Random();
            int suma = 0;

            for (int i = 0; i < 1000; i++)
            {
                tablicaStartowa[i] = los.Next(0, 1001);
            }

            for (int i = 0; i < 50; i++)
            {
                tablica[i] = tablicaStartowa[los.Next(0, 999)];
                if (tablica[i] % 2 == 0) suma += tablica[i];
            }

            Console.WriteLine("Suma wylosowanych liczb to " + suma);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            sumaLosowych();
        }
    }
}
