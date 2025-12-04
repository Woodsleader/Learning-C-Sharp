using _11_Classes_HeroMaker;

Hero character1 = new Hero();
character1.Name = "Guts";
character1.Health = 100;
Hero character2 = new Hero();
character2.Name = "Lancelot";
character2.Health = 100;
Hero[] party = new Hero[2];
party[0] = character1;
party[1] = character2;
for (int i = 0; i < party.Length; i++)
{
    Console.WriteLine($"{party[i].Name} has {party[i].Health} HP.");
}