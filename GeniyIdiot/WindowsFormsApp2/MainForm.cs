using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormApp

{
    public partial class MainForm : Form
    {
        private Game game;
        private User user;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            user = new User("Unknown");
            var userInfoForm = new UserInfoForm(user);
            var result = userInfoForm.ShowDialog(this);
            if (result != DialogResult.OK)
            {
                Close();
            }
            else
            {
                game = new Game(user);

                ShowNextQuestion();
            }

            userAnswerTextBox.Focus();
            
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.PopRandomQuestion();
            questionTextLabel.Text = currentQuestion.Text;
            questionNumberLabel.Text = game.GetQuestionNumberInfo();
            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var isValid = User.IsValid(userAnswerTextBox.Text, out var userAnswer, out var errorMessage);
            
            if (!isValid)
            {
                MessageBox.Show(errorMessage);
                userAnswerTextBox.Clear();
                userAnswerTextBox.Focus();
                return;
            }
           
            game.AcceptAnswer(userAnswer);
            
            if (game.End())
            {
                var diagnose = game.CalculateDiagnose();
                
                MessageBox.Show(diagnose);

                UserResultsStorage.Add(user);

                return;
            }
            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
            ShowNextQuestion();
        }

        private void statisticsStripMenuItem_Click(object sender, EventArgs e)
        {
            var statisticsForm = new UserStatisticsForm();
            statisticsForm.ShowDialog(this);

        }

        private void createNewQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddQuestionForm();
            addQuestionForm.ShowDialog(this);
            var result = addQuestionForm.ShowDialog(this);
            if (result != DialogResult.OK)
            {
                Close();
            }
        }
    }
}
