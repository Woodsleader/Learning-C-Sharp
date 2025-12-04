Random rng = new Random();
int secretNumber = rng.Next(1, 101);
bool gameOn = true;
int tries = 0;
while (gameOn)
{
    Console.WriteLine("Write your guess:");
    int userNumber = int.Parse(Console.ReadLine());
    tries++;
    if (userNumber == secretNumber)
    {
        Console.WriteLine("You got it!");
        Console.WriteLine($"It has taken {tries} tries.");
        gameOn = false;
    }
    else if (userNumber < secretNumber)
    {
        Console.WriteLine("The number is too small.");
    }
    else
    {
        Console.WriteLine("The number is too big");
    }
}
