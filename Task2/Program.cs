namespace Task2
{
    class Program
    {


        static void Main()
        {

            Console.Write("Въведете стойност за s (true или false): ");
            bool s = bool.Parse(Console.ReadLine());

            Console.Write("Въведете стойност за t (true или false): ");
            bool t = bool.Parse(Console.ReadLine());


            bool result = (!(s || t) && s) || !t;

            // Извеждане на резултата
            Console.WriteLine("Резултатът от израза (!(s || t) && s|| !t) е: " + result);
        }
    }

}
