using System;

class NumberGuessingGame
{
    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int attempts = 0;
        int guess;

        Console.WriteLine("Willkommen zum Zahlenraten! (1 bis 100)");

        do
        {
            Console.Write("Deine Vermutung: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < numberToGuess)
                Console.WriteLine("Zu niedrig!");
            else if (guess > numberToGuess)
                Console.WriteLine("Zu hoch!");
            else
                Console.WriteLine($"Richtig! Du hast {attempts} Versuche gebraucht.");
        }
        while (guess != numberToGuess);
    }
}
