using FibonachiCalculator;
using Validation;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Порядок чисел Фибоначчи");
            string parameter;
            var validator = new Validator();
            do
            {
                parameter = Console.ReadLine()!;
            } while (!validator.IsNumber(parameter));
            var calculator = new FibonachiMath();
            var result = calculator.Calculate(int.Parse(parameter));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}