namespace TestTask.Validators.Interfaces;

public interface IValidatorBuilder
{
    public IValidator GetValidator(ValidatorType type);
}