class UserInput
{
    public static int IntInput(bool isPositive = false, string prompt = "Введите целое число: ")
    {
        string? userInput;
        bool isValidInput = false;
        int result = 0;
        
        while (!isValidInput)
        {
            Console.Write(prompt);
            userInput = Console.ReadLine();

            if (int.TryParse(userInput, out result))
            {
                if (isPositive && result < 0)
                {
                    Console.WriteLine("Число должно быть положительным!");
                }
                else
                {
                    isValidInput = true;
                }
            }
            else
            {
                Console.WriteLine("Введенное значение не является целым числом!");
            }
        }
        return result;
    }

    public static double DoubleInput(bool isPositive = false, string prompt = "Введите число: ")
    {
        string? userInput;
        bool isValidInput = false;
        double result = 0;

        while (!isValidInput)
        {
            Console.Write(prompt);
            userInput = Console.ReadLine();

            if (double.TryParse(userInput, out result))
            {
                if (isPositive && result < 0)
                {
                    Console.WriteLine("Число должно быть положительным!");
                }
                else
                {
                    isValidInput = true;
                }
            }
            else
            {
                Console.WriteLine("Введенное значение не является числом!");
            }
        }
        return result;
    }
}