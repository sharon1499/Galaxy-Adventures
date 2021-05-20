﻿using System.Collections;
using System.Collections.Generic;
using System;

namespace GalaxyGame
{
    public class CommandWords
    {
        Dictionary<string, Command> commands;
        private static Command[] commandArray = { new GoCommand(), new QuitCommand(), new PickupCommand(), new TalkCommand(), new ExploreCommand(), new ReadCommand(), new BackCommand(), new SayCommand(), new TeleportCommand(), new DropCommand(), new LookCommand()};

        public CommandWords() : this(commandArray)
        {
        }
        public CommandWords(Command[] commandList)
        {
            commands = new Dictionary<string, Command>();
            foreach (Command command in commandList)
            {
                commands[command.name] = command;
            }
            Command help = new HelpCommand(this);
            commands[help.name] = help;
        }

        public Command get(string word)
        {
            Command command = null;
            commands.TryGetValue(word, out command);
            return command;
        }

        public string description()
        {
            string commandNames = "";
            Dictionary<string, Command>.KeyCollection keys = commands.Keys;
            foreach (string commandName in keys)
            {
                commandNames += " " + commandName;
            }
            return commandNames;


        }
    }
}
