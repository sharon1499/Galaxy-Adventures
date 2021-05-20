using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyGame
{
    public class ExploreCommand : Command
    {
        public ExploreCommand() : base()
        {
            this.name = "explore";
        }

        override
        public bool execute(Player player) //Allows player to explore the set locations/items 
        {
            if (this.hasSecondWord())
            {
                String place = getSecondWord(); //Set the second word to places that are allowed to be expolored
                if (place == "sand" || place == "pyramid" || place == "sea" || place =="fountain" || place =="volcano" || place =="desert" || place == "mountain")
                {
                    Console.WriteLine("You look around the " +  place +".....");
                    player.explore(place);
                }
               
                else
                {
                    Console.WriteLine("Im sorry. You cannot explore "+ place); //if one of the places entered cannot be explored
                }
            }
            else
            {
                player.outputMessage("\nIm sorry.Where did you want to search");
            }
            return false;
        }
    }
}
