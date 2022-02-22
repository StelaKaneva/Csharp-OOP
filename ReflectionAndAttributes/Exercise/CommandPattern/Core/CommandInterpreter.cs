using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inputTokens = args.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string commandType = inputTokens[0].ToLower();
            string[] commandArguments = inputTokens.Skip(1).ToArray();

            string result = String.Empty;
            ICommand command = default;

            //if (commandType == "HelloCommand")
            //{
            //    command = new HelloCommand();
            //}
            //else if (commandType == "ExitCommand")
            //{
            //    command = new ExitCommand();
            //}

            //Get command types
            //Create command type instance
            //Execute command
            Type type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name.ToLower() == $"{commandType}Command".ToLower());

            ICommand instance = (ICommand)Activator.CreateInstance(type);
            result = instance?.Execute(commandArguments);

            //result = command.Execute(commandArguments);
            return result;
        }
    }
}
