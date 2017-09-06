using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShHomework
{
    class Ankietor
    {
        // POLA
        private string surveyName;
        private int allQuestions;
        private int questionsToAsk;
        private string[] questions = { "Jaki jest Twój ulubiony system operacyjny lub dystrybucja?",
                                     "Jaki jest Twoj ulubiony język programowania/skryptowy/znaczników?",
                                     "Jak nazywa się Twoje ulubione środowisko programistyczne?",
                                     "Jak oceniasz swoje umiejętności programowania w C# w skali 1-5?",
                                     "Jaki nowy język programowania chciałbyś poznać?" };
        private string[] answers;
        private int[] questionsOrder;
        private Random rand = new Random();

        // METODY
        public Ankietor(int allQuestions = 5, int questions = 3)
        {
            surveyName = null;
            this.allQuestions = allQuestions;
            questionsToAsk = questions;
            answers = new string[questions];
            questionsOrder = new int[allQuestions];
            setQuestionsOrder();
        }

        public Ankietor(string surveyName, int allQuestions = 5, int questions = 3)
        {
            this.surveyName = surveyName;
            this.allQuestions = allQuestions;
            questionsToAsk = questions;
            answers = new string[questions];
            questionsOrder = new int[allQuestions];
            setQuestionsOrder();
        }

        private void setQuestionsOrder()
        {
            for (int i = 0; i < allQuestions; i++)
            {
                questionsOrder[i] = i;
            }
        }

        public void Run()
        {
            bool finish = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Ankieta będzie składała się z " + questionsToAsk + " pytań.");

                randomQuestionsOrder();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Pytanie " + (i + 1));
                    Console.WriteLine(questions[questionsOrder[i]]);
                    string answer = Console.ReadLine();
                    answers[i] = questions[questionsOrder[i]] + ":" + answer;
                }

                char ans;
                do
                {
                    Console.WriteLine("Czy chcesz wypełnić ponownie ankietę z innym zestawem pytań? Jeśli tak (klawisz [t]), wyniki obecnej zostaną skasowane. Odpowiedź [n] wyświetli Twoje ostatnie odpowiedzi. Wciśnij klawisz [t/n] lub [T/N]");
                    ans = Console.ReadKey().KeyChar;
                    Console.WriteLine("\n\r");
                }
                while (ans != 't' && ans != 'n' && ans != 'T' && ans != 'N');

                if (ans == 'n' || ans == 'N') finish = true;
            }
            while (!finish);

            if (surveyName == null)
            {
                Console.WriteLine("Wyniki ankiety.");
            }
            else
            {
                Console.WriteLine("Wyniki ankiety o nazwie: " + surveyName + ".");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Pytanie " + (i + 1));
                Console.WriteLine(answers[i].Substring(0, answers[i].IndexOf(":")));
                Console.WriteLine(answers[i].Substring(answers[i].IndexOf(":") + 1, answers[i].Length - answers[i].IndexOf(":") - 1));
            }
        }

        public void randomQuestionsOrder()
        {
            for(int i = 0; i < questionsToAsk; i++)
            {
                int hlp = rand.Next(i, allQuestions); // nr indeksu
                int temp = questionsOrder[i];
                questionsOrder[i] = questionsOrder[hlp];
                questionsOrder[hlp] = temp;
            }

            /*for (int i = 0; i < allQuestions; i++)
            {
                Console.Write(questionsOrder[i] + " ");
            }*/
        }
    }
}
