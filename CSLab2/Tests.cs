using CSLab2;

class Tests
{
    public static void Test_1_1()
    {
        Console.WriteLine("Тест задания 1.1(базовый класс)");

        Console.WriteLine("  Тест конструктора и метода ToString:");
        for (int i = 0; i < 3; i++)
        {
            int x = UserInput.IntInput(false, "    Введите целое число x: ");
            int y = UserInput.IntInput(false, "    Введите целое число y: ");
            int z = UserInput.IntInput(false, "    Введите целое число z: ");
            Number number = new(x, y, z);
            Console.WriteLine($"    {number}");
        }
        Console.WriteLine("  Тест метода конструктора и метода ToString завершен");

        Console.WriteLine("  Тест метода Max:");
        for (int i = 0; i < 3; i++)
        {
            int x = UserInput.IntInput(false, "    Введите целое число x: ");
            int y = UserInput.IntInput(false, "    Введите целое число y: ");
            int z = UserInput.IntInput(false, "    Введите целое число z: ");
            Number number = new(x, y, z);
            Console.WriteLine($"    max = {number.Max()}");
        }
        Console.WriteLine("  Тест метода конструктора и метода ToString завершен");

        Console.WriteLine("Тест задания 1.1 завершен");
    }

    public static void Test_1_2()
    {
        Console.WriteLine("Тест задания 1.2(дочерний класс)"); 

        Console.WriteLine("  Тест конструктора и метода ToString:");
        for (int i = 0; i < 3; i++)
        {
            int x = UserInput.IntInput(true, "    Введите длинну 1 стороны: ");
            int y = UserInput.IntInput(true, "    Введите длинну 2 стороны: ");
            int z = UserInput.IntInput(true, "    Введите длинну 3 стороны: ");
            Triangle triangle = new(x, y, z);
            Console.WriteLine($"    {triangle}");
        }
        Console.WriteLine("  Тест метода конструктора и метода ToString завершен");

        Console.WriteLine("  Тест метода Perimeter:");
        for (int i = 0; i < 3; i++)
        {
            int x = UserInput.IntInput(true, "    Введите длинну 1 стороны: ");
            int y = UserInput.IntInput(true, "    Введите длинну 2 стороны: ");
            int z = UserInput.IntInput(true, "    Введите длинну 3 стороны: ");
            Triangle triangle = new(x, y, z);
            Console.WriteLine($"    p = {triangle.Perimeter()}");
        }
        Console.WriteLine("  Тест метода Perimeter завершен");

        Console.WriteLine("  Тест метода Square:");
        for (int i = 0; i < 3; i++)
        {
            int x = UserInput.IntInput(true, "    Введите длинну 1 стороны: ");
            int y = UserInput.IntInput(true, "    Введите длинну 2 стороны: ");
            int z = UserInput.IntInput(true, "    Введите длинну 3 стороны: ");
            Triangle triangle = new(x, y, z);
            Console.WriteLine($"    s = {triangle.Square()}");
        }
        Console.WriteLine("  Тест метода Square завершен");

        Console.WriteLine("Тест задания 1.2 завершен");
    }

    public static void Test_2()
    {
        Console.WriteLine("Тест задания 2");

        Console.WriteLine("  Тест конструктора и метода ToString:");
        for (int i = 0; i < 3; i++)
        {
            double x = UserInput.DoubleInput(false, "    Введите координату x: ");
            double y = UserInput.DoubleInput(false, "    Введите координату y: ");
            CSLab2.Point point = new(x, y);
            Console.WriteLine($"    {point}");
        }
        Console.WriteLine("  Тест метода конструктора и метода ToString завершен");

        Console.WriteLine("  Тест метода Distance:");
        for (int i = 0; i < 3; i++) 
        {
            double x = UserInput.DoubleInput(false, "    Введите координату x: ");
            double y = UserInput.DoubleInput(false, "    Введите координату y: ");
            CSLab2.Point point1 = new(x, y);

            x = UserInput.DoubleInput(false, "    Введите координату x второй точки: ");
            y = UserInput.DoubleInput(false, "    Введите координату y второй тчоки: ");
            CSLab2.Point point2 = new(x, y);

            Console.WriteLine($"    Расстояние между точками равно {point1.Distance(point2)}");
        }
        Console.WriteLine("  Тест метода Distance завершен");

        Console.WriteLine("Тест задания 2 завершен");
    }

