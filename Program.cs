internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the temperature in celsius (-100 to 100): ");
        float celsius = float.Parse(Console.ReadLine());

        float fahrenheit = (celsius * 9 / 5) + 32;

        if (celsius >= -100 && celsius <= 100)
        {
            Console.WriteLine($"\nTemperature in Fahrenheit: {fahrenheit}");
        }
        
    }
}