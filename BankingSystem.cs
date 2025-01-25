using System;
using System.Collections.Generic;

class BankingSystem
{
    class Account
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
    }

    static List<Account> accounts = new List<Account>();

    static void Main()
    {
        string option;
        do
        {
            Console.WriteLine("\nBank-System");
            Console.WriteLine("1. Konto erstellen");
            Console.WriteLine("2. Einzahlung");
            Console.WriteLine("3. Auszahlung");
            Console.WriteLine("4. Kontostand anzeigen");
            Console.WriteLine("5. Beenden");
            Console.Write("Option wählen: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1": CreateAccount(); break;
                case "2": Deposit(); break;
                case "3": Withdraw(); break;
                case "4": DisplayBalance(); break;
            }
        } while (option != "5");
    }

    static void CreateAccount()
    {
        Console.Write("Name des Kontoinhabers: ");
        string name = Console.ReadLine();

        accounts.Add(new Account { AccountHolder = name, Balance = 0 });
        Console.WriteLine("Konto erstellt.");
    }

    static void Deposit()
    {
        var account = SelectAccount();
        if (account != null)
        {
            Console.Write("Betrag zum Einzahlen: ");
            double amount = double.Parse(Console.ReadLine());
            account.Balance += amount;
            Console.WriteLine($"Einzahlung erfolgreich. Neuer Kontostand: {account.Balance} €");
        }
    }

    static void Withdraw()
    {
        var account = SelectAccount();
        if (account != null)
        {
            Console.Write("Betrag zum Abheben: ");
            double amount = double.Parse(Console.ReadLine());
            if (amount <= account.Balance)
            {
                account.Balance -= amount;
                Console.WriteLine($"Auszahlung erfolgreich. Neuer Kontostand: {account.Balance} €");
            }
            else
            {
                Console.WriteLine("Unzureichender Kontostand.");
            }
        }
    }

    static void DisplayBalance()
    {
        var account = SelectAccount();
        if (account != null)
        {
            Console.WriteLine($"Kontostand von {account.AccountHolder}: {account.Balance} €");
        }
    }

    static Account SelectAccount()
    {
        if (accounts.Count == 0)
        {
            Console.WriteLine("Keine Konten verfügbar.");
            return null;
        }

        Console.WriteLine("\nVerfügbare Konten:");
        for (int i = 0; i < accounts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {accounts[i].AccountHolder}");
        }

        Console.Write("Kontonummer auswählen: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < accounts.Count)
        {
            return accounts[index];
        }
        else
        {
            Console.WriteLine("Ungültige Auswahl.");
            return null;
        }
    }
}
