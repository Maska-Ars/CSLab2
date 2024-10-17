using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Tests
{
    UserInput input = new UserInput();

    public void Test_1_1()
    {
        Console.WriteLine("Тест задания 1.1(базовый класс)");

        Console.WriteLine("  Тест конструктора и метода ToString:");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(false, "    Введите целое число x: ");
            int y = input.intInput(false, "    Введите целое число y: ");
            int z = input.intInput(false, "    Введите целое число z: ");
            Number number = new Number(x, y, z);
            Console.WriteLine($"    {number}");
        }
        Console.WriteLine("  Тест метода конструктора и метода ToString завершен");

        Console.WriteLine("  Тест метода Max:");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(false, "    Введите целое число x: ");
            int y = input.intInput(false, "    Введите целое число y: ");
            int z = input.intInput(false, "    Введите целое число z: ");
            Number number = new Number(x, y, z);
            Console.WriteLine($"    max = {number.Max()}");
        }
        Console.WriteLine("  Тест метода конструктора и метода ToString завершен");

        Console.WriteLine("Тест задания 1.1 завершен");
    }

    public void Test_1_2()
    {
        Console.WriteLine("Тест задания 1.2(дочерний класс)");
        

        Console.WriteLine("  Тест конструктора и метода ToString:");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(true, "    Введите длинну 1 стороны: ");
            int y = input.intInput(true, "    Введите длинну 2 стороны: ");
            int z = input.intInput(true, "    Введите длинну 3 стороны: ");
            Triangle triangle = new Triangle(x, y, z);
            Console.WriteLine($"    {triangle}");
        }
        Console.WriteLine("  Тест метода конструктора и метода ToString завершен");


        Console.WriteLine("  Тест метода Perimeter:");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(true, "    Введите длинну 1 стороны: ");
            int y = input.intInput(true, "    Введите длинну 2 стороны: ");
            int z = input.intInput(true, "    Введите длинну 3 стороны: ");
            Triangle triangle = new Triangle(x, y, z);
            Console.WriteLine($"    p = {triangle.Perimeter()}");
        }
        Console.WriteLine("  Тест метода Perimeter завершен");


        Console.WriteLine("  Тест метода Square:");
        for (int i = 0; i < 3; i++)
        {
            int x = input.intInput(true, "    Введите длинну 1 стороны: ");
            int y = input.intInput(true, "    Введите длинну 2 стороны: ");
            int z = input.intInput(true, "    Введите длинну 3 стороны: ");
            Triangle triangle = new Triangle(x, y, z);
            Console.WriteLine($"    s = {triangle.Square()}");
        }
        Console.WriteLine("  Тест метода Square завершен");

        Console.WriteLine("Тест задания 1.2 завершен");
    }

    public void Test_2()
    {
        Console.WriteLine("Тест задания 2");

        Console.WriteLine("  Тест конструктора и метода ToString:");
        for (int i = 0; i < 3; i++)
        {
            double x = input.doubleInput(false, "    Введите координату x: ");
            double y = input.doubleInput(false, "    Введите координату y: ");
            Point point = new Point(x, y);
            Console.WriteLine($"    {point}");
        }
        Console.WriteLine("  Тест метода конструктора и метода ToString завершен");

        Console.WriteLine("  Тест метода Distance:");
        for (int i = 0; i < 3; i++) 
        {
            double x = input.doubleInput(false, "    Введите координату x: ");
            double y = input.doubleInput(false, "    Введите координату y: ");
            Point point = new Point(x, y);

            x = input.doubleInput(false, "    Введите координату x второй точки: ");
            y = input.doubleInput(false, "    Введите координату y второй тчоки: ");
            Point point2 = new Point(x, y);

            Console.WriteLine($"    Расстояние между точками равно {point.Distance(point2)}");
        }
        Console.WriteLine("  Тест метода Distance завершен");


        Console.WriteLine("Тест задания 2 завершен");
    }

    public void Test_3()
    {
        Console.WriteLine("Тест задания 3");

        Console.WriteLine("  Тест ++:");
        for (int i = 0; i < 3; i++)
        {
            double x = input.doubleInput(false, "    Введите координату x: ");
            double y = input.doubleInput(false, "    Введите координату y: ");
            Point point = new Point(x, y);
            point++;
            Console.WriteLine($"    {point}");
        }
        Console.WriteLine("  Тест ++ завершен");


        Console.WriteLine("  Тест --:");
        for (int i = 0; i < 3; i++)
        {
            double x = input.doubleInput(false, "    Введите координату x: ");
            double y = input.doubleInput(false, "    Введите координату y: ");
            Point point = new Point(x, y);
            point--;
            Console.WriteLine($"    {point}");
        }
        Console.WriteLine("  Тест -- завершен");


        Console.WriteLine("  Тест сложения point и point:");
        for (int i = 0; i < 3; i++)
        {
            double x = input.doubleInput(false, "    Введите координату x: ");
            double y = input.doubleInput(false, "    Введите координату y: ");
            Point point1 = new Point(x, y);

            x = input.doubleInput(false, "    Введите координату x второй точки: ");
            y = input.doubleInput(false, "    Введите координату y второй точки: ");
            Point point2 = new Point(x, y);

            Console.WriteLine($"    point + point = {point1 + point2}");
        }
        Console.WriteLine("  Тест сложения point и point завершен");


        Console.WriteLine("  Тест сложения point и int:");
        for (int i = 0; i < 3; i++)
        {
            double x = input.doubleInput(false, "    Введите координату x: ");
            double y = input.doubleInput(false, "    Введите координату y: ");
            Point point = new Point(x, y);

            int n = input.intInput(false, "    Введите целое число n: ");

            Console.WriteLine($"    point + n = {point + n}");
        }
        Console.WriteLine("  Тест сложения point и int завершен");


        Console.WriteLine("  Тест сложения int и point:");
        for (int i = 0; i < 3; i++)
        {
            double x = input.doubleInput(false, "    Введите координату x: ");
            double y = input.doubleInput(false, "    Введите координату y: ");
            Point point = new Point(x, y);

            int n = input.intInput(false, "    Введите целое число n: ");

            Console.WriteLine($"    n + point = {n + point}");
        }
        Console.WriteLine("  Тест сложения int и point завершен");


        Console.WriteLine("  Тест явного приведения к int:");
        for (int i = 0; i < 3; i++)
        {
            double x = input.doubleInput(false, "    Введите координату x: ");
            double y = input.doubleInput(false, "    Введите координату y: ");
            Point point = new Point(x, y);

            int n = (int)point;

            Console.WriteLine($"    n = {n}");
        }
        Console.WriteLine("  Тест явного приведения к int завершен");


        Console.WriteLine("  Тест неявного приведения к double:");
        for (int i = 0; i < 3; i++)
        {
            double x = input.doubleInput(false, "    Введите координату x: ");
            double y = input.doubleInput(false, "    Введите координату y: ");
            Point point = new Point(x, y);

            double n = point;

            Console.WriteLine($"    n = {n}");
        }
        Console.WriteLine("  Тест неявного приведения к double завершен");


        Console.WriteLine("Тест задания 3 завершен");
    }
}
