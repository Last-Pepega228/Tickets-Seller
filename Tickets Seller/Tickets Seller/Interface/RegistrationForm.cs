using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tickets_Seller
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (Nametext.Text != null && Nametext.Text != "" && Emailtext.Text != null && Emailtext.Text != "")
            {
                if (Passwordtext.Text != RepeatPasswordtext.Text)
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MainForm main = new MainForm();
                    main.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Поля Имя и Email должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoToAutorizationbutton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
