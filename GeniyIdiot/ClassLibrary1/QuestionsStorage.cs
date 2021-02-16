using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        public static string path = "Questions.json";
        public static void Add(Question newQuestion)
        {
            var questions = GetAll();
            questions.Add(newQuestion);
            Save(questions);
            
        }
        
        private static void Save(List<Question> questions)
        {
            var serializedData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replace(path, serializedData);
        }

        public static List<Question> GetAll()
        {
            List<Question> questions = new List<Question>();

            if (FileProvider.Exists(path) == false)
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

                Save(questions);
            }

            else
            {
                var fileData = FileProvider.Show(path);

                questions = JsonConvert.DeserializeObject<List<Question>>(fileData);

            }
            return questions;

        }

    }
}
