Console.WriteLine("Do you have the magic key?");
string keyAnswer = Console.ReadLine().ToLower();
Console.WriteLine("What is your bravery level");
int braveryLevel = int.Parse(Console.ReadLine());
if (keyAnswer == "yes" && braveryLevel >= 7)
{
    Console.WriteLine("You're worthy of the treasure.");
}
else if (keyAnswer == "no" && braveryLevel >= 7)
{
    Console.WriteLine("How are you going to open the treasure without a key?");
}
else if (keyAnswer == "yes" && braveryLevel < 7)
{
    Console.WriteLine("You're not brave enough for the treasure.");
}
else
{
    Console.WriteLine("How do you dare to show yourself here with no key nor bravery?");
}