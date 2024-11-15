namespace Task3
{
    class Program
    {
        static void Main()
        {
            double sum = 0;

            // 1) Сумиране отляво надясно
            for (int i = 1; i <= 100000; i++)
            {
                sum += (i % 2 == 0) ? -1.0 / i : 1.0 / i;
            }
            Console.WriteLine("Сумиране отляво надясно: {0}", sum);

            // 2) Сумиране отдясно наляво
            sum = 0;
            for (int i = 100000; i >= 1; i--)
            {
                sum += (i % 2 == 0) ? -1.0 / i : 1.0 / i;
            }
            Console.WriteLine("Сумиране отдясно наляво: {0}", sum);

            // 3) Положителни и отрицателни отделно (ляво надясно)
            double pos = 0, neg = 0;
            for (int i = 1; i <= 100000; i++)
            {
                if (i % 2 == 0)
                    neg += -1.0 / i;
                else
                    pos += 1.0 / i;
            }
            sum = pos + neg;
            Console.WriteLine("Положителни и отрицателни отделно: {0}", sum);

            // 4) Положителни и отрицателни отделно (дясно наляво)
            pos = 0;
            neg = 0;
            for (int i = 100000; i >= 1; i--)
            {
                if (i % 2 == 0)
                    neg += -1.0 / i;
                else
                    pos += 1.0 / i;
            }
            sum = pos + neg;
            Console.WriteLine("Отделно дясно наляво: {0}", sum);
        }
    }

}
