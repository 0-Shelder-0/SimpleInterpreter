using System;
using System.IO;
using Interpreter.Analyzers;

namespace Interpreter.Performers
{
    public class Interpreter
    {
        private ILexer Lexer { get; }
        private IParser Parser { get; }
        private IVirtualMachine VirtualMachine { get; }

        public Interpreter(ILexer lexer,
                           IParser parser,
                           IVirtualMachine virtualMachine)
        {
            Lexer = lexer;
            Parser = parser;
            VirtualMachine = virtualMachine;
        }

        public void Run()
        {
            VirtualMachine.CommandRecorder.Run(VirtualMachine);
            Lexer.Run();
            Parser.Run();
            var streamWriter = new StreamWriter(Console.OpenStandardOutput())
            {
                AutoFlush = true
            };
            VirtualMachine.Run(streamWriter);
            streamWriter.Close();
            Console.SetOut(streamWriter);
        }
    }
}