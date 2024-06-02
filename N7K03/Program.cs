
Console.WriteLine("Enter your name:");
string userName = Console.ReadLine();

GreetUser(userName);

static void GreetUser(string someName)
{
    Console.WriteLine($"Hello, {someName}");
}