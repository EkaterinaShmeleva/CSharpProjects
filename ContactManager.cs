using System;
using System.Collections.Generic;

class ContactManager
{
    class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    static List<Contact> contacts = new List<Contact>();

    static void Main()
    {
        string option;
        do
        {
            Console.WriteLine("\nKontaktmanagement-System");
            Console.WriteLine("1. Kontakt hinzufügen");
            Console.WriteLine("2. Kontakte anzeigen");
            Console.WriteLine("3. Kontakt bearbeiten");
            Console.WriteLine("4. Kontakt löschen");
            Console.WriteLine("5. Beenden");
            Console.Write("Option wählen: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1": AddContact(); break;
                case "2": DisplayContacts(); break;
                case "3": EditContact(); break;
                case "4": DeleteContact(); break;
            }
        } while (option != "5");
    }

    static void AddContact()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Telefon: ");
        string phone = Console.ReadLine();

        contacts.Add(new Contact { Name = name, Email = email, Phone = phone });
        Console.WriteLine("Kontakt hinzugefügt.");
    }

    static void DisplayContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("Keine Kontakte vorhanden.");
            return;
        }

        Console.WriteLine("\nKontakte:");
        for (int i = 0; i < contacts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {contacts[i].Name} - {contacts[i].Email} - {contacts[i].Phone}");
        }
    }

    static void EditContact()
    {
        DisplayContacts();
        Console.Write("Nummer des Kontakts zum Bearbeiten: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < contacts.Count)
        {
            Console.Write("Neuer Name (leer lassen, um unverändert zu lassen): ");
            string name = Console.ReadLine();
            Console.Write("Neue Email (leer lassen, um unverändert zu lassen): ");
            string email = Console.ReadLine();
            Console.Write("Neues Telefon (leer lassen, um unverändert zu lassen): ");
            string phone = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name)) contacts[index].Name = name;
            if (!string.IsNullOrWhiteSpace(email)) contacts[index].Email = email;
            if (!string.IsNullOrWhiteSpace(phone)) contacts[index].Phone = phone;

            Console.WriteLine("Kontakt aktualisiert.");
        }
        else
        {
            Console.WriteLine("Ungültige Auswahl.");
        }
    }

    static void DeleteContact()
    {
        DisplayContacts();
        Console.Write("Nummer des Kontakts zum Löschen: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < contacts.Count)
        {
            contacts.RemoveAt(index);
            Console.WriteLine("Kontakt gelöscht.");
        }
        else
        {
            Console.WriteLine("Ungültige Auswahl.");
        }
    }
}
