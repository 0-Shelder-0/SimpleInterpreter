using System.Collections.Generic;

namespace Interpreter.Analyzers
{
    public interface ILexer
    {
        IEnumerable<string> Lexemes { get; }
        string TokenPattern { get; }

        void Run();
    }
}