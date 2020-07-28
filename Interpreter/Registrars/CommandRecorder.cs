using System.Collections.Generic;

namespace Interpreter
{
    public class CommandRecorder : ICommandRecorder
    {
        public IEnumerable<string> Commands { get; }
        public IVirtualMachine VirtualMachine { get; }

        public CommandRecorder(IEnumerable<string> commands, IVirtualMachine virtualMachine)
        {
            Commands = commands;
            VirtualMachine = virtualMachine;
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}