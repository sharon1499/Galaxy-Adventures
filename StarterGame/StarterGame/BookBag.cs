using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyGame
{
    public class BookBag //The Players Inventory basically...
    {
        private int totalWeight;
        private int capacityWeight;
        private int totalVolume;
        private int capacityVolume;
        private List<Item> inventory;  //List to store items from Item class
        private int listAmount;
        

        public BookBag()
        {
            totalWeight = 0; //initalizes the set value
            capacityWeight = 27; //initializes the max
            totalVolume = 0; //initalizes the set value
            capacityVolume = 12; //initializes the max
            inventory = new List<Item>(); ////initializes the list
            listAmount = 7;


        }
        public void addItem(Item item) //Method to add to the inventory if theres room
        {
            if ((item.getWeight() + totalWeight <= capacityWeight) && (item.getVolume() + totalVolume <= capacityVolume)) //Checks the weight and volume.
            {
                if (inventory.Contains(item))
                {
                    Console.WriteLine("You alread have this item");
                }
                else
                {
                    inventory.Add(item); //Adds to the list.
                    listAmount--;
                    Console.WriteLine("You have " + listAmount + " items left to find");
                    if (listAmount == 0)
                    {
                        Console.WriteLine("You found all of the items!");
                        Console.WriteLine("You win!");
                        Console.WriteLine("You can now return to earth");
                        
                    }
                }       

    }
            else
            {
                Console.WriteLine("Sorry your backpack is either full or the item your trying to pick up is too heavy."); //Outputs if the above weight or volume is at its max.
            }

        }
        public String printBag() //Prints the items in the bag if called
        {
            String list = "Items in the bookbag: \n";
            for (int i = 0; i < inventory.Count; i++)
            {
                list += "\nItem: " + inventory[i].getName() + "     Weight: " + inventory[i].getWeight() + "     Volume: " + inventory[i].getVolume() + "\n";
            }
            return list;
        }
       
        public Item getItem(String name) //Return the item entered by player
        {
            int i = 0;
            while (inventory[i].Equals(name)) //Create a while loop to continously get the item if it is in the list
            {
                i++;
            }
            return inventory[i];
        }
        
        public void removItem(Item name) //Just an if statement to check if the item is in the bag then remove it //for the drop command
        {
            if (inventory.Contains(name))
            {
                inventory.Remove(name);
                listAmount++;
            }
            else
            {
                Console.WriteLine("This item is not in your bag");
            }
        }
    }   
}
