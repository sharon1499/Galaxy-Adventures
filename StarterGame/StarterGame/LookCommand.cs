using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyGame
{
    class LookCommand : Command
    {
        public LookCommand() : base()
        {
            this.name = "look";
        }

        override
        public bool execute(Player player) //allows player to view items in bag
        {
            if (this.hasSecondWord())
            {
                if (this.getSecondWord().Equals("in"))
                {
                    if (this.hasThirdWord())
                    {
                        String item = getThirdWord();
                        if (item == "bag")
                        {
                            player.view();
                        }
                        else
                        {
                            player.outputMessage("What do you want to look in?");
                        }
                    }
                }
                else
                {
                    player.outputMessage("\nLook where?");
                }
            }
            else
            {
                player.outputMessage("\nLook where?");
            }
            return false;
        }
        }
    }