using System;
using System.Collections.Generic;
using Interpreter.Performers;

namespace Interpreter.Registrars
{
    public class CommandRecorder : ICommandRecorder
    {
        public Dictionary<string, Action<string[], IVirtualMachine>> Commands { get; }

        public CommandRecorder()
        {
            Commands = new Dictionary<string, Action<string[], IVirtualMachine>>();
        }

        public void RegisterCommand(string command, Action<string[], IVirtualMachine> action)
        {
            Commands[command] = action;
        }

        public void Run(IVirtualMachine vm)
        {
            BasicRecorder.RegisterTo(vm.CommandRecorder);
        }
    }
}