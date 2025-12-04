using _13_List_Methods;

List<Hero> party = new List<Hero>();
Hero character1 = new Hero();
character1.Name = "Guts";
character1.Health = 100;
Hero character2 = new Hero();
character2.Name = "Giffith";
character2.Health = 100;
Hero character3 = new Hero();
character3.Name = "Caska";
character3.Health = 100;
party.Add(character1);
party.Add(character2);
party.Add(character3);
foreach (Hero h in party)
{
    Console.WriteLine($"{h.Name}: {h.Health}HP");
}
party.Remove(character2);
Console.WriteLine($"{character2.Name} betrayed your party and abandoned you...");
character1.Health = 30;
character2.Health = 200;
character3.Health = 5;
foreach (Hero h in party)
{
    Console.WriteLine($"{h.Name}: {h.Health}HP");
}