using System;
using System.Collections.Generic;

class ToDoList
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        string input;

        Console.WriteLine("Willkommen zur To-Do-Liste!");

        do
        {
            Console.WriteLine("\nOptionen:");
            Console.WriteLine("1. Aufgabe hinzufügen");
            Console.WriteLine("2. Aufgaben anzeigen");
            Console.WriteLine("3. Beenden");
            Console.Write("Wähle eine Option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Neue Aufgabe: ");
                    tasks.Add(Console.ReadLine());
                    break;

                case "2":
                    Console.WriteLine("\nDeine Aufgaben:");
                    if (tasks.Count == 0)
                        Console.WriteLine("Keine Aufgaben gefunden.");
                    else
                        for (int i = 0; i < tasks.Count; i++)
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                    break;
            }
        } while (input != "3");

        Console.WriteLine("Programm beendet.");
    }
}
