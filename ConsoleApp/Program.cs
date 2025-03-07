using FibonachiCalculator;
    
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n:");
            string? parameter = Console.ReadLine();
            int numberParameter = int.Parse(parameter!);
            FibonachiCalculator calculator = new FibonachiCalculator();
            int result = calculator.Calculate(FibonachiCalculator);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}