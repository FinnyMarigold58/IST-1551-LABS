// IST 1551, Lab #9, Tegan Herring, 11/21/2025

int correctNumber;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
} while (!int.TryParse(Console.ReadLine(), out correctNumber) || correctNumber < 0 || correctNumber > 100);

Console.Clear();
Console.WriteLine("User 2, guess the number.");

while (true)
{

    int guess;

    while (!int.TryParse(Console.ReadLine(),out guess) || guess < 0 || guess > 100)
    {
        Console.Write("What is your next guess? ");
    }

    if (guess > correctNumber)
    {
        Console.WriteLine($"{guess} is too high.");
    } else if (guess < correctNumber)
    {
        Console.WriteLine($"{guess} is too low.");
    }
    else
    {
        Console.WriteLine("You guessed the number!");
        break;
    }
}