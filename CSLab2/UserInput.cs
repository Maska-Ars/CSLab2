using System;

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

    public static char CharInput()
    {
        Console.Write("Введите символ: ");
        string? user_input = Console.ReadLine();
        while (user_input == null || user_input.Length > 1 || user_input.Length == 0)
        {
            Console.Write("Введите 1 символ!: ");
            user_input = Console.ReadLine();
        }
        return user_input[0];

    }

    public static int[] RandomArrInput()
    {
        int arr_size = IntInput(true, "Введите размер массива: ");
        int[] arr = new int[arr_size];
        Random rand = new();
        for (int i = 0; i < arr_size; i++)
        {
            arr[i] = rand.Next(-arr_size, arr_size);
        }

        return arr;
    }

}