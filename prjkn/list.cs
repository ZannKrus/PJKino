using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjkn
{
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;Uid=root;pwd=qwerty123456;database=new_schema");
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
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            if (Log_in.is_log)
            {
                pictureBox1.Image = Image.FromStream(Log_in.imgUser);
            }

            ///////////////////////////////////////////////////////
            //listView1.Columns.Add("Постер");
            listView1.Columns.Add("Название");
            listView1.Columns.Add("Статус");
            listView1.Columns.Add("Оценка");
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(72, 128);
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT image_url, name, status_name, film_rating FROM new_schema.accounts_films, films_status, films where accounts_films_status_id = films_status.id and films.id = films_id and accounts_id = {Log_in.idUser}", conn);
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string i_u = rd.GetString("image_url");
                
                string n = rd.GetString("name");
                string s_n = rd.GetString("status_name");
                string f_r = Convert.ToString(11 - Convert.ToInt32(rd.GetString("film_rating")));

                
                Image img = Image.FromStream(new MemoryStream((byte[])rd["image_url"]));


                imgList.Images.Add(n,img);
                listView1.SmallImageList = imgList;
                listView1.Items.Add(new ListViewItem(new string[] { n,s_n,f_r }, n));
            }
            conn.Close();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void PanelBack_Click(object sender, EventArgs e)
        {
            if (Log_in.is_log == true)
            {
                this.Hide();
                account acc = new account();
                acc.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Log_in_and_Registration logreg = new Log_in_and_Registration();
                logreg.ShowDialog();
                this.Close();
            }
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            if (Log_in.is_log == true)
            {
                this.Hide();
                list list = new list();
                list.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Log_in_and_Registration logreg = new Log_in_and_Registration();
                logreg.ShowDialog();
                this.Close();
            }
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
    }
}
