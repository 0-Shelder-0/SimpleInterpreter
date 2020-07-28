using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Interpreter.Entities;

namespace Interpreter.Analyzers
{
    public class Parser : IParser
    {
        public ILexer Lexer { get; }
        public IEnumerable<Token> Instructions { get; private set; }

        public Parser(ILexer lexer)
        {
            Lexer = lexer;
        }

        public void Run()
        {
            Instructions = Lexer.Lexemes
                                .Select(line => Regex.Split(line, @"[\s,]")
                                                     .Where(item => item.Length > 0)
                                                     .ToList())
                                .Select(list => new Token(list.FirstOrDefault(), list.Skip(1)));
        }
    }
}