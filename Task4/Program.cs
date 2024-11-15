namespace Task4
{
    using System;

    class Program
    {
        static void FindIntegerSolutions(int p, int q)
        {
            // Определяме стойностите на a, b, c и d
            int a = q - 4;
            int b = q - 3;
            int c = q - 2;
            int d = q - 1;

            // Показване на уравнението, което решаваме
            Console.WriteLine($"Решаваме уравнението: {a}x + {b}y + {c}z + {d} = 0 в интервала [{p}, {q}]");

            bool hasSolutions = false;

            // Обхождаме всички комбинации на x, y и z в интервала [p, q]
            for (int x = p; x <= q; x++)
            {
                for (int y = p; y <= q; y++)
                {
                    for (int z = p; z <= q; z++)
                    {
                        if (a * x + b * y + c * z + d == 0)
                        {
                            Console.WriteLine($"Решение: x = {x}, y = {y}, z = {z}");
                            hasSolutions = true;
                        }
                    }
                }
            }

            if (!hasSolutions)
            {
                Console.WriteLine("Няма намерени решения в зададения интервал.");
            }
        }

        static void Main()
        {
            Console.Write("Въведете начало на интервала p: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Въведете край на интервала q: ");
            int q = int.Parse(Console.ReadLine());

            // Решаваме уравнението с дадените p и q
            FindIntegerSolutions(p, q);
        }
    }

}
