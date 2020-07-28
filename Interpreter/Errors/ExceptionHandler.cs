using System.IO;
using Interpreter.Entities;

namespace Interpreter.Errors
{
    public static class ExceptionHandler
    {
        public static void ThrowException(StreamWriter stream, Token token)
        {
            stream.WriteLine($"Unexpected token: {token.Command}");
        }
    }
}