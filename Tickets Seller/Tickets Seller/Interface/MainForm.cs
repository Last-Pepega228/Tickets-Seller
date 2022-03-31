using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tickets_Seller
{
    public partial class MainForm : Form
    {
        string[] Group =
        {
            "The Hatters",
            "Little Big",
            "Ленинград",
            "БИ-2",
            "Руки Вверх"
        };
        public MainForm()
        {
            InitializeComponent();
            int i;
            for (i = 0; i < 5; i++)
            {
                GroupBox.Items.Add(Group[i]);
            }
        }

        private void Inquirybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InquiryForm inquiry = new InquiryForm();
            inquiry.Show();
        }

        private void GoToAutorizationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void GoToRegistrationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            switch(GroupBox.SelectedIndex)
            {
                case 0: this.Hide(); 
                    TheHattersForm hattersForm = new TheHattersForm();
                    hattersForm.Show();
                    break;
                case 1: this.Hide();
                    LittleBigForm littleBigForm = new LittleBigForm();
                    littleBigForm.Show();
                    break;
                case 2: this.Hide(); 
                    LeningradForm leningradForm = new LeningradForm();
                    leningradForm.Show();
                    break;
                case 3: this.Hide();
                    BI_2Form bI_2Form = new BI_2Form();
                    bI_2Form.Show();
                    break;
                case 4: this.Hide(); 
                    RukiVverhForm rukiVverhForm = new RukiVverhForm();
                    rukiVverhForm.Show();
                    break;
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
