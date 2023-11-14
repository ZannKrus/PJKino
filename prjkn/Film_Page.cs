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
    public partial class Film_Page : Form
    {
        private Welcum welcumForm;
        public Film_Page(Welcum welcumForm)
        {
            this.welcumForm = welcumForm;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Film_Page_Load(object sender, EventArgs e)
        {
            //панели
            PanelR.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelL.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelT.BackColor = Color.FromArgb(150, 100, 79, 47);
            PanelBack.BackColor = Color.FromArgb(75, 255, 255, 255);
            //кнопки
            Menu_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Menu_button.FlatAppearance.BorderSize = 0;
            Menu_button.FlatStyle = FlatStyle.Flat;
            Search_Button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Search_Button.FlatAppearance.BorderSize = 0;
            Search_Button.FlatStyle = FlatStyle.Flat;
            Home_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Home_button.FlatAppearance.BorderSize = 0;
            Home_button.FlatStyle = FlatStyle.Flat;
            //тексты
            film_name.BackColor = Color.FromArgb(0, 0, 0, 0);
            director_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            director_name_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            mainrole_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            mainrole_name_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            genre_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            genre_name_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            description_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox3.Width - 3, pictureBox3.Height - 3);
            Region rg = new Region(gp);
            pictureBox3.Region = rg;
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcum wlc = new Welcum();
            wlc.ShowDialog();
            this.Close();
        }

        private void PanelL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Film_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (welcumForm != null && welcumForm.Visible == false)
            {
                Application.Exit(); // Закрыть приложение, если главное окно скрыто
            }
            else
            {
                welcumForm.Show(); // Показать главное окно, если оно видимо
            }
        }

        private void director_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void film_name_Click(object sender, EventArgs e)
        {

        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();
            this.Close();
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            list list = new list();
            list.ShowDialog();
            this.Close();
        }

        private void PanelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            account acc = new account();
            acc.ShowDialog();
            this.Close();
        }
    }
}
