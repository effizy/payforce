using SampleApp.Services;

var service = new GreetingService();

Console.WriteLine("Please enter your name:");
var name = Console.ReadLine();

try
{
    var greeting = service.Greet(name!);
    Console.WriteLine(greeting);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}