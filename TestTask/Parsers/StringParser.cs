using TestTask.Parsers.Interfaces;
using TestTask.Validators;

namespace TestTask.Parsers;

public class StringParser : IStringParser<(ValidationRule, string)>
{
    public (ValidationRule, string) Parse(string str)
    {
        var rule = new ValidationRule();
        var strParts = str.Split(' ');

        if (strParts.Length != 3)
        {
            throw new Exception("Invalid file content");
        }
        
        rule.Symbol = strParts[0];
        var symTimes = strParts[1].Replace(":", string.Empty).Split("-");
        
        if (symTimes.Length != 2)
        {
            throw new Exception("Invalid times count");
        }
        
        var fromResult = int.TryParse(symTimes[0], out var from);
        var toResult = int.TryParse(symTimes[1], out var to);

        if (!fromResult || !toResult)
        {
            throw new Exception("Invalid times count");
        }

        rule.TimesFrom = from;
        rule.TimesTo = to;
        return (rule, strParts[2]);
    }
}