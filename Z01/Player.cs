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

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void Heal(int amount)
    {
        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
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
