namespace Taks1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Въведете радиуса на основата на цилиндъра (R): ");
            double R = double.Parse(Console.ReadLine());

            Console.Write("Въведете височината на цилиндъра (H): ");
            double H = double.Parse(Console.ReadLine());

            // Изчисление на околната повърхнина
            double s = 2 * Math.PI * R * H;

            // Изчисление на пълната повърхнина
            double S = s + 2 * Math.PI * R * R;

            Console.WriteLine($"Околната повърхнина на цилиндъра е: {s}");
            Console.WriteLine($"Пълната повърхнина на цилиндъра е: {S}");
        }
    }

}
