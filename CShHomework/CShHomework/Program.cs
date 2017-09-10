using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShHomework
{
    class Program
    {
        private static void NaDuze()
        {
            string tekst = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

            Console.WriteLine("Oryginalny tekst:");
            Console.WriteLine(tekst + "\n\r");

            string[] slowa = tekst.Split(' ');

            Console.WriteLine("Tekst po zamianie liter na wielkie w słowach z parzystą liczbą liter:");

            for (int i = 0; i < slowa.Length; i++)
            {
                if ((slowa[i].Length % 2 == 0) && (slowa[i].IndexOfAny(new char[] { ',', '.' }) == -1))
                {
                    slowa[i] = slowa[i].ToUpper();
                }
                else if (slowa[i].IndexOfAny(new char[] { ',', '.' }) != -1)
                {
                    slowa[i] = slowa[i].ToUpper();
                }
                Console.Write(slowa[i]);
                if (i < slowa.Length - 1) Console.Write(" ");
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            NaDuze();
        }
    }
}
