﻿
using ModelsLibrary;
using System;
using System.Windows.Forms;

namespace MagazineApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Clear();
            PasswordTextBox.Clear();
        }

        private void login_Click(object sender, EventArgs e)
        {
            LoginInfo.UserName = UserNameTextBox.Text;
            LoginInfo.Password = PasswordTextBox.Text;

            if (IsAuthenticated(UserNameTextBox.Text, PasswordTextBox.Text))
            {

            }

        }


        private bool IsAuthenticated(string userName, string password)
        {
            //Use BackEnd service


            return true;
        }
    }
}
