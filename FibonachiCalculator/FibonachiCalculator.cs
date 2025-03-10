namespace FibonachiCalculator
{
    public class FibonachiMath
    {
        public int Calculate(int numberFibonachi)
        {
            if (numberFibonachi == 0) return 0;
            int firstNumber = -1;     
            int SecondNumber = 1;
            for (int i = 1; i < numberFibonachi + 2; i++)    //для исправления погрешности и старта с 0 1 добавлено -1 и +2
            {
                int sum = firstNumber + SecondNumber;
                firstNumber = SecondNumber;
                SecondNumber = sum;
                Console.WriteLine(SecondNumber);             
            }
            return numberFibonachi;
        }
        
        
        /*do
        {
            numberFibonachi--;

            double First = Math.Pow(((1 + Math.Sqrt(5)) / 2), numberFibonachi);
            double Second = Math.Pow(((1 - Math.Sqrt(5)) / 2), numberFibonachi);
            double Result = (First - Second) / Math.Sqrt(5);

            int a = (int)Result;

            Console.WriteLine(a);
        }

        while (numberFibonachi > 0);*/
    }


}

