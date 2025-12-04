string heroName = "Guts";
int level = 100;
double attack = 250.00;
bool hasShield = true;
Console.WriteLine($"{heroName} is level {level} and has an attack of {attack}. {(hasShield ? "Shield is active" : "No shield available")}");