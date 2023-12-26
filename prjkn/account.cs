using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjkn
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e)
        {
            //цвет панелей
            PanelR.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelL.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelT.BackColor = Color.FromArgb(150, 100, 79, 47);
            //цвет надписей
            firstname_label.BackColor = Color.FromArgb(0, 255, 255, 255);
            lastname_label.BackColor = Color.FromArgb(0, 255, 255, 255);
            mail_label.BackColor = Color.FromArgb(0, 255, 255, 255);
            login_label.BackColor = Color.FromArgb(0, 255, 255, 255);
            edit_linkLabel.BackColor = Color.FromArgb(0, 255, 255, 255);
            exit_linkLabel.BackColor = Color.FromArgb(0, 255, 255, 255);
            //круглая картинка
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, account_img.Width - 3, account_img.Height - 3);
            Region rg = new Region(gp);
            account_img.Region = rg;
            //цвет кнопок
            Menu_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Search_Button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Menu_button.FlatAppearance.BorderSize = 0;
            Menu_button.FlatStyle = FlatStyle.Flat;
            Search_Button.FlatAppearance.BorderSize = 0;
            Search_Button.FlatStyle = FlatStyle.Flat;
            Home_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Home_button.FlatAppearance.BorderSize = 0;
            Home_button.FlatStyle = FlatStyle.Flat;

            account_img.Image = Image.FromStream(Log_in.imgUser);

            if (Log_in.is_log == true)
            {
                firstname_label.Text = "Имя: " + Log_in.firstNameUser;
                lastname_label.Text = "Фамилия: " + Log_in.lastNameUser;
                login_label.Text = "Логин: " + Log_in.loginUser;
                mail_label.Text = "Почта: " + Log_in.mailUser;
            }
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            list list = new list();
            list.ShowDialog();
            this.Close();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcum wlc = new Welcum();
            wlc.ShowDialog();
            this.Close();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();
            this.Close();
        }

        private void exit_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log_in.is_log = false;
            this.Hide();
            Welcum wlc = new Welcum();
            wlc.ShowDialog();
            this.Close();
        }

        private void edit_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            account_edit acce = new account_edit();
            acce.ShowDialog();
            this.Close();
        }
    }
}
