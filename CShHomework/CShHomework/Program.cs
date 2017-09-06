using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Ankietor ankietor = new Ankietor();
            ankietor.Run();

            Console.WriteLine("Koniec ankiety. Naciśnij klawisz...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Podaj nazwę nowej ankiety:");
            Ankietor ankietor2 = new Ankietor(Console.ReadLine());
            ankietor2.Run();

            Console.WriteLine("Koniec programu. Naciśnij klawisz...");
            Console.ReadKey();
        }
    }
}
