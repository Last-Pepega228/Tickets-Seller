
namespace Tickets_Seller
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoToAutorizationbutton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.Emailtext = new System.Windows.Forms.TextBox();
            this.RepeatPasswordtext = new System.Windows.Forms.TextBox();
            this.Surnametext = new System.Windows.Forms.TextBox();
            this.Passwordtext = new System.Windows.Forms.TextBox();
            this.Nametext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(169)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.GoToAutorizationbutton);
            this.panel1.Controls.Add(this.RegistrationButton);
            this.panel1.Controls.Add(this.Emailtext);
            this.panel1.Controls.Add(this.RepeatPasswordtext);
            this.panel1.Controls.Add(this.Surnametext);
            this.panel1.Controls.Add(this.Passwordtext);
            this.panel1.Controls.Add(this.Nametext);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 541);
            this.panel1.TabIndex = 0;
            // 
            // GoToAutorizationbutton
            // 
            this.GoToAutorizationbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(56)))));
            this.GoToAutorizationbutton.FlatAppearance.BorderSize = 2;
            this.GoToAutorizationbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(56)))));
            this.GoToAutorizationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToAutorizationbutton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoToAutorizationbutton.Location = new System.Drawing.Point(160, 478);
            this.GoToAutorizationbutton.Name = "GoToAutorizationbutton";
            this.GoToAutorizationbutton.Size = new System.Drawing.Size(140, 44);
            this.GoToAutorizationbutton.TabIndex = 12;
            this.GoToAutorizationbutton.Text = "Войти";
            this.GoToAutorizationbutton.UseVisualStyleBackColor = true;
            this.GoToAutorizationbutton.Click += new System.EventHandler(this.GoToAutorizationbutton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(115)))));
            this.RegistrationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(66)))));
            this.RegistrationButton.FlatAppearance.BorderSize = 2;
            this.RegistrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(66)))));
            this.RegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrationButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrationButton.Location = new System.Drawing.Point(122, 428);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(211, 44);
            this.RegistrationButton.TabIndex = 11;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = false;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // Emailtext
            // 
            this.Emailtext.Location = new System.Drawing.Point(273, 250);
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(152, 27);
            this.Emailtext.TabIndex = 10;
            // 
            // RepeatPasswordtext
            // 
            this.RepeatPasswordtext.Location = new System.Drawing.Point(273, 354);
            this.RepeatPasswordtext.Name = "RepeatPasswordtext";
            this.RepeatPasswordtext.Size = new System.Drawing.Size(152, 27);
            this.RepeatPasswordtext.TabIndex = 9;
            this.RepeatPasswordtext.UseSystemPasswordChar = true;
            // 
            // Surnametext
            // 
            this.Surnametext.Location = new System.Drawing.Point(273, 198);
            this.Surnametext.Name = "Surnametext";
            this.Surnametext.Size = new System.Drawing.Size(152, 27);
            this.Surnametext.TabIndex = 8;
            // 
            // Passwordtext
            // 
            this.Passwordtext.Location = new System.Drawing.Point(273, 304);
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.Size = new System.Drawing.Size(152, 27);
            this.Passwordtext.TabIndex = 7;
            this.Passwordtext.UseSystemPasswordChar = true;
            // 
            // Nametext
            // 
            this.Nametext.Location = new System.Drawing.Point(273, 147);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(152, 27);
            this.Nametext.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(74, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Повторите пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(74, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(74, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(74, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 541);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets Seller";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GoToAutorizationbutton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TextBox Emailtext;
        private System.Windows.Forms.TextBox RepeatPasswordtext;
        private System.Windows.Forms.TextBox Surnametext;
        private System.Windows.Forms.TextBox Passwordtext;
        private System.Windows.Forms.TextBox Nametext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}