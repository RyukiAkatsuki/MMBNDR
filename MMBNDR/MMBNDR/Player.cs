using System;
using System.Collections.Generic;

public class Player
{
    public string Name { get; set; }
    public int HealthPoint { get; set; }
    public int Zenny { get; set; }
    public List<Chip> Chips { get; set; }
    
    public Player(string name)
    {
        Name = name;
        HealthPoint = 100; // Initial HP
        Zenny = 0; // Initial Money
        Chips = new List<Chip>();
    }

    public void AddZenny(int amount)
    {
        Zenny += amount;
    }

    public void AddChip(Chip chip)
    {
        Chips.Add(chip);
    }
}
