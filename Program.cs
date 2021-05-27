using System;

namespace ClassExample_20210527
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterClass shopNpc = new CharacterClass("ShopNpc");
            

            Npc npc1 = new Npc("Merchant", "Bob", 9, shopNpc);
            Npc npc2 = new Npc("Enemy", "Evil Bob", 90, new CharacterClass("Pirate"));

            Player p1 = new Player("Controller", "Player Bob", new CharacterClass("Player"));

            System.Console.WriteLine($"Name of Npc1 is: {npc1.Name}");
            System.Console.WriteLine($"Npc1's class is: {npc1.CharacterClass.Name}");
        }
    }
}
