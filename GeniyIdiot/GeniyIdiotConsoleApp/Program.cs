using GeniyIdiot.Common;
using System;
using System.Collections.Generic;

namespace GeniyIdiot
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Введите имя и фамилию");
            
            var user = new User(Console.ReadLine());
            
            var game = new Game(user);
            
            

            while(!game.End())
            {
                var currentQuestion = game.PopRandomQuestion();
                Console.WriteLine(game.GetQuestionNumberInfo());
                
                Console.WriteLine(currentQuestion.Text);

                var userAnswer = GetUserAnswer();

                game.AcceptAnswer(userAnswer);
                

            }

            Console.WriteLine("Количество правильных ответов: " + user.CountRightAnswers);

            var diagnose = game.CalculateDiagnose();

            Console.WriteLine(diagnose);

            UserResultsStorage.Add(user);

            Console.WriteLine("Показать таблицу результатов? Введите да/нет");

            var userInput = Console.ReadLine();

            if (userInput.ToLower() == "да")
            {
                var users = UserResultsStorage.GetAll();
                ShowUserResults(users);
            }

            Console.WriteLine("Хотите добавить новый вопрос? Введите да/нет");

            userInput = Console.ReadLine();

            if (userInput.ToLower() == "да")
            {
                Console.WriteLine("Введите вопрос");
                var text = Console.ReadLine();
                Console.WriteLine("Введите численный ответ");
                var answer = Convert.ToInt32(Console.ReadLine());
                var newUserQuestion = new Question(text, answer);
                QuestionsStorage.Add(newUserQuestion);

            }

        }

        private static void ShowUserResults(List<User> users)
        {
            Console.WriteLine("{0,-20}{1,-30}{2,-10}", "Имя:", "Кол-во правильных ответов:", "Диагноз:");

            foreach (var user in users)
            {
                Console.WriteLine("{0,-20}{1,-30}{2,-10}", user.Name, user.CountRightAnswers, user.Diagnose);
            }
        }

        private static int GetUserAnswer()
        {
            var answer = Console.ReadLine();
            
            while (true)
            {
                if (User.IsValid(answer, out var userAnswer, out var errorMessage))
                {
                    return Convert.ToInt32(userAnswer);
                }
                else
                {
                    Console.WriteLine(errorMessage);
                }
                answer = Console.ReadLine();
            }

        }
    }   
}