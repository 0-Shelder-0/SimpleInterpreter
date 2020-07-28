using System.Collections.Generic;
using System.IO;
using Interpreter.Analyzers;
using Interpreter.Errors;
using Interpreter.Registrars;

namespace Interpreter.Performers
{
    public class VirtualMachine : IVirtualMachine
    {
        public IParser Parser { get; }
        public Dictionary<string, double> Memory { get; }
        public ICommandRecorder CommandRecorder { get; }

        public VirtualMachine(IParser parser, ICommandRecorder commandRecorder)
        {
            Parser = parser;
            CommandRecorder = commandRecorder;
            Memory = new Dictionary<string, double>();
        }

        public void Run(StreamWriter writer)
        {
            if (Parser.Instructions != null)
            {
                foreach (var token in Parser.Instructions)
                {
                    if (CommandRecorder.Commands.ContainsKey(token.Command))
                    {
                        CommandRecorder.Commands[token.Command](token.Arguments, this);
                    }
                    else
                    {
                        ExceptionHandler.ThrowException(writer, token);
                        return;
                    }
                }

                foreach (var (key, value) in Memory)
                {
                    writer.WriteLine($"{key}: {value}");
                }
            }
        }
    }
}