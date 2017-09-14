using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShHomework
{
    class MoreThanFiftyCharsException : Exception
    {
        public MoreThanFiftyCharsException() : base() { }

        public MoreThanFiftyCharsException(string message) : base(message) { }

        public MoreThanFiftyCharsException(string format, params object[] args) : base(string.Format(format, args)) { }

        public MoreThanFiftyCharsException(string message, Exception innerException) : base(message, innerException) { }
    }

    class Program
    {
        public static void LapWyjatek()
        {
            string tekst = "";

            Console.Write("Wpisz tekst: ");

            try
            {
                tekst = Console.ReadLine();
                if (tekst.Length > 50) throw new MoreThanFiftyCharsException("Za długi ciąg wejściowwy");
            }
            catch (MoreThanFiftyCharsException ex)
            {
                Console.WriteLine("Wyłapano wyjątek: " + ex.Message + ". Tekst został skrócony do 50 znaków.");
                tekst = tekst.Substring(0, 50);
            }

            Console.WriteLine(tekst);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            LapWyjatek();
        }
    }
}
