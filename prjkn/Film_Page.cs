using MySql.Data.MySqlClient;
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
        public Film_Page()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;Uid=root;pwd=andk_MYSQL_37;database=new_schema");
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
            //director_name_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            mainrole_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            // mainrole_name_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            genre_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            //genre_name_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            description_label.BackColor = Color.FromArgb(0, 0, 0, 0);

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox3.Width - 3, pictureBox3.Height - 3);
            Region rg = new Region(gp);
            pictureBox3.Region = rg;

            int current_film_i = Search.current_film_i + 1;
            conn.Open();
            MySqlCommand cmd0 = new MySqlCommand($"SELECT * FROM new_schema.films WHERE id = {current_film_i}", conn);
            MySqlDataReader dr = cmd0.ExecuteReader();
            dr.Read();
            film_name.Text = dr["name"].ToString();
            description_label.Text = dr["description"].ToString();
            pictureBox2.Image = new Bitmap(String.Concat("..\\..\\..\\..\\", dr["image_url"].ToString()));
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            dr.Close();
            conn.Close();
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

        private void description_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PanelT_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
