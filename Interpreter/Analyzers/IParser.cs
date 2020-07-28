using System.Collections.Generic;
using Interpreter.Entities;

namespace Interpreter.Analyzers
{
    public interface IParser
    {
        ILexer Lexer { get; }
        IEnumerable<Token> Instructions { get; }

        void Run();
    }
}