Console.WriteLine("Enter damage amount:");
int damage = int.Parse(Console.ReadLine());
if (damage <= 10)
{
    Console.WriteLine("The attack missed...");
}
else if (damage >= 50)
{
    Console.WriteLine("The attack dealt a critical hit!");
}
else
{
    Console.WriteLine("The attack has hit");
}