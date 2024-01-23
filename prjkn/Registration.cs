using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace prjkn
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            pass_textBox.UseSystemPasswordChar = true;
        }
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;Uid=root;pwd=qwerty123456;database=new_schema");

        private void Registration_Load(object sender, EventArgs e)
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

        private void Registration_button_Click(object sender, EventArgs e)
        {
            String firstName = fn_textBox.Text;
            String lastName = ln_textBox.Text;
            String loginUser = login_textBox.Text;
            String mailUser = mail_textBox.Text;
            String passUser = pass_textBox.Text;

            string hashedPassword = HashPassword(passUser);

            try
            {
                if (fn_textBox.Text == "")
                {
                    MessageBox.Show("Введите имя");
                    return;
                }

                if (ln_textBox.Text == "")
                {
                    MessageBox.Show("Введите фамилию");
                    return;
                }

                if (login_textBox.Text == "")
                {
                    MessageBox.Show("Введите логин");
                    return;
                }

                if (mail_textBox.Text == "")
                {
                    MessageBox.Show("Введите почту");
                    return;
                }

                if (pass_textBox.Text == "")
                {
                    MessageBox.Show("Введите пароль");
                    return;
                }

                if (isUserExists())
                    return;

                if (isUserMailExists())
                    return;

                if (passUser.Any(c => !char.IsLetterOrDigit(c)))
                {
                    MessageBox.Show("Пароль не должен содержать специальные символы");
                    return;
                }

                if (loginUser.Any(c => !char.IsLetterOrDigit(c)))
                {
                    MessageBox.Show("Логин должен содержать только буквы и цифры");
                    return;
                }

                if (passUser.Length < 8 || passUser.Length > 72)
                {
                    MessageBox.Show("Пароль должен содержать не менее 8 символов");
                    return;
                }

                String querry = "INSERT INTO accounts (last_name, first_name, email, nickname, password) values (?ln, ?fn, ?mail, ?login, ?pass)";
                MySqlCommand command = new MySqlCommand(querry, conn);

                conn.Open();
                command.Parameters.Add(new MySqlParameter("ln", ln_textBox.Text));
                command.Parameters.Add(new MySqlParameter("fn", fn_textBox.Text));
                command.Parameters.Add(new MySqlParameter("mail", mail_textBox.Text));
                command.Parameters.Add(new MySqlParameter("login", login_textBox.Text));
                command.Parameters.Add(new MySqlParameter("pass", pass_textBox.Text));
                command.ExecuteNonQuery();
                byte[] imageToByte(Image img)
                {
                    using (var ms = new MemoryStream())
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        return ms.ToArray();
                    }
                }
                var userImage = imageToByte(Image.FromFile("..\\..\\..\\..\\images\\circles.jpg"));

                

                var command1 = new MySqlCommand("", conn);

                command1.CommandText = $"UPDATE accounts SET avatar = @avatar WHERE nickname = \"{login_textBox.Text}\";";

                var paramUserImage = new MySqlParameter("@avatar", MySqlDbType.LongBlob, userImage.Length);

                paramUserImage.Value = userImage;

                command1.Parameters.Add(paramUserImage);

                command1.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Регистрация прошла успешно");

                this.Hide();
                Welcum wlc = new Welcum();
                wlc.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка");
                Debug.WriteLine(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }

        private string HashPassword(string passUser)
        {
            using (var sha256 = SHA256.Create())
            {
                // Преобразование пароля в массив байтов
                byte[] passwordBytes = Encoding.UTF8.GetBytes(passUser);

                // Вычисление хэш-кода для пароля
                byte[] hashedBytes = sha256.ComputeHash(passwordBytes);

                // Преобразование массива байтов в строку
                string hashedPassword = Convert.ToBase64String(hashedBytes);

                return hashedPassword;
            }
        }

        public Boolean isUserExists()
        {
            String querry = "SELECT * FROM accounts WHERE nickname = '" + login_textBox.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);

            DataTable dTable = new DataTable();
            sda.Fill(dTable);

            if (dTable.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
            }
            else
                return false;
        }

        public Boolean isUserMailExists()
        {
            String querry = "SELECT * FROM accounts WHERE email = '" + mail_textBox.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);

            DataTable dTable = new DataTable();
            sda.Fill(dTable);

            if (dTable.Rows.Count > 0)
            {
                MessageBox.Show("Такая почта уже есть, введите другую");
                return true;
            }
            else
                return false;
        }
    }
}
