namespace HelloApp;

internal static class Program
{
    private static void Main()
    {
        Greet();
        GreetWhite();
        GreetBlack();
    }

    private static void Greet()
    {
        Console.WriteLine("hello everyone");
    }

    private static void GreetWhite()
    {
        Console.WriteLine("hello white");
    }

    private static void GreetBlack()
    {
        Console.WriteLine("hello black");
    }
}

