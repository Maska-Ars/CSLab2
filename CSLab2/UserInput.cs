using System;

class UserInput
{
    // Для ввода целых чисел
    public int intInput(bool isPositive = false, string text = "Введите целое число: ")
    {
        string user_input = "";
        bool b = false;

        while (b != true)
        {
            Console.Write(text);
            user_input = Console.ReadLine();
            b = int.TryParse(user_input, out int result2);
            if (b && isPositive)
            {
                int i = int.Parse(user_input);
                if (i < 0)
                {
                    b = false;
                    Console.WriteLine("Число должно быть положительным!");
                }
            }
            else if (!b) { Console.WriteLine("Введенное значение не является целым числом!"); }
        }
        return int.Parse(user_input);
    }

    // Для ввода дробных чисел
    public double doubleInput(bool isPositive = false, string text = "Введите целое число: ")
    {
        string user_input = "";
        bool b = false;

        while (b != true)
        {
            Console.Write(text);
            user_input = Console.ReadLine();
            b = double.TryParse(user_input, out double result2);
            if (b && isPositive)
            {
                double i = double.Parse(user_input);
                if (i < 0)
                {
                    b = false;
                    Console.WriteLine("Число должно быть положительным!");
                }
            }
            else if (!b) { Console.WriteLine("Введенное значение не является целым числом!"); }
        }
        return double.Parse(user_input);
    }

    // Для ввода 1 символа
    public char charInput()
    {
        Console.Write("Введите символ: ");
        string user_input = Console.ReadLine();
        while (user_input.Length > 1 || user_input.Length == 0)
        {
            Console.Write("Введите 1 символ!: ");
            user_input = Console.ReadLine();
        }
        return user_input[0];

    }

    // Для ввода массива заданной длинны и случайными числами
    public int[] randomArrInput()
    {
        int arr_size = intInput(true, "Введите размер массива: ");
        int[] arr = new int[arr_size];
        Random rand = new Random();
        for (int i = 0; i < arr_size; i++)
        {
            arr[i] = rand.Next(-arr_size, arr_size);
        }

        return arr;
    }

}