    public static void Test_3()
    {
        Console.WriteLine("Тест задания 3");

        Console.WriteLine("  Тест ++:");
        for (int i = 0; i < 3; i++)
        {
            double x = UserInput.DoubleInput(false, "    Введите координату x: ");
            double y = UserInput.DoubleInput(false, "    Введите координату y: ");
            CSLab2.Point point = new(x, y);
            point++;
            Console.WriteLine($"    {point}");
        }
        Console.WriteLine("  Тест ++ завершен");

        Console.WriteLine("  Тест --:");
        for (int i = 0; i < 3; i++)
        {
            double x = UserInput.DoubleInput(false, "    Введите координату x: ");
            double y = UserInput.DoubleInput(false, "    Введите координату y: ");
            CSLab2.Point point = new(x, y);
            point--;
            Console.WriteLine($"    {point}");
        }
        Console.WriteLine("  Тест -- завершен");

        Console.WriteLine("  Тест сложения point и point:");
        for (int i = 0; i < 3; i++)
        {
            double x = UserInput.DoubleInput(false, "    Введите координату x: ");
            double y = UserInput.DoubleInput(false, "    Введите координату y: ");
            CSLab2.Point point1 = new(x, y);

            x = UserInput.DoubleInput(false, "    Введите координату x второй точки: ");
            y = UserInput.DoubleInput(false, "    Введите координату y второй точки: ");
            CSLab2.Point point2 = new(x, y);

            Console.WriteLine($"    point + point = {point1 + point2}");
        }
        Console.WriteLine("  Тест сложения point и point завершен");

        Console.WriteLine("  Тест сложения point и int:");
        for (int i = 0; i < 3; i++)
        {
            double x = UserInput.DoubleInput(false, "    Введите координату x: ");
            double y = UserInput.DoubleInput(false, "    Введите координату y: ");
            CSLab2.Point point = new(x, y);

            int n = UserInput.IntInput(false, "    Введите целое число n: ");

            Console.WriteLine($"    point + n = {point + n}");
        }
        Console.WriteLine("  Тест сложения point и int завершен");

        Console.WriteLine("  Тест сложения int и point:");
        for (int i = 0; i < 3; i++)
        {
            double x = UserInput.DoubleInput(false, "    Введите координату x: ");
            double y = UserInput.DoubleInput(false, "    Введите координату y: ");
            CSLab2.Point point = new(x, y);

            int n = UserInput.IntInput(false, "    Введите целое число n: ");

            Console.WriteLine($"    n + point = {n + point}");
        }
        Console.WriteLine("  Тест сложения int и point завершен");

        Console.WriteLine("  Тест явного приведения к int:");
        for (int i = 0; i < 3; i++)
        {
            double x = UserInput.DoubleInput(false, "    Введите координату x: ");
            double y = UserInput.DoubleInput(false, "    Введите координату y: ");
            CSLab2.Point point = new(x, y);

            int n = (int)point;

            Console.WriteLine($"    n = {n}");
        }
        Console.WriteLine("  Тест явного приведения к int завершен");

        Console.WriteLine("  Тест неявного приведения к double:");
        for (int i = 0; i < 3; i++)
        {
            double x = UserInput.DoubleInput(false, "    Введите координату x: ");
            double y = UserInput.DoubleInput(false, "    Введите координату y: ");
            CSLab2.Point point = new(x, y);

            double n = point;

            Console.WriteLine($"    n = {n}");
        }
        Console.WriteLine("  Тест неявного приведения к double завершен");

        Console.WriteLine("Тест задания 3 завершен");
    }
}
