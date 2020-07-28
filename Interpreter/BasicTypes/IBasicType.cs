namespace Interpreter.BasicTypes
{
    public interface IBasicType<T>
    {
        T Value { get; set; }
    }
}