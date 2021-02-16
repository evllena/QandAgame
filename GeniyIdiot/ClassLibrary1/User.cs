using System;
using System.IO;

namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name;
        public int CountRightAnswers;
        public string Diagnose;

        public User(string name)
        {
            Name = name;
            CountRightAnswers = 0;
            Diagnose = "Не определен";
        }

        public void AcceptRightAnswer()
        {
            CountRightAnswers++;
        }

        public static bool IsValid(string answer, out int userAnswer, out string message)
        {
            userAnswer = 0;
            message = "";

            try
            {
                userAnswer = Convert.ToInt32(answer);
                return true;
            }
            catch (FormatException)
            {
                message = "Пожалуйста, введите число!";
                return false;
            }
            catch (OverflowException)
            {
                message = "Пожалуйста, введите число меньше, чем 10^9!";
                return false;
            }
        }
    }
}