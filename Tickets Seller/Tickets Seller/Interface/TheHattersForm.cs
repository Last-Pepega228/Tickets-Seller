using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Tickets_Seller
{
    public partial class TheHattersForm : Form
    {
        string[] City =                     //Создание массива со списком городов
        {
            "Краснодар",
            "Москва",
            "Санкт-Петербург",
            "Сочи",
            "Горячий Ключ",
            "Новороссийск"
        };
        public TheHattersForm()
        {
            InitializeComponent();
            int i;
            for (i = 0; i < 6; i++)          //Цикл генерации списка для CityBox 
            {
                CityBox.Items.Add(City[i]);
            }
        }

        private void CityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CityBox.SelectedIndex)    //Конструкция для изменения текста в зависимости от выбранного города
            {
                case 0: Datelabel.Text = "Дата концерта в городе Краснодар 25 мая 2022 года";
                    break;
                case 1:
                    Datelabel.Text = "Дата концерта в городе Москва 22 мая 2022 года";
                    break;
                case 2:
                    Datelabel.Text = "Дата концерта в городе Санкт-Петербург \n23 мая 2022 года";
                    break;
                case 3:
                    Datelabel.Text = "Дата концерта в городе Сочи 26 мая 2022 года";
                    break;
                case 4:
                    Datelabel.Text = "Дата концерта в городе Горячий Ключ \n28 мая 2022 года";
                    break;
                case 5:
                    Datelabel.Text = "Дата концерта в городе Новороссийск 30 мая 2022 года";
                    break;
            }
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("TheHattersTicket.pdf") { UseShellExecute = true }); //Открытие pdf файла
        }

        private void NumbersTicket_ValueChanged(object sender, EventArgs e)
        {
            AllCost(3500, 2000);
        }

        internal void AllCost (int FanzoneCost, int DancefloorCost) //Метод для подсчета полной стоимости билетов
        {
            decimal ALLcost;
            decimal numbers = NumbersTicket.Value;
            if (DanceFloorButton.Checked)
            {
                ALLcost = numbers * DancefloorCost;
                TicketsCostText.Text = $"Цена всех билетов {ALLcost} рублей";
            }
            else
            {
                ALLcost = numbers * FanzoneCost;
                TicketsCostText.Text = $"Цена всех билетов {ALLcost} рублей";
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
