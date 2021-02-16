using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormApp
{
    public partial class UserInfoForm : Form
    {
        private User user;

        public UserInfoForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            userNameTextBox.Focus();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Необходимо ввести имя!");
                return;
            }

            user.Name = userNameTextBox.Text;
            Close();
        }
    }
}
