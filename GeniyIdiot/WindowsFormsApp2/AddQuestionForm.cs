using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormApp
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionTextBox.Text == "" || answerTextBox.Text == "")
            {
                MessageBox.Show("Необходимо ввести текст вопроса и численный ответ!");
                return;
            }

            var isValid = User.IsValid(answerTextBox.Text, out var answer, out var errorMessage);

            if (!isValid)
            {
                MessageBox.Show(errorMessage);
                answerTextBox.Clear();
                answerTextBox.Focus();
                return;
            }

            Question question = new Question(questionTextBox.Text, answer);
            QuestionsStorage.Add(question);
        }
    }
}
