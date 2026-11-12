
public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; }
    public int Gold { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

    public Player(string name, int maxHealth, int gold, int level, int experience)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level = level;
        Experience = experience;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (damage == 0)
        {
            Console.WriteLine("Przeciwnik nic nie zadał.");
        }
        else if (damage < 0)
        {
            Console.WriteLine("Przeciwnik zadał ujemne obrażenia.");
        }
        if (Health < 0)
        {
            Health = 0;
            Console.WriteLine("Umierasz.");
        }
    }

    public void Heal(int amount)
    {
        Health += amount;
        if (amount == 0)
        {
            Console.WriteLine("Nic nie wyleczono.");
        }
        else if (amount < 0)
        {
            Console.WriteLine($"Leczenie okazało się trucizną ({amount}HP)");
        }
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
        
        if (Health < 0)
        {
            Health = 0;
            Console.WriteLine("Umierasz.");
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void Exp(int Experience, int Level, int gain)
    {
        Experience += gain;

        if (Experience > 100)
        {
            Level++;
            Experience -= 100;
        }
    }
}
