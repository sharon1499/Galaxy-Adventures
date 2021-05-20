using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyGame
{
    public class BackCommand : Command
    {
        public BackCommand() : base()
        {
            this.name = "back";
        }
        override
        public bool execute(Player player) //Command that allows the user to go back to the last place they visited.
        {
            if(this.hasSecondWord())
            {
                player.outputMessage("Go back where?");
            }
            else
            {
                player.walkBack();   //Calls the method from player class
            }
            
            return false;
        }
    }
}
