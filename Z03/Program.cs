

//Zadanie 03


Player ada = new Player("Ada", 100, 20, 8, 74);
Player maciek = new Player("Maciek", 100, 5, 14, 24);

Enemy goblin = new Enemy("Goblin", 60, 20);
Enemy ork = new Enemy("Ork", 150, 10);

int goblinDamage = goblin.Damage;
int orkDamage = ork.Damage;

Console.WriteLine($"Zdrowie Ady: {ada.Health}/{ada.MaxHealth}");
Console.WriteLine($"Zdrowie macka: {maciek.Health}/{maciek.MaxHealth}");

ada.TakeDamage(goblinDamage);
Console.WriteLine($"Przeciwnik zadał graczu {goblinDamage}hp.");
Console.WriteLine($"Zdrowie Ady: {ada.Health}/{ada.MaxHealth}");
Console.WriteLine($"Zdrowie macka: {maciek.Health}/{maciek.MaxHealth}");

maciek.TakeDamage(orkDamage);
Console.WriteLine($"Przeciwnik zadał graczu {orkDamage}hp.");
Console.WriteLine($"Zdrowie Ady: {ada.Health}/{ada.MaxHealth}");
Console.WriteLine($"Zdrowie macka: {maciek.Health}/{maciek.MaxHealth}");