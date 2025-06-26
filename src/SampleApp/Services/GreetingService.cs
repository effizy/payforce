namespace SampleApp.Services;

public class GreetingService
{
    public string Greet(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty or whitespace.", nameof(name));
        }

        return $"Hello, {name}!";
    }
}