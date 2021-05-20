using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxyGame
{
    public class Item : ItemInterface
    {
        private String Name;
        private int Weight;
        private int Volume;

        public String name { get { return Name; } set { Name = value; } }
        public int weight { get { return Weight; } set { Weight = value; } }
        public int volume { get { return Volume; } set { Volume = value; } }
        public Item(String Name, int weight, int volume)
        {
            this.name = Name;
            this.weight = weight;
            this.volume = volume;
        }
        public Item()
        {
            this.name = name;
        }
        //Sets the name
        public void setName(String name) //Probably not necessary since it is redundant
        {
            this.name = name;
        }
        //Gets the name
        public String getName() 
        {
            return name;
        }
        public void setWeight(int num) //Probably not necessary since it is redundant
        {
            weight = num;
        }
        public int getWeight() 
        {
            return weight;
        }
        public void setVolume(int num) //Probably not necessary since it is redundant
        {
            volume = num;
        }
        public int getVolume() 
        {
            return volume;
        }
        public String toString()
        {
            return getName() + ". weight: " + getWeight() + ". volume: " + getVolume();
        }
    }
}
