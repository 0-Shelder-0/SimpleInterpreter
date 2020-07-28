using System.Collections.Generic;

namespace Interpreter
{
    public interface ILexer
    {
        IEnumerable<string> Lexemes { get; }
        string TokenPattern { get; }

        void Run();
    }
}