using System.Collections.Generic;
using System.IO;
using Interpreter.Analyzers;
using Interpreter.Registrars;

namespace Interpreter.Performers
{
    public interface IVirtualMachine
    {
        IParser Parser { get; }
        Dictionary<string, double> Memory { get; }
        ICommandRecorder CommandRecorder { get; }

        void Run(StreamWriter writer);
    }
}