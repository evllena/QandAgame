using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormApp
{
    public partial class UserStatisticsForm : Form
    {
        public UserStatisticsForm()
        {
            InitializeComponent();
        }

        private void UserStatisticsForm_Load(object sender, EventArgs e)
        {
            var results = UserResultsStorage.GetAll();
            foreach (var result in results)
            {
                statisticsDataGridView.Rows.Add(result.Name, result.CountRightAnswers, result.Diagnose);

            }
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
