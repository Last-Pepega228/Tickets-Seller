using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tickets_Seller
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Autorizationbutton_Click(object sender, EventArgs e) //метод для подтверждения авторизации
        {
            if (EmailText.Text != null && EmailText.Text != "" && PasswordText.Text != null && PasswordText.Text != "") //Проверка на заполнение полей e-mail и пароль
            {
                MainForm main = new MainForm();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Поля Пароль и Email должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoToRegistrationbutton_Click(object sender, EventArgs e) //метод для перехода на форму регистрации
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
            this.Close();
        }
    }
}
