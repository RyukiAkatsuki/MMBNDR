using System;
using System.Collections.Generic;

public class ProgramAdvance
{
    public string Name { get; set; }
    public List<string> RequiredChips { get; set; }
    public int Damage { get; set; }
    public string Description { get; set; }

    public ProgramAdvance(string name, List<string> requiredChips, int damage, string description)
    {
        Name = name;
        RequiredChips = requiredChips;
        Damage = damage;
        Description = description;
    }

    public bool CanExecute(List<Chip> playersChips)
    {
        // We check if the player has the required chips to execute the program advance
        foreach (string requiredChipCode in RequiredChips)
        {
            bool found = false;
            foreach(Chip chip in playersChips)
            {
                if (chip.ChipCode == requiredChipCode)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
                return false; // Missing the required chip
        }
        return true; // All found
    }
}
