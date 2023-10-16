using TestTask.Validators.Interfaces;

namespace TestTask.Validators;

public class Validator : IValidator
{
    public bool IsValidPassword(ValidationRule rule, string password)
    {
        var count = password
            .Count(x => string.Equals(rule.Symbol, x.ToString(), StringComparison.InvariantCultureIgnoreCase));

        return count >= rule.TimesFrom && count <= rule.TimesTo;
    }
}