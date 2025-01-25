using System;
using System.Collections.Generic;

class LibraryManagement
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }
    }

    static List<Book> library = new List<Book>();

    static void Main()
    {
        string option;
        do
        {
            Console.WriteLine("\nBibliotheksverwaltung");
            Console.WriteLine("1. Buch hinzufügen");
            Console.WriteLine("2. Bücher anzeigen");
            Console.WriteLine("3. Buch ausleihen");
            Console.WriteLine("4. Buch zurückgeben");
            Console.WriteLine("5. Beenden");
            Console.Write("Option wählen: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1": AddBook(); break;
                case "2": DisplayBooks(); break;
                case "3": BorrowBook(); break;
                case "4": ReturnBook(); break;
            }
        } while (option != "5");
    }

    static void AddBook()
    {
        Console.Write("Titel: ");
        string title = Console.ReadLine();
        Console.Write("Autor: ");
        string author = Console.ReadLine();

        library.Add(new Book { Title = title, Author = author, IsBorrowed = false });
        Console.WriteLine("Buch hinzugefügt.");
    }

    static void DisplayBooks()
    {
        if (library.Count == 0)
        {
            Console.WriteLine("Keine Bücher vorhanden.");
            return;
        }

        Console.WriteLine("\nBücher:");
        for (int i = 0; i < library.Count; i++)
        {
            var status = library[i].IsBorrowed ? "Ausgeliehen" : "Verfügbar";
            Console.WriteLine($"{i + 1}. {library[i].Title} von {library[i].Author} ({status})");
        }
    }

    static void BorrowBook()
    {
        DisplayBooks();
        Console.Write("Nummer des Buches zum Ausleihen: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < library.Count && !library[index].IsBorrowed)
        {
            library[index].IsBorrowed = true;
            Console.WriteLine("Buch ausgeliehen.");
        }
        else
        {
            Console.WriteLine("Ungültige Auswahl oder Buch bereits ausgeliehen.");
        }
    }

    static void ReturnBook()
    {
        DisplayBooks();
        Console.Write("Nummer des Buches zum Zurückgeben: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < library.Count && library[index].IsBorrowed)
        {
            library[index].IsBorrowed = false;
            Console.WriteLine("Buch zurückgegeben.");
        }
        else
        {
            Console.WriteLine("Ungültige Auswahl oder Buch ist nicht ausgeliehen.");
        }
    }
}
