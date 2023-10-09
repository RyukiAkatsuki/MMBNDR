using System;

public class Item
{
	public string Name { get; set; }
	public ItemType Type { get; set; }
	public int Amount { get; set; }

	public Item(string name, ItemType type, int amount)
	{
		Name = name;
		Type = type;
		Amount = amount;
	}

	public enum ItemType
    {
		Zenny,
		BattleChip
    }
}
