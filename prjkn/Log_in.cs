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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
            pass_textBox.UseSystemPasswordChar = true;
        }
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;Uid=root;pwd=qwerty123456;database=new_schema");

        private void Log_in_Load(object sender, EventArgs e)
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
            this.Hide();
            list list = new list();
            list.ShowDialog();
            this.Close();
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

        private void pass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_checkBox.Checked)
            {
                pass_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                pass_textBox.UseSystemPasswordChar = true;
            }
        }
        public static String loginUser;
        public static String passUser;
        public static String firstNameUser;
        public static String lastNameUser;
        public static String mailUser;
        public static MemoryStream imgUser;
        public static bool is_log = false;
        private void Log_in_button_Click(object sender, EventArgs e)
        {
            loginUser = login_textBox.Text;
            passUser = pass_textBox.Text;

            try
            {
                if (login_textBox.Text == "")
                {
                    MessageBox.Show("Введите логин");
                    return;
                }

                if (pass_textBox.Text == "")
                {
                    MessageBox.Show("Введите пароль");
                    return;
                }

                String querry = "SELECT * FROM accounts WHERE Binary nickname = '" + login_textBox.Text + "' AND Binary password = '" + pass_textBox.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    loginUser = login_textBox.Text;
                    passUser = pass_textBox.Text;

                    is_log = true;

                    foreach (DataRow row in dTable.Rows)
                    {
                        firstNameUser = row["first_name"].ToString();
                        lastNameUser = row["last_name"].ToString();
                        mailUser = row["Email"].ToString();

                        MemoryStream ms = new MemoryStream((byte[])row["Avatar"]);
                        imgUser = ms;
                    }
                    this.Hide();
                    Welcum wlc = new Welcum();
                    wlc.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Неверные учетные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    login_textBox.Clear();
                    pass_textBox.Clear();

                    login_textBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
