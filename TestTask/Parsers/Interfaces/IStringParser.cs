namespace TestTask.Parsers.Interfaces;

public interface IStringParser<out T>
{
    public T Parse(string str);
}