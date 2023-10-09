using System;
using System.Collections.Generic;
public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public List<Item> Drops { get; set; }

    public Enemy(string name, int initialHealth, int attackPower)
    {
        Name = name;
        Health = initialHealth;
        AttackPower = attackPower;
    }

    // Method to take damage from an attack
    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0)
            Health = 0;  // Ensure health doesn't go negative
    }

    public Item GetRandomDrop()
    {
        if (Drops.Count == 0)
            return null;

        Random random = new Random();
        int randomIndex = random.Next(0, Drops.Count);
        return Drops[randomIndex];
    }
}
