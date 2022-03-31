
namespace Tickets_Seller
{
    partial class TheHattersForm
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
            this.Exitbutton = new System.Windows.Forms.Button();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.TicketsTypeBox = new System.Windows.Forms.GroupBox();
            this.TicketsCostText = new System.Windows.Forms.Label();
            this.NumbersTicket = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.FanzoneButton = new System.Windows.Forms.RadioButton();
            this.DanceFloorButton = new System.Windows.Forms.RadioButton();
            this.Confirmbutton = new System.Windows.Forms.Button();
            this.Datelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genrelabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.TicketsTypeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(169)))), ((int)(((byte)(154)))));
            this.panel1.Controls.Add(this.Exitbutton);
            this.panel1.Controls.Add(this.CityBox);
            this.panel1.Controls.Add(this.TicketsTypeBox);
            this.panel1.Controls.Add(this.Confirmbutton);
            this.panel1.Controls.Add(this.Datelabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.genrelabel);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 545);
            this.panel1.TabIndex = 0;
            // 
            // Exitbutton
            // 
            this.Exitbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(56)))));
            this.Exitbutton.FlatAppearance.BorderSize = 2;
            this.Exitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(56)))));
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Location = new System.Drawing.Point(565, 414);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(120, 45);
            this.Exitbutton.TabIndex = 10;
            this.Exitbutton.Text = "Выход";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // CityBox
            // 
            this.CityBox.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityBox.FormattingEnabled = true;
            this.CityBox.Location = new System.Drawing.Point(459, 117);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(188, 36);
            this.CityBox.TabIndex = 8;
            this.CityBox.Text = "Город";
            this.CityBox.SelectedIndexChanged += new System.EventHandler(this.CityBox_SelectedIndexChanged);
            // 
            // TicketsTypeBox
            // 
            this.TicketsTypeBox.Controls.Add(this.TicketsCostText);
            this.TicketsTypeBox.Controls.Add(this.NumbersTicket);
            this.TicketsTypeBox.Controls.Add(this.label5);
            this.TicketsTypeBox.Controls.Add(this.FanzoneButton);
            this.TicketsTypeBox.Controls.Add(this.DanceFloorButton);
            this.TicketsTypeBox.Location = new System.Drawing.Point(12, 266);
            this.TicketsTypeBox.Name = "TicketsTypeBox";
            this.TicketsTypeBox.Size = new System.Drawing.Size(364, 267);
            this.TicketsTypeBox.TabIndex = 7;
            this.TicketsTypeBox.TabStop = false;
            this.TicketsTypeBox.Text = "Выберете тип и количество билетов";
            // 
            // TicketsCostText
            // 
            this.TicketsCostText.AutoSize = true;
            this.TicketsCostText.Location = new System.Drawing.Point(16, 205);
            this.TicketsCostText.Name = "TicketsCostText";
            this.TicketsCostText.Size = new System.Drawing.Size(188, 28);
            this.TicketsCostText.TabIndex = 4;
            this.TicketsCostText.Text = "Цена всех билетов:";
            // 
            // NumbersTicket
            // 
            this.NumbersTicket.Location = new System.Drawing.Point(278, 154);
            this.NumbersTicket.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumbersTicket.Name = "NumbersTicket";
            this.NumbersTicket.Size = new System.Drawing.Size(44, 34);
            this.NumbersTicket.TabIndex = 3;
            this.NumbersTicket.ValueChanged += new System.EventHandler(this.NumbersTicket_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Количество билетов";
            // 
            // FanzoneButton
            // 
            this.FanzoneButton.AutoSize = true;
            this.FanzoneButton.Location = new System.Drawing.Point(16, 101);
            this.FanzoneButton.Name = "FanzoneButton";
            this.FanzoneButton.Size = new System.Drawing.Size(221, 32);
            this.FanzoneButton.TabIndex = 1;
            this.FanzoneButton.TabStop = true;
            this.FanzoneButton.Text = "Фан-зона (3500 руб)";
            this.FanzoneButton.UseVisualStyleBackColor = true;
            // 
            // DanceFloorButton
            // 
            this.DanceFloorButton.AutoSize = true;
            this.DanceFloorButton.Location = new System.Drawing.Point(16, 39);
            this.DanceFloorButton.Name = "DanceFloorButton";
            this.DanceFloorButton.Size = new System.Drawing.Size(212, 32);
            this.DanceFloorButton.TabIndex = 0;
            this.DanceFloorButton.TabStop = true;
            this.DanceFloorButton.Text = "Танцпол (2000 руб)";
            this.DanceFloorButton.UseVisualStyleBackColor = true;
            // 
            // Confirmbutton
            // 
            this.Confirmbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(115)))));
            this.Confirmbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Confirmbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(66)))));
            this.Confirmbutton.FlatAppearance.BorderSize = 2;
            this.Confirmbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(66)))));
            this.Confirmbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmbutton.Location = new System.Drawing.Point(546, 343);
            this.Confirmbutton.Name = "Confirmbutton";
            this.Confirmbutton.Size = new System.Drawing.Size(155, 56);
            this.Confirmbutton.TabIndex = 5;
            this.Confirmbutton.Text = "Подтвердить";
            this.Confirmbutton.UseVisualStyleBackColor = false;
            this.Confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click);
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datelabel.Location = new System.Drawing.Point(260, 170);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(387, 28);
            this.Datelabel.TabIndex = 4;
            this.Datelabel.Text = "Дата концерта (сначала выберете город)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(260, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Выберете город";
            // 
            // genrelabel
            // 
            this.genrelabel.AutoSize = true;
            this.genrelabel.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genrelabel.Location = new System.Drawing.Point(260, 70);
            this.genrelabel.Name = "genrelabel";
            this.genrelabel.Size = new System.Drawing.Size(519, 31);
            this.genrelabel.TabIndex = 2;
            this.genrelabel.Text = "Жанры:  фолк-панк, фолк-рок, ска-панк, романс";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(260, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(513, 38);
            this.label.TabIndex = 1;
            this.label.Text = "Билеты на концерт группы The Hatters";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tickets_Seller.Properties.Resources.The_Hatters_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TheHattersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 545);
            this.Controls.Add(this.panel1);
            this.Name = "TheHattersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets Seller";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TicketsTypeBox.ResumeLayout(false);
            this.TicketsTypeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CityBox;
        private System.Windows.Forms.GroupBox TicketsTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Confirmbutton;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label genrelabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown NumbersTicket;
        private System.Windows.Forms.RadioButton FanzoneButton;
        private System.Windows.Forms.RadioButton DanceFloorButton;
        private System.Windows.Forms.Label TicketsCostText;
        private System.Windows.Forms.Button Exitbutton;
    }
}