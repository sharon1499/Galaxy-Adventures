using System.Collections;
using System.Collections.Generic;
using System;

namespace GalaxyGame
{
    public abstract class Command
    {
        private string _name;
        public string name { get { return _name; } set { _name = value; } }
        private string _secondWord;
        public string secondWord { get { return _secondWord; } set { _secondWord = value; } }

        private string _thirdWord; //Attempt to get third word
        public string thirdWord { get { return _thirdWord; } set { _thirdWord = value; } } //Attempt to get third word

        public Command()
        {
            this.name = "";
            this.secondWord = null;
            this.thirdWord = null; //Attempt to get third word
        }

        public String getSecondWord()
        {
            return secondWord;
        }
        public bool hasSecondWord()
        {
            return this.secondWord != null;
        }
        public String getThirdWord()  //Attempt to get third word
        {
            return thirdWord;
        }
        public bool hasThirdWord() //Attempt to get third word
        {
            return this.thirdWord != null;
        }

        public abstract bool execute(Player player);
    }
}
