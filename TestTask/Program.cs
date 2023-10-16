using TestTask;
using TestTask.Parsers;
using TestTask.Parsers.Interfaces;
using TestTask.Validators;
using TestTask.Validators.Interfaces;

var filePath = Console.ReadLine();

if (!File.Exists(filePath) && Path.GetExtension(filePath) != "txt")
{
    Console.WriteLine("File path is invalid");
    Environment.Exit(0);
}

var allLines = File.ReadAllLines(filePath);

IStringParser<(ValidationRule, string)> strParser = new StringParser();

IValidator validator = new ValidatorBuilder().GetValidator(ValidatorType.Default);

foreach (var line in allLines)
{
    var parsedRuleAndPassword = strParser.Parse(line);

    var result = validator.IsValidPassword(parsedRuleAndPassword.Item1, parsedRuleAndPassword.Item2);

    Console.WriteLine($"{line} is {(result ? "valid":"invalid")}");
}




