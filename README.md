# CShHomework
Zadanie domowe do kursu ".NET od podstaw" - blok: "Programowanie w C#". Poniżej znajdują się treści zadań, do których należało napisać program w C# oraz opublikować go na Githubie. Każde rozwiązanie zadania to osobna gałąź.
__________________________________________________________________________________________________________________________________________
Branch - Ankietor:
Program do przeprowadzania ankiet. W puli jest 5 pytań, z tych 5 trzeba wylosować 3, które zostaną zadane użytkownikowi. Odpowiedzi muszą zostać zapisane w tablicy. Format zapisu pytania i odpowiedzi w tablicy to [pytanie:odpowiedź].

string[] tablica = new string[5]; tablica[0] = "Czy lubisz czerwony kolor?:TAK"

//wskazówka string ma metoda Split().

Kiedy użytkownik skończy zadajemy mu pytanie czy chce wypełnić następną ankiete, jeśli nie to wyświetlamy odpowiedzi z ankiety, jeżeli tak do losujemy nowe pytanie i przeprowadzamy procedure pytań i odpowiedzi jeszcze raz.

Metody i pola powinny zostać zamknięte w klasie. Klasa w której bedą wasze metody i pola, powinna zawierać domyślny kostruktor i przeciążony konstruktor, Przeciążony konstrukor będzie zawierał parametr dzięki któremu będziemy mogli ustawić tytuł ankiety. Parameter musi być opcjonalny.

W głównej metodzie Main, powinień tylko zostać utworzony obiekt + metoda, która uruchomii całą procedure.

Ankietor ankietor = new Ankietor(); ankietor.Run();
__________________________________________________________________________________________________________________________________________
Branch - SumaLosowych:
Wypełnijcie tablice randomowymi liczbami (1000sztuk) a następnie wylosujcie 50 z nich i zapiszcie do drugiej tablicy. Z tej drugiej tablicy wyszukajcie liczby parzyste i dodajcie je do siebie. Na końcu program powinien pokazać sumę tych znalezionych liczb.
__________________________________________________________________________________________________________________________________________
Branch - NaDuze:
Macie dużą ilość tekstu dostarczoną w jednej zmiennej (zapiszcie sobie jakies "Lorem impsum" do zmiennej string). Proszę podzielić ten string tak zeby kazde słowo było oddzielnie zapisane w tablicy (metoda Split). sprawdzić potem tablice które słowo zawiera parzystą liczbe liter i zamienic litery na duże (metoda ToUpper()). Na końcu wyswietlic cała tablice.
__________________________________________________________________________________________________________________________________________
Branch - Wyjatek:
Użytkownik wprowadza jakiś tekst do zmiennej. Jeżeli wprowadzi więcej niż 50 znaków. wyrzucamy wyjątek. Następnie wyjątek musimy przejąć w catch i tak przyciąć tekst, żeby zajął tylko 50 znaków. Trzeba o tym fakcie tez poinformować użytkownika, że jego wiadomość został obcięta oraz wyświetlić ją na końcu. Wyjątek muście stworzyć sami. Oczywiście ma dziedziczyć po Exception.
