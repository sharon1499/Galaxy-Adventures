using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyGame
{
    public class Alien
    {
        private String Name;
        public String name { get { return Name; } set { Name = value; } } //Created accessors for name and description
        private String Description;
        public String description { get { return Description; } set { Description = value; } } 

        private List<String> phrases;

        /**
         * Constructor for objects of class Alien
         */
        public Alien(String name)
        {
            //Initialize
            this.name = name;
            this.description = description;
            phrases = new List<String>();
            createPhrases(); //calls the method

        }

        public Alien(String name, String description)
        {
            //Initialize
            this.name = name;
            this.description = description;
            phrases = new List<String>();
            createPhrases();

        }
        public String getName()
        {
            return name;
        }
        public String getDescription()
        {
            return description;
        }

        //Gets the name and description of each Alien. Decided to use list because it seemed to be an easier option that I could access outside of this class to assign specific phrases to repsonses
        public void createPhrases() //Gets the name and description of each Alien. 
        {
            if (getName().Equals("opener"))
            {
                phrases.Add("\nHello,my name is " + getName());
                phrases.Add(getDescription());
                phrases.Add("\nGood Luck!\n");
            }

            else
            {
                phrases.Add("Hello,my name is " + getName());
                phrases.Add("\nInside this planet is a area with a hidden item.\n");
                phrases.Add("To find this item you must first solve my riddle to find its area\n");
                phrases.Add("Would you like to hear my riddle?\n");
                phrases.Add(getDescription());
                phrases.Add("Once you think you know the right answer go explore the area with the command 'explore (items name)'");
                phrases.Add("You figured it out. Good job!");
                phrases.Add("Okay no problem Bye!");
                phrases.Add("GoodBye!!");
            }
        }
        /**
         * gets the String from the ArrayList
         */
        public String haveConversation(int num)
        {
            return phrases[num];
        }
    }
}