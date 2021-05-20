using System.Collections;
using System.Collections.Generic;

namespace GalaxyGame
{
    public class GoCommand : Command
    {

        public GoCommand() : base()
        {
            this.name = "go";
        }
        override
        public bool execute(Player player) //Command that allows you to explore the world or galaxy.
        {
            if (this.hasSecondWord())
            {
                player.waltTo(this.secondWord);
            }
            else
            {
                player.outputMessage("\nGo Where?");
            }
            return false;
        }
    }
}
