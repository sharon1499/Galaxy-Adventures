using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyGame
{
    class DropCommand : Command
    {
        public DropCommand() : base()
        {
            this.name = "drop";
        }

        override
        public bool execute(Player player)
        {
            if (this.hasSecondWord())
            {
                String item = getSecondWord(); //Checks if the items being attempted to drop is valid.
                if (item == "sand" || item == "pyramid" || item == "fountain" || item == "volcano" || item == "desert" || item == "sea" || item == "mountain")
                {
                    Console.WriteLine("You cannot drop these items");
                }
                else if(item == "book1" || item == "map")
                {
                    Console.WriteLine("You do not have this item");
                }
                else
                {
                    player.dropfromInventory(item); //Calls method from player class that drops the item grabbed from the bookbag.

                }
            }
            else
            {
                player.outputMessage("\nIm sorry.What did you want to drop");
            }
            return false;
        }
    }
}

