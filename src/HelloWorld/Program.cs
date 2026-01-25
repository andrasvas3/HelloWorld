namespace HelloWorld;

class Program
{
    static string SayHello(string name)
    {
        return $"Hello {name}!";
    }

    static void Main()
    {
        Console.WriteLine(SayHello("World"));
    }
}
