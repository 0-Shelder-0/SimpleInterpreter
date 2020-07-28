using System;
using System.IO;
using Interpreter.Analyzers;

namespace Interpreter
{
    public class Interpreter
    {
        private string Path { get; }
        private ILexer Lexer { get; }
        private IParser Parser { get; }
        private IVirtualMachine VirtualMachine { get; }

        public Interpreter(string path,
                           ILexer lexer,
                           IParser parser,
                           IVirtualMachine virtualMachine)
        {
            Path = path;
            Lexer = lexer;
            Parser = parser;
            VirtualMachine = virtualMachine;
        }

        public void Run()
        {
            var streamWriter = new StreamWriter(Console.OpenStandardOutput())
            {
                AutoFlush = true
            };
            VirtualMachine.Run(streamWriter);
            Console.SetOut(streamWriter);
        }
    }
}