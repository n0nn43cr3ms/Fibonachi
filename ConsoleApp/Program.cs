using FibonachiCalculator;
using Validation;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для рассчёта последовательности Фибоначчи");
            Console.WriteLine("Введите n: ");
            string parameter;
            var validator = new Validator();
            do
            {
                parameter = Console.ReadLine()!;
            } while (!validator.IsNumber(parameter));
            var calculator = new FibonachiMath();
            Console.WriteLine("Порядок чисел Фибоначчи ");
            var result = calculator.Calculate(int.Parse(parameter));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}