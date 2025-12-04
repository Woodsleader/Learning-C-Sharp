using _12_Lists_Collections;

List<Hero> party = new List<Hero>();
Hero character1 = new Hero();
character1.Name = "Guts";
character1.Health = 100;
Hero character2 = new Hero();
character2.Name = "Griffith";
character2.Health = 100;
Hero character3 = new Hero();
character3.Name = "Caska";
character3.Health = 20;
party.Add(character1);
party.Add(character2);
party.Add(character3);
Console.WriteLine($"You have {party.Count} heroes in your party:");
foreach (Hero h in party)
{
    Console.WriteLine(h.Name);
}