using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Interpreter.Analyzers
{
    public class Lexer : ILexer
    {
        public IEnumerable<string> Lexemes { get; private set; }
        public string TokenPattern { get; }
        private readonly string _text;

        public Lexer(string text)
        {
            _text = text;
            var ptr = @"[a-zA-Z]{2,3}\s+[a-zA-Z][a-zA-Z0-9]*";
            TokenPattern = @$"{ptr}\s*,\s*[a-zA-Z0-9]+|{ptr}";
        }

        public void Run()
        {
            Lexemes = Regex.Matches(_text, TokenPattern)
                           .Select(line => line.Value)
                           .Where(line => line.Length > 0);
        }
    }
}