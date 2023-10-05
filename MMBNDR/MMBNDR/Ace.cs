using System;
using System.Collections.Generic;
public class Ace
{
	public string NaviName { get; set; }
	public int HealthPoint { get; set; }
	public int AttackPower { get; set; }
	public List<Chip> Chips { get; set; }

	public Ace(string name)
    {
		NaviName = name; // The Navi Name
		HealthPoint = 100; // Usual HealthPoint Start with MMBN
		AttackPower = 1; // Usual AttackPower Start with MMBN
		Chips = new List<Chip>();
    }

	// Add Chip to Ace Library
	public void AddChip(Chip chip)
    {
		Chips.Add(chip);
    }

	// Selected Chip
	public int Attack(Enemy enemy, Chip selectedChip)
    {
		int damageDealt = selectedChip.Damage + AttackPower;
		enemy.TakeDamage(damageDealt);
		return damageDealt;
    }
}
