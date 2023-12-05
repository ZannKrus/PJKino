﻿using MySql.Data.MySqlClient;
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
            MySqlCommand cmd3 = new MySqlCommand($"SELECT AVG(*) FROM (SELECT * FROM new_schema.accounts_films WHERE film_rating > 0)", conn);

            conn.Clone();
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
            conn2.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"insert INTO new_schema.accounts_films (id, accounts_id, films_id, film_rating, accounts_films_status_id) VALUES ({current_i},{current_acc_i},{current_f_i},{comboBox1.SelectedIndex},{comboBox2.SelectedIndex})", conn2);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MySqlCommand cmd = new MySqlCommand($"update new_schema.accounts_films SET id = {current_i}, accounts_id = {current_acc_i}, films_id = {current_f_i}, film_rating = {comboBox1.SelectedIndex}, accounts_films_status_id = {comboBox2.SelectedIndex} WHERE id = {current_i}", conn2);
                cmd.ExecuteNonQuery();
            }
            conn2.Close();
            Debug.WriteLine($"c1: {comboBox1.SelectedIndex}");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn2.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand($"insert INTO new_schema.accounts_films (id, accounts_id, films_id, film_rating, accounts_films_status_id) VALUES ({current_i},{current_acc_i},{current_f_i},{comboBox1.SelectedIndex},{comboBox2.SelectedIndex})", conn2);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MySqlCommand cmd = new MySqlCommand($"update new_schema.accounts_films SET id = {current_i}, accounts_id = {current_acc_i}, films_id = {current_f_i}, film_rating = {comboBox1.SelectedIndex}, accounts_films_status_id = {comboBox2.SelectedIndex} WHERE id = {current_i}", conn2);
                cmd.ExecuteNonQuery();
            }
            conn2.Close();
            Debug.WriteLine($"c2: {comboBox2.SelectedIndex}");
        }
    }
}
