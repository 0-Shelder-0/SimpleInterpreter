using System.IO;
using Interpreter.Analyzers;
using Interpreter.Performers;
using Interpreter.Registrars;

namespace Interpreter
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string path = @"C:\Users\Vlad\Documents\Rider Projects\Interpreter\Interpreter\1.am";
            var text = File.ReadAllText(path);
            var lexer = new Lexer(text);
            var parser = new Parser(lexer);
            var commandRecorder = new CommandRecorder();
            var vm = new VirtualMachine(parser, commandRecorder);

            var interpreter = new Performers.Interpreter(lexer, parser, vm);
            interpreter.Run();
        }
    }
}