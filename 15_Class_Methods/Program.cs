using _15_Class_Methods;

Hero guts = new Hero();
guts.Name = "Guts";
guts.Health = 100;
guts.TakeDamage(30);
guts.TakeDamage(30);
guts.Heal(10);
Console.WriteLine($"{guts.Name}: {guts.Health}HP");