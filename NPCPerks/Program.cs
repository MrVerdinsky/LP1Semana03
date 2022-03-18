using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user number of NPCs
            //For each NPC ask Perks and save in array
            //Display Perks of all NPCs 
            //If NPC has luck and combat print special message
            while (true)
            {
                bool validNPCTotal = false;
                int totalNPCS = 0;

                while (!validNPCTotal)
                {
                    Console.Write("Insert number of total NPCs: ");
                    string tempValue = Console.ReadLine();
                    if (int.TryParse(tempValue, out totalNPCS)) validNPCTotal = true;
                    else Console.WriteLine("Invalid Input");
                }
                Perks[] NPCPerks = new Perks[totalNPCS];

                for (int i = 0; i < totalNPCS; i++)
                {
                    string temp;
                    Console.Write($"Does NPC {i} have Stealth? ");
                    temp = Console.ReadLine();
                    if(temp == "yes") NPCPerks[i] |= Perks.Stealth;

                    Console.Write($"Does NPC {i} have Combat? ");
                    temp = Console.ReadLine();
                    if (temp == "yes") NPCPerks[i] |= Perks.Combat;

                    Console.Write($"Does NPC {i} have Luck? ");
                    temp = Console.ReadLine();
                    if (temp == "yes") NPCPerks[i] |= Perks.Luck;

                    Console.Write($"Does NPC {i} have Lockpick? ");
                    temp = Console.ReadLine();
                    if (temp == "yes") NPCPerks[i] |= Perks.Lockpick;


                }

                for (int i = 0; i < totalNPCS; i++)
                {
                    if (((NPCPerks[i] & Perks.Combat) == Perks.Combat) &&
                        ((NPCPerks[i] & Perks.Luck) == Perks.Luck))
                    {
                        Console.WriteLine($"NPC {i} has this perks: {NPCPerks[i]} It shall win every figth!");
                    }
                    else Console.WriteLine($"NPC {i} has this perks: {NPCPerks[i]}");
                    
                }
            }
        }
    }
}
