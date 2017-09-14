using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShHomework
{
    interface IOsoba
    {
        string Nazwa { get; }
        void Opisz();
    }

    class Student : IOsoba
    {
        private string nazwa;
        public string Nazwa { get { return nazwa; } }

        public Student()
        {
            nazwa = "Nieznany student";
        }

        public Student(string nazwa)
        {
            this.nazwa = nazwa;
        }
        
        public void Opisz()
        {
            Console.WriteLine("Student: " + nazwa);
        }
    }

    public class StudentSort : IComparer
    {
        int IComparer.Compare(Object x, Object y)
        {
            Student s1 = x as Student;
            Student s2 = y as Student;
            return ((new CaseInsensitiveComparer()).Compare(s1.Nazwa, s2.Nazwa));
        }
    }

    class Program
    {
        public static void SortowanieStudentow()
        {
            ArrayList studenty = new ArrayList();
            studenty.Add(new Student());
            studenty.Add(new Student("Mariusz Murawski"));
            studenty.Add(new Student("Igrek Iksiński"));
            studenty.Add(new Student("Iks Igrekowski"));

            Console.WriteLine("Lista przed sortowaniem: ");
            foreach (Student s in studenty)
            {
                s.Opisz();
            }

            studenty.Sort(new StudentSort());

            Console.WriteLine("\n\rLista po sortowaniu:");
            foreach (Student s in studenty)
            {
                s.Opisz();
            }

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            SortowanieStudentow();
        }
    }
}
