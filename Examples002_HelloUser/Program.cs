internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Привет, введи своё имя!:");
        string name = Console.ReadLine();
        Console.WriteLine($"Здравствуй, {name}!");
    }
}