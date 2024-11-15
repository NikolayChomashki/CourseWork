using System.Globalization;

namespace Task6
{
    class Program
    {
        static string ExtractBirthDate(string egn)
        {
            int year = int.Parse(egn.Substring(0, 2));
            int month = int.Parse(egn.Substring(2, 2));
            int day = int.Parse(egn.Substring(4, 2));

            if (month > 40)
            {
                year += 2000;
                month -= 40;
            }
            else if (month > 20)
            {
                year += 1800;
                month -= 20;
            }
            else
            {
                year += 1900;
            }

            return $"{day:D2}.{month:D2}.{year}";
        }

        static string GetBirthDateFormatted(string egn)
        {
            int year = int.Parse(egn.Substring(0, 2));
            int month = int.Parse(egn.Substring(2, 2));
            int day = int.Parse(egn.Substring(4, 2));

            if (month > 40)
            {
                year += 2000;
                month -= 40;
            }
            else if (month > 20)
            {
                year += 1800;
                month -= 20;
            }
            else
            {
                year += 1900;
            }

            string dayWithSuffix = AddDaySuffix(day);

            DateTime birthDate = new DateTime(year, month, day);
            string numericDate = $"{dayWithSuffix} {birthDate.ToString("MMMM yyyy'г.'", new CultureInfo("bg-BG"))}";
            string textDate = $"{DayToText(day)} {birthDate.ToString("MMMM yyyy'г.'", new CultureInfo("bg-BG"))}";

            return $"Дата на раждане: {numericDate}\nДата на раждане: {textDate}";
        }

        static string AddDaySuffix(int day)
        {
            if (day == 1 || day == 21 || day == 31) return $"{day}-ви";
            if (day == 2 || day == 22) return $"{day}-ри";
            if (day == 3 || day == 23) return $"{day}-ти";
            return $"{day}-ти";
        }

        static string DayToText(int day)
        {
            string[] dayWords = {
            "нула", "първи", "втори", "трети", "четвърти", "пети", "шести", "седми", "осми", "девети", "десети",
            "единадесети", "дванадесети", "тринадесети", "четиринадесети", "петнадесети", "шестнадесети",
            "седемнадесети", "осемнадесети", "деветнадесети", "двадесети", "двадесет и първи", "двадесет и втори",
            "двадесет и трети", "двадесет и четвърти", "двадесет и пети", "двадесет и шести", "двадесет и седми",
            "двадесет и осми", "двадесет и девети", "тридесети", "тридесет и първи"
        };
            return dayWords[day];
        }

        static string GetGender(string egn)
        {
            int genderDigit = int.Parse(egn.Substring(8, 1));
            return genderDigit % 2 == 0 ? "Мъжът" : "Жената";
        }

        static void Main()
        {
            Console.Write("Въведете ЕГН: ");
            string egn = Console.ReadLine();


            string birthDate = ExtractBirthDate(egn);


            string formattedOutput = GetBirthDateFormatted(egn);


            string gender = GetGender(egn);
            string bornText = gender == "Мъжът" ? "роден" : "родена";


            Console.WriteLine("Дата на раждане:  {0}", birthDate);
            Console.WriteLine(formattedOutput);
            Console.WriteLine($"{gender} е {bornText} на {birthDate}г.");
        }
    }

}
