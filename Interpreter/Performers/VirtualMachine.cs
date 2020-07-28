using System.Collections.Generic;
using System.IO;
using Interpreter.Entities;

namespace Interpreter
{
    public class VirtualMachine : IVirtualMachine
    {
        public IEnumerable<IInstruction> Instructions { get; }
        public int InstructionPointer { get; }
        public IEnumerable<byte> Memory { get; }

        public VirtualMachine(IEnumerable<IInstruction> instructions)
        {
            Instructions = instructions;
            InstructionPointer = 0;
            Memory = new List<byte>();
        }

        public void RegisterCommand()
        {
            throw new System.NotImplementedException();
        }

        public StreamReader Run(StreamWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }
}