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

namespace prjkn
{
    public partial class film_add : Form
    {
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;Uid=root;pwd=qwerty123456;database=new_schema;Allow User Variables=True");
        public film_add()
        {
            InitializeComponent();
        }

        private void film_add_Load(object sender, EventArgs e)
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
            string f_name = name.Text;
            string f_desc = desc.Text;

            conn.Open();
            MySqlCommand cmd0 = new MySqlCommand($"START TRANSACTION;INSERT INTO new_schema.films (name, description, image_url) VALUES (\"{f_name}\", \"{f_desc}\", @image);SET @film_id = LAST_INSERT_ID();", conn);
            var paramUserImage = new MySqlParameter("@image", MySqlDbType.LongBlob, imageToByte(img_s).Length);
            paramUserImage.Value = imageToByte(img_s);
            cmd0.Parameters.Add(paramUserImage);
            cmd0.ExecuteNonQuery();
            string[] genre_a = genre.Text.Split(";");
            foreach (string genre_i in genre_a)
            {
                MySqlCommand cmd1 = new MySqlCommand($"INSERT IGNORE INTO new_schema.genres (genre_name) VALUES (\"{genre_i}\");SET @genre_id = LAST_INSERT_ID();INSERT INTO new_schema.films_genres (genres_id, films_id) VALUES(@genre_id, @film_id);", conn);
                cmd1.ExecuteNonQuery();
            }
            string[] dir_a = dir.Text.Split(";");
            foreach(string dir_i in dir_a)
            {
                string dirLName = dir_i.Substring(0, dir.Text.IndexOf(' '));
                string dirFName = dir_i.Substring(dir.Text.IndexOf(' '));
                MySqlCommand cmd2 = new MySqlCommand($"INSERT IGNORE INTO new_schema.directors (last_name, first_name) VALUES (\"{dirLName}\", \"{dirFName}\");SET @dir_id = LAST_INSERT_ID();INSERT INTO new_schema.films_directors (films_id, directors_id) VALUES(@film_id, @dir_id);", conn);
                cmd2.ExecuteNonQuery();
            }
            string[] actors_a = actors.Text.Split(";");
            foreach (string actors_i in actors_a)
            {
                string actorLName = actors_i.Substring(0, dir.Text.IndexOf(' '));
                string actorFName = actors_i.Substring(dir.Text.IndexOf(' '));
                MySqlCommand cmd3 = new MySqlCommand($"INSERT IGNORE INTO new_schema.actors (last_name, first_name) VALUES (\"{actorLName}\", \"{actorFName}\");SET @actor_id = LAST_INSERT_ID();INSERT INTO new_schema.films_actors (actors_id, films_id) VALUES(@actor_id, @film_id);COMMIT;", conn);
                cmd3.ExecuteNonQuery();
            }
            conn.Close();
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
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dir_TextChanged(object sender, EventArgs e)
        {

        }

        private void actors_TextChanged(object sender, EventArgs e)
        {

        }

        private void genre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
