using System;

public class Chip
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public string Description { get; set; }
    public string ChipCode { get; set; }

    public Chip(string name, int damage, string description, string chipCode)
    {
        Name = name;
        Damage = damage;
        Description = description;
        ChipCode = chipCode;
    }
}