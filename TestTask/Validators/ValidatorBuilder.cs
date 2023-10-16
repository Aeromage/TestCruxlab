using TestTask.Validators.Interfaces;

namespace TestTask.Validators;

public class ValidatorBuilder : IValidatorBuilder
{
    public IValidator GetValidator(ValidatorType type)
    {
        return type switch
        {
            ValidatorType.Default => new Validator(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}