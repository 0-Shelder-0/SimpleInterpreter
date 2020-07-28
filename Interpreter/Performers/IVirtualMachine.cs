using System.Collections.Generic;
using System.IO;
using Interpreter.Entities;

namespace Interpreter
{
    public interface IVirtualMachine
    {
        IEnumerable<IInstruction> Instructions { get; }
        int InstructionPointer { get; }
        IEnumerable<byte> Memory { get; }
        
        void RegisterCommand();
        StreamReader Run(StreamWriter writer);
    }
}