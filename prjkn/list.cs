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
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }

        private void list_Load(object sender, EventArgs e)
        {
            //цвет панелей
            PanelR.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelL.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelT.BackColor = Color.FromArgb(150, 100, 79, 47);
            PanelBack.BackColor = Color.FromArgb(75, 255, 255, 255);
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
            //цвет текста
            list_label.BackColor = Color.FromArgb(0, 255, 255, 255);
            //круглая картинка
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox2.Width - 3, pictureBox2.Height - 3);
            Region rg = new Region(gp);
            pictureBox2.Region = rg;
        }

        private void PanelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            account acc = new account();
            acc.ShowDialog();
            this.Close();
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {

        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcum wlc = new Welcum();
            wlc.ShowDialog();
            this.Close();
        }
    }
}
