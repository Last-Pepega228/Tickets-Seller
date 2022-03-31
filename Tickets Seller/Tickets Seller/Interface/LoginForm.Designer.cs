
namespace Tickets_Seller
{
    partial class LoginForm
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
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Autorizationbutton = new System.Windows.Forms.Button();
            this.GoToRegistrationbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(169)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.PasswordText);
            this.panel1.Controls.Add(this.EmailText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Autorizationbutton);
            this.panel1.Controls.Add(this.GoToRegistrationbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 447);
            this.panel1.TabIndex = 0;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(215, 204);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(187, 27);
            this.PasswordText.TabIndex = 6;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(215, 145);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(187, 27);
            this.EmailText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(84, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(134, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // Autorizationbutton
            // 
            this.Autorizationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(115)))));
            this.Autorizationbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(66)))));
            this.Autorizationbutton.FlatAppearance.BorderSize = 2;
            this.Autorizationbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(66)))));
            this.Autorizationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Autorizationbutton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Autorizationbutton.Location = new System.Drawing.Point(157, 302);
            this.Autorizationbutton.Name = "Autorizationbutton";
            this.Autorizationbutton.Size = new System.Drawing.Size(140, 44);
            this.Autorizationbutton.TabIndex = 1;
            this.Autorizationbutton.Text = "Войти";
            this.Autorizationbutton.UseVisualStyleBackColor = false;
            this.Autorizationbutton.Click += new System.EventHandler(this.Autorizationbutton_Click);
            // 
            // GoToRegistrationbutton
            // 
            this.GoToRegistrationbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(56)))));
            this.GoToRegistrationbutton.FlatAppearance.BorderSize = 2;
            this.GoToRegistrationbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(56)))));
            this.GoToRegistrationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToRegistrationbutton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoToRegistrationbutton.Location = new System.Drawing.Point(119, 352);
            this.GoToRegistrationbutton.Name = "GoToRegistrationbutton";
            this.GoToRegistrationbutton.Size = new System.Drawing.Size(211, 44);
            this.GoToRegistrationbutton.TabIndex = 0;
            this.GoToRegistrationbutton.Text = "Зарегистрироваться";
            this.GoToRegistrationbutton.UseVisualStyleBackColor = true;
            this.GoToRegistrationbutton.Click += new System.EventHandler(this.GoToRegistrationbutton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 447);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets Seller";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Autorizationbutton;
        private System.Windows.Forms.Button GoToRegistrationbutton;
    }
}