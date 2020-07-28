using System.Collections.Generic;

namespace Interpreter
{
    public interface IParser
    {
        ILexer Lexer { get; }
        IEnumerable<IInstruction> Instructions { get; }

        void Run();
    }
}