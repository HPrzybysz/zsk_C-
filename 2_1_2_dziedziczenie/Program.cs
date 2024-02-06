using System.Security.Cryptography.X509Certificates;
using _2_1_dziedziczenie.classes;

namespace _2_1_dziedziczenie
{
    internal class Program
    {

        public static List<Person> users = new List<Person>(); 


        static void Main(string[] args)
        {
            /*
            Person p1 = new Person("Janusz", "Nowak", new DateTime(1984, 1, 16), new Address("Poznań", "Polna", "1c/6", "23-983"));
            Console.WriteLine($"Imię: {p1.name} \n nazwisko: {p1.surname} \n data urodzenia: {p1.DateOfBirth.ToShortDateString}r. \n adres: {p1.Address.street} \n {p1.Address.houseNumber} \n {p1.Address.PostalCode} \n\n ");

            Student s1 = new Student("Janina", "Nowak", new DateTime(2000, 5, 12), new Address("Konin", "Staszica", "143C", "62-052"), "245");
            Console.WriteLine($"Imię: {s1.name} \n nazwisko: {s1.surname} \n data urodzenia: {s1.DateOfBirth} \n adres: {s1.Address.street} \n {s1.Address.houseNumber} \n {s1.Address.PostalCode} \n numer studenta: {s1.studentNumber} \n\n ");

            Teacher t1 = new Teacher("Mark", "Goodman", new DateTime(1939, 8, 20), new Address("Berlin", "Reichstrasse", "72a", "11-111"), new List<string>() { "Matematyka", "Informatyka", "Geografia" });
            Console.WriteLine($"Imię: {t1.name}");
            */

            int option = 0;

            while (option != 4)
            {
                option = DisplayMenu();

                switch (option)
                {
                    case 1:
                        AddUser();
                        break;
                    case 2:
                        DisplayUser();
                        break;
                    case 3:
                        users.Clear();
                        Console.WriteLine("\nWszyscy użytkownicy zostali usunieci!");
                        break;
                    case 4:
                        Console.WriteLine("\n\nKoniec programu\n\n");
                        break;
                    default:
                        Console.WriteLine("\nNieprawidłowa opcja!\n");
                        break;

                }
            }

            Console.ReadKey();
        }

        public static int DisplayMenu()
        {
            Console.WriteLine("Witaj w programie do zarządzania użytkownikami\n");
            Console.WriteLine("1. Dodaj użytkownika\n");
            Console.WriteLine("2. Wyświetl użytkowników\n");
            Console.WriteLine("3. Usuń wszystkich użytkowników\n");
            Console.WriteLine("4. Wyjdź z programu\n");

            Console.WriteLine("\nWybierz opcję: ");
            return int.Parse( Console.ReadLine() );
        }

        public static void AddUser()
        {
            Console.WriteLine("Podaj imie użytkownika: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nPodaj imie użytkownika: ");
            string surname = Console.ReadLine();
            Console.WriteLine("\nPodaj datę urodzenia (RRRR-MM-DD: ");
            DateTime DateOfBirth = DateTime.Parse(Console.ReadLine() );

            Person user = new Person(name, surname, DateOfBirth);
            users.Add(user);

            Console.WriteLine("\n {0} {1} został dodany.\n", name, surname);

        }

        public static void DisplayUser()
        {
            if(users.Count == 0){
                Console.WriteLine("Nie ma żadnych użytkowników");
            }else {
                Console.WriteLine("\n Lista użytkowników: \n");
                foreach(Person user in users)
                {
                    Console.WriteLine($"Imię i nazwisko {user.name} {user.surname}, data urodzenia: {user.DateOfBirth}\n");
                }
            };
        }




    }
}






/*
 
Dziedziczenie – zadanie 1
 Napisz program w języku C#, który ilustruje pojęcia programowania obiektowego,
takie jak klasy, dziedziczenie, właściwości i metody.
 Zdefiniuj klasę bazową Person, która ma pola name, surname i dateOfBirth oraz
konstruktor przyjmujący te wartości jako parametry.
 Dodaj do klasy Person metodę GetFullName, która zwraca pełne imię i nazwisko
osoby, oraz właściwość Age, która oblicza wiek osoby na podstawie daty urodzenia.
 Zdefiniuj klasę Address, która ma pola city, street, houseNumber i postalCode jako
właściwości oraz konstruktor przyjmujący te wartości jako parametry.
 Dodaj do klasy Person pole address typu Address i zmodyfikuj konstruktor klasy
Person, aby przyjmował obiekt klasy Address jako parametr.
 Zdefiniuj klasę pochodną Student, która dziedziczy po klasie Person i ma dodatkowe
pole studentNumber oraz konstruktor przyjmujący te wartości jako parametry.
 Zdefiniuj klasę pochodną Teacher, która dziedziczy po klasie Person i ma dodatkowe
pole subjects typu List<string> oraz konstruktor przyjmujący te wartości jako
parametry.
 Utwórz obiekty każdej klasy, używając słowa kluczowego new i podając odpowiednie
wartości w konstruktorach.
 Wyświetl dane utworzonych obiektów, używając metody Console.WriteLine i
właściwości obiektów.

 Wyświetl dane utworzonych obiektów, używając metody Console.WriteLine i
właściwości obiektów.
Menu:
 Aby dodać do zadania menu, które umożliwia dodawanie użytkowników i
zapamiętanie ich w pamięci, a następnie odczyt wprowadzonych użytkowników,
możesz użyć następujących kroków:
 Utwórz zmienną typu List<Person>, która będzie przechowywać listę użytkowników.
 Utwórz metodę DisplayMenu, która będzie wyświetlać opcje menu na konsoli i
zwracać wybraną opcję jako liczbę całkowitą. Utwórz metodę AddUser, która będzie pobierać dane użytkownika z konsoli i
dodawać je do listy użytkowników.
 Utwórz metodę DisplayUsers, która będzie wyświetlać dane użytkowników z listy na
konsoli.
 Utwórz metodę Main, która będzie używać pętli while do wyświetlania menu i
wykonywania odpowiednich akcji w zależności od wybranej opcji.*/

