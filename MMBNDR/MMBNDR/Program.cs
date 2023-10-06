using System;

 class Program
 {
    static void Main()
    {

        // Player
        Ace player = new Ace("Ace.EXE");

        // Enemy
        Enemy enemy = new Enemy("Mettaur", 40, 10);

        // Create Chip
        Chip chip1 = new Chip("Cannon", 40, "A Simple Cannon", "A");
        Chip chip2 = new Chip("Sword", 80, "A Simple Sword", "S");

        // Add Chip
        player.AddChip(chip1);
        player.AddChip(chip2);


    }
}
