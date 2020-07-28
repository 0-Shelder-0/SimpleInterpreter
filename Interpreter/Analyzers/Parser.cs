using System.Collections.Generic;

namespace Interpreter
{
    public class Parser : IParser
    {
        public ILexer Lexer { get; }
        public IEnumerable<IInstruction> Instructions { get; }

        public Parser(ILexer lexer)
        {
            Lexer = lexer;
        }

        public void Run()
        {
            
        }
    }
}