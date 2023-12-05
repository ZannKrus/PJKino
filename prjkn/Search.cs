using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjkn
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;Uid=root;pwd=qwerty123456;database=new_schema");
        private void Search_Load(object sender, EventArgs e)
        {
            PanelT.BackColor = Color.FromArgb(150, 100, 79, 47);
            //PanelL.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelBack.BackColor = Color.FromArgb(75, 255, 255, 255);
            Menu_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Search_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Home_button.BackColor = Color.FromArgb(0, 100, 79, 47);


            if (offset == 1)
            {
                page_b.Enabled = false;
                page_b.Visible = false;

            }
            else
            {
                page_b.Enabled = true;
                page_b.Visible = true;
            }
            listview_Load();
            conn.Open();
            listView2.CheckBoxes = true;

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM new_schema.genres", conn);
            List<string> genre_data = new List<string>();
            MySqlDataReader genre_dr = cmd1.ExecuteReader();
            while (genre_dr.Read())
            {
                genre_data.Add(genre_dr["genre_name"].ToString());
            }
            genre_dr.Close();

            for (int i = 0; i < genre_data.Count; i++)
            {

                listView2.Items.Add(genre_data[i]);
            }
            conn.Close();

        }
        public static int offset = 1;
        public static String search_q = $"SELECT * FROM new_schema.films LIMIT {5 * (offset - 1)}, {5 * offset}";
        public static List<int> ind_data = new List<int>();
        private void listview_Load()
        {
            conn.Open();
            MySqlCommand cmd0 = new MySqlCommand(search_q, conn);
            List<string> img_data = new List<string>();
            MySqlDataReader dr = cmd0.ExecuteReader();
            while (dr.Read())
            {
                img_data.Add(dr["image_url"].ToString());
                ind_data.Add(Convert.ToInt32(dr["id"]));
                Debug.WriteLine(Convert.ToInt32(dr["id"]));
            }
            dr.Close();

            listView1.Items.Clear();
            ImageList list = new ImageList();
            list.ImageSize = new Size(144, 256);
            list.ColorDepth = ColorDepth.Depth32Bit;
            for (int i = 0; i < img_data.Count; i++)
            {
                String s = String.Concat("..\\..\\..\\..\\", img_data[i].ToString());
                //Debug.WriteLine(s);
                list.Images.Add(new Bitmap(s));
            }

            listView1.LargeImageList = list;
            for (int i = 0; i < ind_data.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.ImageIndex = i;
                listView1.Items.Add(listViewItem);
            }
            String search_q_o = search_q.Replace("*", " COUNT(*)");
            int p = search_q_o.LastIndexOf("LIMIT");
            search_q_o = search_q_o.Substring(0, p);
            MySqlCommand cmd1 = new MySqlCommand(search_q_o, conn);
            //Debug.WriteLine(Convert.ToInt32(cmd1.ExecuteScalar()));
            if (Convert.ToInt32(cmd1.ExecuteScalar()) - offset * 5 <= 0)
            {
                page_f.Enabled = false;
                page_f.Visible = false;
            }
            else
            {
                page_f.Enabled = true;
                page_f.Visible = true;
            }
            if (Convert.ToInt32(cmd1.ExecuteScalar()) / 5 <= 1)
            {
                page_text.Text = $"{offset} / 1";
            }
            else
            {
                page_text.Text = $"{offset} / {Convert.ToInt32(cmd1.ExecuteScalar()) / 5}";
            }
            conn.Close();
            Debug.WriteLine(search_q);
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcum wlc = new Welcum();
            wlc.ShowDialog();
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            Film_Page fp = new Film_Page();
            fp.ShowDialog();
            this.Close();
        }
        public static int current_film_i;
        private void listView1_Click(object sender, EventArgs e)
        {
            current_film_i = listView1.SelectedIndices[0];
            Debug.WriteLine(current_film_i);
        }

        private void page_f_Click(object sender, EventArgs e)
        {
            offset++;
            if (offset == 1)
            {
                page_b.Enabled = false;
                page_b.Visible = false;

            }
            else
            {
                page_b.Enabled = true;
                page_b.Visible = true;
            }
            conn.Open();
            MySqlCommand cmd0 = new MySqlCommand($"SELECT COUNT(*) FROM new_schema.films", conn);
            if (Convert.ToInt32(cmd0.ExecuteScalar()) - offset * 5 <= 0)
            {
                page_f.Enabled = false;
                page_f.Visible = false;
            }
            else
            {
                page_f.Enabled = true;
                page_f.Visible = true;
            }
            conn.Close();
            search_f();
            listview_Load();
        }

        private void page_b_Click(object sender, EventArgs e)
        {
            offset--;
            if (offset == 1)
            {
                page_b.Enabled = false;
                page_b.Visible = false;

            }
            else
            {
                page_b.Enabled = true;
                page_b.Visible = true;
            }
            search_f();
            listview_Load();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            search_f();
            listview_Load();
        }
        private void search_f()
        {
            if (!(string.IsNullOrEmpty(search_textBox.Text)))
            {
                search_q = $"SELECT * FROM new_schema.films WHERE new_schema.films.name LIKE \"{$"{search_text}" + "%"}\" LIMIT {5 * (offset - 1)}, {5 * offset}";
                search_textBox.Clear();
                for (int i = 0; i < listView2.Items.Count; i++)
                {
                    listView2.Items[i].Checked = false;
                }
                
            }
            else
            {
                search_q = "SELECT * FROM new_schema.films, new_schema.genres, new_schema.films_genres WHERE (new_schema.films_genres.films_id = new_schema.films.id AND new_schema.films_genres.genres_id = new_schema.genres.id)";
                if (listView2.CheckedItems.Count > 0)
                {
                    foreach (ListViewItem item in listView2.CheckedItems)
                    {
                        Debug.WriteLine(item.Text);
                        search_q = search_q + $" AND new_schema.genres.genre_name = \"{item.Text}\"";

                    }
                }
                else
                {
                    search_q = "SELECT * FROM new_schema.films";
                }
                search_q = search_q + $" ORDER BY new_schema.films.id LIMIT {5 * (offset - 1)}, {5 * offset}";
            }
            
            offset = 1;
            page_b.Enabled = false;
            page_b.Visible = false;
            listview_Load();
        }
        public static String search_text = null;
        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            search_text = search_textBox.Text;
        }
    }
}
