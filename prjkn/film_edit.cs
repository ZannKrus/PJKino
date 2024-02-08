using Microsoft.VisualBasic;
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
using System.Xml.Linq;

namespace prjkn
{
    public partial class film_edit : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;Uid=root;pwd=qwerty123456;database=new_schema;Allow User Variables=True");
        public film_edit()
        {
            InitializeComponent();
        }

        private void film_edit_Load(object sender, EventArgs e)
        {
            PanelR.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelL.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelT.BackColor = Color.FromArgb(150, 100, 79, 47);
            Menu_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Search_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Home_button.BackColor = Color.FromArgb(0, 100, 79, 47);
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

        private void Search_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();
            this.Close();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcum wlc = new Welcum();
            wlc.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f_name = textBox1.Text;
            string f_desc = textBox2.Text;

            conn.Open();
            MySqlCommand cmd0 = new MySqlCommand($"START TRANSACTION;INSERT INTO new_schema.films (name, description, image_url) VALUES (\"{f_name}\", \"{f_desc}\", @image);SET @film_id = LAST_INSERT_ID();", conn);
            var paramUserImage = new MySqlParameter("@image", MySqlDbType.LongBlob, imageToByte(img_s).Length);
            paramUserImage.Value = imageToByte(img_s);
            cmd0.Parameters.Add(paramUserImage);
            cmd0.ExecuteNonQuery();
            string[] genre_a = textBox5.Text.Split(";");
            foreach (string genre_i in genre_a)
            {
                MySqlCommand cmd1 = new MySqlCommand($"INSERT IGNORE INTO new_schema.genres (genre_name) VALUES (\"{genre_i}\");SET @genre_id = LAST_INSERT_ID();INSERT INTO new_schema.films_genres (genres_id, films_id) VALUES(@genre_id, @film_id);", conn);
                cmd1.ExecuteNonQuery();
            }
            string[] dir_a = textBox3.Text.Split(";");
            foreach (string dir_i in dir_a)
            {
                Debug.WriteLine(textBox3.Text);
                string dirLName = dir_i.Substring(0, textBox3.Text.IndexOf(' '));
                string dirFName = dir_i.Substring(textBox3.Text.IndexOf(' '));
                MySqlCommand cmd2 = new MySqlCommand($"INSERT IGNORE INTO new_schema.directors (last_name, first_name) VALUES (\"{dirLName}\", \"{dirFName}\");SET @dir_id = LAST_INSERT_ID();INSERT INTO new_schema.films_directors (films_id, directors_id) VALUES(@film_id, @dir_id);", conn);
                cmd2.ExecuteNonQuery();
            }
            string[] actors_a = textBox4.Text.Split(";");
            foreach (string actors_i in actors_a)
            {
                string actorLName = actors_i.Substring(0, textBox4.Text.IndexOf(' '));
                string actorFName = actors_i.Substring(textBox4.Text.IndexOf(' '));
                MySqlCommand cmd3 = new MySqlCommand($"INSERT IGNORE INTO new_schema.actors (last_name, first_name) VALUES (\"{actorLName}\", \"{actorFName}\");SET @actor_id = LAST_INSERT_ID();INSERT INTO new_schema.films_actors (actors_id, films_id) VALUES(@actor_id, @film_id);", conn);
                cmd3.ExecuteNonQuery();
            }
            MySqlCommand cmdf = new MySqlCommand($"DELETE FROM new_schema.films where new_schema.films.id = {filmID};COMMIT;", conn);
            cmdf.ExecuteNonQuery();
            conn.Close();
        }
        public static MemoryStream ms;
        void load_edit()
        {
            string name_s = "";
            string desc_s = "";
            string dir_s = "";
            string actors_s = "";
            string genres_s = "";


            conn.Open();

            MySqlCommand cmd2 = new MySqlCommand($"SELECT * FROM new_schema.films where id = {filmID};", conn);
            MySqlDataReader dr_dr = cmd2.ExecuteReader();
            while (dr_dr.Read())
            {
                name_s = dr_dr["name"].ToString();
                desc_s = dr_dr["description"].ToString();
                ms = new MemoryStream((byte[])dr_dr["image_url"]);
            }
            dr_dr.Close();
            MySqlCommand cmd3 = new MySqlCommand($"SELECT * FROM new_schema.directors join films_directors on directors.id = directors_id where films_id = {filmID};", conn);
            MySqlDataReader dir_dr = cmd3.ExecuteReader();
            while (dir_dr.Read())
            {
                dir_s += dir_dr["last_name"].ToString() + " " + dir_dr["first_name"].ToString() + ";";
            }
            Debug.WriteLine(dir_s, dir_s.Length);
            dir_s = dir_s.Remove(dir_s.Length - 1);
            dir_dr.Close();

            MySqlCommand cmd4 = new MySqlCommand($"SELECT * FROM new_schema.genres join films_genres on genres.id = genres_id where films_id = {filmID};", conn);
            MySqlDataReader genre_dr = cmd4.ExecuteReader();
            while (genre_dr.Read())
            {
                genres_s += genre_dr["genre_name"].ToString() + ";";
            }
            genres_s = genres_s.Remove(genres_s.Length - 1);
            genre_dr.Close();

            MySqlCommand cmd5 = new MySqlCommand($"SELECT * FROM new_schema.actors join films_actors on actors.id = actors_id where films_id = {filmID};", conn);
            MySqlDataReader actors_dr = cmd5.ExecuteReader();
            while (actors_dr.Read())
            {
                actors_s += actors_dr["last_name"].ToString() + " " + actors_dr["first_name"].ToString() + ";";
            }
            actors_s = actors_s.Remove(actors_s.Length - 1);
            actors_dr.Close();

            conn.Close();
            textBox1.Text = name_s;
            textBox2.Text = desc_s;
            textBox3.Text = dir_s;
            textBox4.Text = actors_s;
            textBox5.Text = genres_s;
            pictureBox1.Image = Image.FromStream(ms);
        }
        static int filmID;
        private void button2_Click(object sender, EventArgs e)
        {
            string delName = Interaction.InputBox("Prompt", "Title", "Default");
            conn.Open();
            MySqlCommand cmd0 = new MySqlCommand($"SELECT id FROM new_schema.films where name like \"{delName + "%"}\"", conn);
            filmID = Convert.ToInt32(cmd0.ExecuteScalar());
            Debug.WriteLine(filmID);
            conn.Close();
            load_edit();
        }
        public static Image img_s;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files | *.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img_s = Image.FromFile(openFileDialog1.FileName);
            }
        }
        public byte[] imageToByte(Image img)
        {
            using (var ms1 = new MemoryStream())
            {
                img.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms1.ToArray();
            }
        }
    }
}
