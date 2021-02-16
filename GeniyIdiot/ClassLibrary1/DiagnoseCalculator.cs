using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
    public class DiagnoseCalculator
    {
        public static void Calculate(User user, int countQuestions)
        {
            var percentRightAnswers = (user.CountRightAnswers * 100.0) / countQuestions;

            var diagnoses = GetDiagnoses();

            for (int i = 0; i < diagnoses.Count; i++)
            {
                if (percentRightAnswers <= diagnoses[i].Percent)
                {
                    user.Diagnose = diagnoses[i].Name;
                    return;
                }

            }
        }

        public static List<Diagnose> GetDiagnoses()
        {
            var diagnoses = new List<Diagnose>();
            diagnoses.Add(new Diagnose("Идиот", 0));
            diagnoses.Add(new Diagnose("Кретин", 20));
            diagnoses.Add(new Diagnose("Дурак", 40));
            diagnoses.Add(new Diagnose("Нормальный", 60));
            diagnoses.Add(new Diagnose("Талант", 80));
            diagnoses.Add(new Diagnose("Гений", 100));

            return diagnoses;
        }
    }
}
