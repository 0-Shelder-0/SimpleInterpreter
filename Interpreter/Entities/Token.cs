using System.Collections.Generic;
using System.Linq;

namespace Interpreter.Entities
{
    public class Token
    {
        public string Command { get; }
        public string[] Arguments { get; }

        public Token(string command, IEnumerable<string> arguments)
        {
            Command = command;
            Arguments = arguments.ToArray();
        }
    }
}