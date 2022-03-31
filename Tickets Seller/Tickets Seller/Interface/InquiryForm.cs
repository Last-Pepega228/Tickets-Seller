using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tickets_Seller
{
    public partial class InquiryForm : Form
    {
        public InquiryForm()
        {
            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e) //метод открытия главной формы
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }
    }
}
