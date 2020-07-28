using System.Collections.Generic;

namespace Interpreter
{
    public interface ICommandRecorder
    {
        IEnumerable<string> Commands { get; }
        IVirtualMachine VirtualMachine { get; }

        void Run();
    }
}