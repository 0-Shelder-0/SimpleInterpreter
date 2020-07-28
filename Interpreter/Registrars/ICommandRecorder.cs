using System;
using System.Collections.Generic;
using Interpreter.Performers;

namespace Interpreter.Registrars
{
    public interface ICommandRecorder
    {
        Dictionary<string, Action<string[], IVirtualMachine>> Commands { get; }

        void RegisterCommand(string command, Action<string[], IVirtualMachine> action);
        void Run(IVirtualMachine vm);
    }
}