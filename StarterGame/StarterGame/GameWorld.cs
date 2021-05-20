using System.Collections;
using System.Collections.Generic;
using System;

namespace GalaxyGame
{
    public class GameWorld
    {
        static private GameWorld _instance;
        static public GameWorld Instance {
            get {
                if (_instance == null)
                    _instance = new GameWorld();
                return _instance;
            }
        }
        private Room _entrance;
        public Room Entrance { get { return _entrance; } }

        private Room trigger;
        private Room trigger6;
        private Room trigger7;

        private GameWorld()
        {
            _entrance = createWorld();
            // GameWorld subscribes to the notification PlayerEnteredRoom
            NotificationCenter.Instance.addObserver("PlayerEnteredRoom", playerEnteredRoom);
        }

        private Room createWorld()
        {
            /****************************Rooms located in the world****************************************************************************/
            Room Sun = new Room("You are approaching the Sun.");
            Room Earth = new Room("You are located outside Earths orbit");
            Room takeOff = new Room("You are on earth");
            Room Moon = new Room("You have landed on the Moon");
            Room Jupiter = new Room("You have landed on planet Jupiter");
            Room Uranus = new Room("You have landed on planet Uranus");
            Room Neptune = new Room("You have landed on planet Neptune");
            Room Mars = new Room("You have landed on planet Mars");
            Room Pluto = new Room("You have landed on planet Pluto");
            Room Venus = new Room("You have landed on planet Venus");
            Room Mercury = new Room("You have landed on planet Mercury");
            Room Saturn = new Room("You have landed on planet Saturn");
            Room BlackHole = new Room("You have been sucked into a Blackhole");
            Room Haumea = new Room("You have landed on Haumea");
            Room Ceres = new Room("You have landed on Ceres");
            Room Eris = new Room("You have landed on Eris");
            Room Titan = new Room("You have landed on Titan");

            /*****************************People who will give you a hint that will help you find place and their items**********************/
            Alien Opener = new Alien("opener", "You have officially made it to space.\nYour objective is to find all of the hidden items on certain planets.");
            Alien Minx = new Alien("Minx", "\nRiddle:\nThis can be found on a golf course\nBut it is not a blade of grass\nInstead it’s something that’s grainy\nAnd is found in an hourglass");
            Alien Holly = new Alien("Holly", "\nRiddle:\nI have a floor but I'm not a room\nI wave but have no hands\nI'm wet but I'm not a towel\nI have currents but no electricity\nI contain fish but I'm not a tank\nI cover a lot of the planet but I'm not land\nWhat am i?");
            Alien Soul = new Alien("Soul", "\nRiddle:\nI reach towards the heavens\nI hold treasure within\nAnd throughout many ages I've shed some skin\nI've watched as nations rise and fall\nSturdy, rock, through it all\nWhat am i?");
            Alien Yuno = new Alien("Yuno", "\nRiddle:\nWhere does hopes go up\nAnd pennies come down\nAnd both meet to make a splash");
            Alien Jeff = new Alien("Jeff", "\nRiddle:\nWhat has little rain and a lot of sand\nWhere you'd want to see an oasis?");
            Alien Fumi = new Alien("Fumi", "\nRiddle:\nI produce ash but I'm not a bonfire\nI can throw rocks great distances but I'm not a slingshot\nI'm often a mountain but I'm not in the Himalayas\nI have a crater but I'm not the moon\nI erupt but I'm not someone with a bad temper\nWhat am i ? ");
            Alien Crius = new Alien("Crius", "\nRiddle:\nI can come in a range but I'm not options\nI'm tall but I'm not a skyscraper\nI can be climbed but I'm not a tree\nI'm often covered in snow but I'm not an igloo\nI have a peak but I'm not a cap\nWhat am i?");
           
            /************************************Items hidden in the room********************************************************************/
            
            /*Objects on the Moon*/
            Item Statue = new Item("Statue", 2, 2); //Item hidden to be found after exploring the first item
            Item Sand = new Item("Sand", 200, 24);   //This is the place to be explored to find required item
            Item Book = new Item("Book", 23, 13); //Not Hidden
            Item Map = new Item("Map", 10, 13);   //Not Hidden

            /*Objects on Neptune*/
            Item Sea = new Item("Sea", 400, 22);   //This is the place to be explored to find required item
            Item Pearl = new Item("Pearl", 4, 3); //Item hidden to be found after exploring the first item

            /*Obejcts on Mars*/
            Item pyramid = new Item("Pyramid", 5004, 324);  //This is the place to be explored to find required item
            Item goldNecklace = new Item("Gold Necklace", 4, 2); //Item hidden to be found after exploring the first item

            /*Objects on Pluto*/
            Item Fountain = new Item("Fountain", 100, 300);  //This is the place to be explored to find required item
            Item Coin = new Item("Coin", 4, 1); //Item hidden to be found after exploring the first item

            /*Objects on Mercury*/
            Item Desert = new Item("Desert", 400, 200);  //This is the place to be explored to find required item
            Item Cactus = new Item("Cactus", 5, 1);  //Item hidden to be found after exploring the first item

            /*Objects on Venus*/
            Item Volcano = new Item("Volcano", 2000, 2200);  //This is the place to be explored to find required item
            Item Magma = new Item("Magma", 3, 1); //Item hidden to be found after exploring the first item

            /*Objects on Titan*/
            Item Mountain = new Item("Mountain", 700, 600);  //This is the place to be explored to find required item
            Item Ice = new Item("Ice", 5, 1);  //Item hidden to be found after exploring the first item

           /************************Set the exits, people, and items in the rooms************************************************************/

            takeOff.setExit("north", Earth);

            /*Exits for Earth*/
            Earth.setExit("north", Sun);
            Earth.setExit("west", Moon);
            Earth.setExit("south", takeOff);
            Earth.setPerson("opener", Opener);
            
            
            /*Exits for the sun*/
            Sun.setExit("east", Mercury);
            Sun.setExit("south", Earth);
            Sun.setExit("west", BlackHole);

            /*Exits for the moon*/
            Moon.setExit("east", Earth);
            Moon.setExit("south", Jupiter);
            Moon.setExit("west", Uranus);

            /*Sets item and person for Moon*/
            Moon.roomItem("book1", Book);
            Moon.roomItem("map", Map);

            Moon.setItem("sand", Sand);    //Riddle that if answered right wil help find the location to be explored for the hidden item.
            Moon.setItem("statue", Statue);  //Hidden item

            Moon.setPerson("Minx", Minx);

            /*Exits for Jupiter*/
            Jupiter.setExit("north", Moon);
          
            /*Exits for uranus*/
            Uranus.setExit("east", Moon);
            Uranus.setExit("north", Neptune);

            /*Exits for neptune*/
            Neptune.setExit("south", Uranus);
            Neptune.setExit("east", Mars);

            /*Sets items and person for Neptune*/
            Neptune.setItem("sea",Sea);     //Riddle that if answered right wil help find the location to be explored for the hidden item.
            Neptune.setItem("pearl", Pearl);  //Hidden Item

            Neptune.setPerson("Holly", Holly);

            /*Exits for Mars*/
            Mars.setExit("west", Neptune);
            Mars.setExit("north", Pluto);
            Mars.setExit("east", Venus);


            /*Sets Items and person for Mars*/
            Mars.setItem("pyramid", pyramid);  //Riddle that if answered right wil help find the location to be explored for the hidden item.
            Mars.setItem("necklace", goldNecklace);  //Hidden Item

            Mars.setPerson("Soul", Soul);

            /*Exits for Pluto*/
            Pluto.setExit("south", Mars);
            Pluto.setExit("west", Haumea);
            Pluto.setExit("east", Ceres);

            /*Sets Items and people on Pluto*/
            Pluto.setPerson("Yuno", Yuno);

            Pluto.setItem("fountain", Fountain);   //Riddle that if answered right wil help find the location to be explored for the hidden item.
            Pluto.setItem("coin", Coin);      //Hidden Item

            /*Exits on Mercury */
            Mercury.setExit("west", Sun);
            Mercury.setExit("north", Venus);

            
            /*Sets item and person on mercury*/
            Mercury.setItem("desert", Desert);    //Riddle that if answered right wil help find the location to be explored for the hidden item.
            Mercury.setItem("cactus", Cactus);    //Hidden Item

            Mercury.setPerson("Jeff", Jeff);

            /*Exits for Venus*/
            Venus.setExit("south", Mercury);
            Venus.setExit("east", Saturn);
            Venus.setExit("west", Mars);


            /*Sets item and person on Venus*/
            Venus.setPerson("Fumi", Fumi);
            Venus.setItem("magma", Magma);    //Riddle that if answered right wil help find the location to be explored for the hidden item.
            Venus.setItem("volcano", Volcano);    //Hidden inspect

            /*Exits on Saturn */
            Saturn.setExit("west", Venus);
            Saturn.setExit("south", Titan);

            /*people and items on Saturn*/
            Saturn.roomItem("map",Map);

            /*Exits on Titan*/
            Titan.setExit("north", Saturn);


            /*Sets item and person on Titan*/
            Titan.setItem("mountain", Mountain); //Riddle that if answered right wil help find the location to be explored for the hidden item.
            Titan.setItem("ice", Ice);      //Hidden Item

            Titan.setPerson("Crius",Crius);

            /*Exits on Haumea*/
            Haumea.setExit("east", Pluto);

            /*Exits on Ceres*/
            Ceres.setExit("west", Pluto);
            Ceres.setExit("south", Eris);

            /*Exits on Eris*/
            Eris.setExit("north", Ceres);

            /***************************************************Sets Trigger Rooms************************************************************/
            trigger6 = Sun;
            trigger7 = BlackHole;

            trigger = takeOff;
            

            return takeOff;
        }


        // callback method for PlayerEnteredRoom
        public void playerEnteredRoom(Notification notification)
        {
            Player player = (Player)notification.Object;
            if(player.currentRoom == trigger) //Checks if player has completed the mission
            {
                Console.WriteLine("Did you find all of the items?(y/n)");
                String answer = Console.ReadLine();
                if(answer == "y")
                {
                    Console.WriteLine("Good job!!");
                    //Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Why are you back then");
                }
            }

            if (player.currentRoom == trigger6) //Warning for player
            {
                Console.WriteLine("You are near a blackhole! Make a wise decision");
            }
            if (player.currentRoom == trigger7) //Player loses if they take the wrong turn
            {
                //Game end = new Game();
                Console.WriteLine("Your luck suck!\nYou lose!");
                
                //end.end();
                //Environment.Exit(0);
            }

        }
        
    }
}
