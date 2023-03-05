using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ДЗ_с_регулярными_выражениями_СиШарп_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1 (Проверка почты)
            string email = "nikita___@gmail.student";
            bool isValidEmail = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            Console.WriteLine(email);
            if (isValidEmail)
                Console.WriteLine("Почта введена правильно!\n");
            else
                Console.WriteLine("Почта введена неправильно!\n");
            #endregion
            #region Задание 2
            string text1 = "\nСейчас на моих часах показывается время: 20:17:33";
            var regex = new Regex(@"([01]?[0-9]|2[0-3]):([0-5][0-9]):([0-5][0-9])");
            Match match = regex.Match(text1);
            while(match.Success)
            {
                Console.WriteLine("Время: " + match.Value + "\nЕго индекс: " + match.Index);
                match=match.NextMatch();
            }
            #endregion
        }
    }
}
