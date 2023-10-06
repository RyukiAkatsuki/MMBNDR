using System;
using System.Collections.Generic;

class Program
 {
    static void Main()
    {

        // Player
        Ace player = new Ace("Ace.EXE");

        // Enemy
        Enemy enemy = new Enemy("Mettaur", 40, 10);

        // Create Chip
        Chip chip1 = new Chip("Cannon", 40, "A Simple Cannon", "C");
        Chip chip2 = new Chip("HiCannon", 80, "A Normal Cannon", "H");
        Chip chip3 = new Chip("MCannon", 120, "A Stronger Cannon", "M");

        // Create Program Advance
        ProgramAdvance programAdvance1 = new ProgramAdvance(
            "OmegaCanon",
            new List<string> {"C", "H", "M"},
            300,
            "Powerful combinaison with all Cannon"
            );

        List<Chip> playerChips = new List<Chip> { chip1, chip2, chip3 };
        if (programAdvance1.CanExecute(playerChips))
        {
            // Execute the Program Advance
            Console.WriteLine($"Executing {programAdvance1.Name}!");
            int damageDealt = programAdvance1.Damage;
            Console.WriteLine($"Dealt {damageDealt} damage to the enemy.");
        }
        else
        {
            Console.WriteLine($"Cannot execute {programAdvance1.Name}. Missing required chips.");
        }
        // Add Chip
        player.AddChip(chip1);
        player.AddChip(chip2);
        player.AddChip(chip3);


    }
}
