using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Interpreter
{
    public class Lexer : ILexer
    {
        public IEnumerable<string> Lexemes { get; private set; }
        public string TokenPattern { get; }
        private readonly string _text;

        public Lexer(string text)
        {
            _text = text;
            TokenPattern = @"\s*[a-zA-Z]{2,3}\s+([a-zA-Z]+\s*,\s*[a-zA-Z]+)|([a-zA-Z]+)\s*";
        }

        public void Run()
        {
            Lexemes = Regex.Split(_text, TokenPattern)
                           .Where(line => line.Length > 0);
        }
    }
}