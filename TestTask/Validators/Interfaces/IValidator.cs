namespace TestTask.Validators.Interfaces;

public interface IValidator
{
    public bool IsValidPassword(ValidationRule rule, string password);
}