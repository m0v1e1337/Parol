using System;
using System.Text.RegularExpressions;

namespace Parol
{
    public class PasswordChecker
    {
        public int CheckPassword(string password)
        {
            int score = 0;
            if (Regex.IsMatch(password, @"\d"))
                score++;
            if (Regex.IsMatch(password, @"[a-z]"))
                score++;
            if (Regex.IsMatch(password, @"[A-Z]"))
                score++;
            if (Regex.IsMatch(password, @"\W"))
                score++;
            if (password.Length > 10)
                score++;
            return score;
        }

        public static void Main(string[] args)
        {
            string[] passwords = { "Password123", "password123", "PASSWORD123", "Password!123", "LongPassword123!", "short" };

            PasswordChecker passwordChecker = new PasswordChecker();

            foreach (string password in passwords)
            {
                int score = passwordChecker.CheckPassword(password);
                Console.WriteLine($"Пароль: {password} - Счет: {score}");
            }

            Console.WriteLine("Нажмите Enter чтобы выйти...");
            Console.ReadLine();
        }
    }
}
