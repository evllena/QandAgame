using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
    public class Game
    {
        private List<Question> questions;
        private Question currentQuestion;
        private int allQuestionsCount;
        private User user;
        private int questionNumber = 0;

        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.GetAll();
            allQuestionsCount = questions.Count;
        }

        public Question PopRandomQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomIndex];
            questions.RemoveAt(randomIndex);
            questionNumber++;
            return currentQuestion;
        }

        public string CalculateDiagnose()
        {
            DiagnoseCalculator.Calculate(user, allQuestionsCount);

            return user.Name + ", Ваш диагноз: " + user.Diagnose;
        }


        public bool End()
        {
            return questions.Count == 0;
        }
        

        public void AcceptAnswer(int userAnswer)
        {
        var rightAnswer = currentQuestion.Answer;
        if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();

            }
        }

        public string GetQuestionNumberInfo()
        {
            return ("Вопрос №" + questionNumber);
        }
        
    }
}
