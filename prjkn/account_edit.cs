using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class account_edit : Form
    {
        public account_edit()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection("server=127.0.0.1;Uid=root;pwd=qwerty123456;database=new_schema");

        private void account_edit_Load(object sender, EventArgs e)
        {
            //цвет панелей
            PanelR.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelL.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelT.BackColor = Color.FromArgb(150, 100, 79, 47);
            //цвет надписей
            firstname_label.BackColor = Color.FromArgb(0, 255, 255, 255);
            lastname_label.BackColor = Color.FromArgb(0, 255, 255, 255);
            mail_label.BackColor = Color.FromArgb(0, 255, 255, 255);
            login_label.BackColor = Color.FromArgb(0, 255, 255, 255);
            //круглая картинка
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            if (Log_in.is_log)
            {
                pictureBox1.Image = Image.FromStream(Log_in.imgUser);
            }
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

            if (Log_in.is_log == true)
            {
                textBox1.Text = Log_in.firstNameUser;
                textBox2.Text = Log_in.lastNameUser;
                textBox3.Text = Log_in.loginUser;
                textBox4.Text = Log_in.mailUser;
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

        private void Save_button_Click(object sender, EventArgs e)
        {
            String firstName = textBox1.Text;
            String lastName = textBox2.Text;
            String loginUser = textBox3.Text;
            String mailUser = textBox4.Text;

            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введите имя");
                    return;
                }

                if (textBox2.Text == "")
                {
                    MessageBox.Show("Введите фамилию");
                    return;
                }

                if (textBox3.Text == "")
                {
                    MessageBox.Show("Введите логин");
                    return;
                }

                if (textBox4.Text == "")
                {
                    MessageBox.Show("Введите почту");
                    return;
                }

                if (loginUser.Any(c => !char.IsLetterOrDigit(c)))
                {
                    MessageBox.Show("Логин должен содержать только буквы и цифры");
                    return;
                }

                String querry = $"UPDATE accounts SET last_name = ?last_name, first_name = ?first_name, nickname = ?nickname, email = ?email WHERE id = {Log_in.idUser}";
                MySqlCommand command = new MySqlCommand(querry, conn);

                conn.Open();
                command.Parameters.Add(new MySqlParameter("last_name", textBox2.Text));
                command.Parameters.Add(new MySqlParameter("first_name", textBox1.Text));
                command.Parameters.Add(new MySqlParameter("nickname", textBox3.Text));
                command.Parameters.Add(new MySqlParameter("email", textBox4.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Данные успешно обновлены");

                this.Hide();
                account acc = new account();
                acc.ShowDialog();
                this.Close();

                
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
        public void UploadImage(Image img)
        {
            var userImage = imageToByte(img);

            conn.Open();

            var command = new MySqlCommand("", conn);

            command.CommandText = $"UPDATE accounts SET avatar = @avatar WHERE nickname = \"{Log_in.loginUser}\";";

            var paramUserImage = new MySqlParameter("@avatar", MySqlDbType.LongBlob, userImage.Length);

            paramUserImage.Value = userImage;

            command.Parameters.Add(paramUserImage);

            command.ExecuteNonQuery();

            conn.Close();
        }

        public byte[] imageToByte(Image img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public static Image img_s = Image.FromStream(Log_in.imgUser);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files | *.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img_s = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = img_s;
                UploadImage(img_s);
                MemoryStream ms = new MemoryStream(imageToByte(img_s));
                Log_in.imgUser = ms;
            }
        }
    }
}
