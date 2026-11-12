public class Enemy
{
    public string Name { get; }
    public int Health { get; set; }
    public int Damage { get; }

    public Enemy(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
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
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
