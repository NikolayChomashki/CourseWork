namespace Task5
{
    class Program
    {
        // Метод за сумата на елементи по-големи от k
        static int Sum(int[] array, int k)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num > k)
                    sum += num;
            }
            return sum;
        }

        // Метод за броя на трицифрени числа с четна сума на цифрите
        static int CountEvenDigitSum(int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num >= 100 && num <= 999)
                {

                    int sumDigits = (num / 100) + ((num / 10) % 10) + (num % 10);
                    if (sumDigits % 2 == 0)
                        count++;
                }
            }
            return count;
        }

        static void Main()
        {
            int n;
            Console.Write("Въведете дължината на масива (между 2 и 50): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 50)
            {
                Console.WriteLine("Невалидна дължина. Въведете отново.");
            }

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведете елемент {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Моля, въведете валидно цяло число.");
                }
            }

            int k;
            Console.Write("Въведете стойност за k: ");
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.WriteLine("Моля, въведете валидно цяло число за k.");
            }

            // Извеждаме резултатите
            Console.WriteLine("Сума на елементите по-големи от k: {0}", Sum(array, k));
            Console.WriteLine("Брой трицифрени числа с четна сума на цифрите: {0}", CountEvenDigitSum(array));
        }
    }

}
