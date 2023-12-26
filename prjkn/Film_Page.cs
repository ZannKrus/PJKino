using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;Uid=root;pwd=qwerty123456;database=new_schema");
        MySqlConnection conn2 = new MySqlConnection("server=127.0.0.1;Uid=root;pwd=qwerty123456;database=new_schema");
        public static int current_f_i = Search.current_film_i + 1;
        private void Film_Page_Load(object sender, EventArgs e)
        {
            current_f_i = Search.current_film_i + 1;
            Debug.WriteLine($"cfi: {current_f_i}");
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
            director_label_fn.BackColor = Color.FromArgb(0, 0, 0, 0);
            //director_name_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            mainrole_label_fn.BackColor = Color.FromArgb(0, 0, 0, 0);
            // mainrole_name_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            genre_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            //genre_name_label.BackColor = Color.FromArgb(0, 0, 0, 0);
            description_label.BackColor = Color.FromArgb(0, 0, 0, 0);

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            if (Log_in.is_log)
            {
                pictureBox1.Image = Image.FromStream(Log_in.imgUser);
            }

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

            MySqlCommand cmd4 = new MySqlCommand($"SELECT * FROM new_schema.directors WHERE id = {current_film_i}", conn);
            MySqlDataReader dr1 = cmd4.ExecuteReader();
            dr1.Read();
            director_label_fn.Text = dr1["first_name"].ToString();
            director_label_ln.Text = dr1["last_name"].ToString();
            dr1.Close();

            MySqlCommand cmd5 = new MySqlCommand($"SELECT * FROM new_schema.actors WHERE id = {current_film_i}", conn);
            MySqlDataReader dr5 = cmd5.ExecuteReader();
            dr5.Read();
            mainrole_label_fn.Text = dr5["first_name"].ToString();
            mainrole_label_ln.Text = dr5["last_name"].ToString();
            dr5.Close();

            MySqlCommand cmd6 = new MySqlCommand($"SELECT * FROM new_schema.genres WHERE id = {current_film_i}", conn);
            MySqlDataReader dr3 = cmd6.ExecuteReader();
            dr3.Read();
            genre_label.Text = dr3["genre_name"].ToString();
            dr3.Close();

            if (Log_in.is_log)
            {
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox1.Visible = true;
                comboBox2.Visible = true;

                MySqlCommand cmd1 = new MySqlCommand($"SELECT * FROM new_schema.accounts WHERE nickname = \"{Log_in.loginUser}\"", conn);
                MySqlCommand cmd2 = new MySqlCommand($"SELECT * FROM new_schema.accounts_films WHERE (films_id = {current_film_i} AND accounts_id = {Convert.ToInt32(cmd1.ExecuteScalar())}) ORDER BY id DESC LIMIT 0, 1", conn);
                current_i = Convert.ToInt32(cmd2.ExecuteScalar());
                current_acc_i = Convert.ToInt32(cmd1.ExecuteScalar());
                Debug.WriteLine(current_i);

                MySqlDataReader dr2 = cmd2.ExecuteReader();
                int film_rating = 0;
                int film_status = 0;
                if (dr2.Read())
                {
                    try { film_rating = Convert.ToInt32(dr2["film_rating"].ToString()); } catch { Debug.WriteLine("film rating"); film_rating = 0; }

                    try { film_status = Convert.ToInt32(dr2["accounts_films_status_id"].ToString()); } catch { Debug.WriteLine("film status"); film_status = 0; }

                }
                comboBox1.SelectedIndex = film_rating;
                comboBox2.SelectedIndex = film_status;
                dr2.Close();

            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
            }
            conn.Close();

            conn.Open();
            double rating = 0;

            MySqlCommand cmd_rating = new MySqlCommand($"SELECT film_rating FROM new_schema.accounts_films WHERE films_id = {current_film_i} and film_rating > 0", conn);
            MySqlCommand cmd_rating_count = new MySqlCommand($"SELECT count(*) FROM new_schema.accounts_films WHERE films_id = {current_film_i} and film_rating > 0", conn);

            MySqlDataReader rd = cmd_rating.ExecuteReader();
            while (rd.Read())
            {
                rating += 11 - Convert.ToDouble(rd.GetString("film_rating"));
            }
            rd.Close();
            rating = rating / Convert.ToDouble(cmd_rating_count.ExecuteScalar());
            if (double.IsNaN(rating)) rating = 0;
            film_name.Text += $" {rating}★";


            MySqlCommand cmd_comm = new MySqlCommand($"SELECT films_id,nickname,comment FROM new_schema.accounts, new_schema.comments where accounts.id = comments.accounts_id and films_id = {current_film_i}", conn);
            rd = cmd_comm.ExecuteReader();
            while (rd.Read())
            {
                string n = rd.GetString("nickname");
                string c = rd.GetString("comment");

                Label label = new Label();
                label.AutoSize = true;
                label.Font = new Font("Segoe", 15);
                label.ForeColor = Color.White;
                label.Padding = new Padding(15);
                label.Text = $"{n}: {c}";
                flowLayoutPanel2.Controls.Add(label);
            }
            rd.Close();
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
        public static int current_i;
        public static int current_acc_i;

        public static int current_f_s;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conn2.Open();
            //try
            //{
            //    MySqlCommand cmd = new MySqlCommand($"insert INTO new_schema.accounts_films (id, accounts_id, films_id, film_rating, accounts_films_status_id) VALUES ({current_i},{current_acc_i},{current_f_i},{comboBox1.SelectedIndex},{comboBox2.SelectedIndex})", conn2);
            //    cmd.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MySqlCommand cmd = new MySqlCommand($"update new_schema.accounts_films SET id = {current_i}, accounts_id = {current_acc_i}, films_id = {current_f_i}, film_rating = {comboBox1.SelectedIndex}, accounts_films_status_id = {comboBox2.SelectedIndex} WHERE id = {current_i}", conn2);
            //    cmd.ExecuteNonQuery();
            //}
            //conn2.Close();
            //Debug.WriteLine($"c1: {comboBox1.SelectedIndex}");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //conn2.Open();
            //try
            //{
            //    MySqlCommand cmd = new MySqlCommand($"insert INTO new_schema.accounts_films (id, accounts_id, films_id, film_rating, accounts_films_status_id) VALUES ({current_i},{current_acc_i},{current_f_i},{comboBox1.SelectedIndex},{comboBox2.SelectedIndex})", conn2);
            //    cmd.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MySqlCommand cmd = new MySqlCommand($"update new_schema.accounts_films SET id = {current_i}, accounts_id = {current_acc_i}, films_id = {current_f_i}, film_rating = {comboBox1.SelectedIndex}, accounts_films_status_id = {comboBox2.SelectedIndex} WHERE id = {current_i}", conn2);
            //    cmd.ExecuteNonQuery();
            //}
            //conn2.Close();
            //Debug.WriteLine($"c2: {comboBox2.SelectedIndex}");
        }

        private void save_Click(object sender, EventArgs e)
        {
            conn2.Open();
            MySqlCommand cmd0 = new MySqlCommand($"delete from new_schema.accounts_films where accounts_id = {current_acc_i}", conn2);
            MySqlCommand cmd = new MySqlCommand($"insert INTO new_schema.accounts_films (id, accounts_id, films_id, film_rating, accounts_films_status_id) VALUES ({current_i},{current_acc_i},{current_f_i},{comboBox1.SelectedIndex},{comboBox2.SelectedIndex}) ON DUPLICATE KEY UPDATE film_rating = {comboBox1.SelectedIndex}, accounts_films_status_id = {comboBox2.SelectedIndex}", conn2);
            cmd0.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            conn2.Close();
        }
    }
}
