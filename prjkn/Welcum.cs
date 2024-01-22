namespace prjkn
{
    public partial class Welcum : Form
    {
        public Welcum()
        {
            InitializeComponent();
        }

        private void Welcum_Load(object sender, EventArgs e)
        {
            //???
            PanelR.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelL.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelT.BackColor = Color.FromArgb(150, 100, 79, 47);
            PanelBack.BackColor = Color.FromArgb(75, 255, 255, 255);
            //???
            Menu_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Search_Button.BackColor = Color.FromArgb(0, 100, 79, 47);

            Menu_button.FlatAppearance.BorderSize = 0;
            Menu_button.FlatStyle = FlatStyle.Flat;

            Search_Button.FlatAppearance.BorderSize = 0;
            Search_Button.FlatStyle = FlatStyle.Flat;

            Greet_text.BackColor = Color.FromArgb(0, 255, 255, 255);

            Home_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Home_button.FlatAppearance.BorderSize = 0;
            Home_button.FlatStyle = FlatStyle.Flat;

            admin_b.BackColor = Color.FromArgb(0, 100, 79, 47);
            admin_b.FlatAppearance.BorderSize = 0;
            admin_b.FlatStyle = FlatStyle.Flat;

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            if (Log_in.is_log)
            {
                pictureBox1.Image = Image.FromStream(Log_in.imgUser);
            }


            if (Log_in.is_log == true && Log_in.loginUser == "admin")
            {
                admin_b.Visible = true;
                admin_b.Enabled = true;
            }
            else
            {
                admin_b.Visible = false;
                admin_b.Enabled = false;
            }

            if (Log_in.is_log)
            {
                Greet_text.Text = $"Добро пожаловать, {Log_in.firstNameUser}";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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

        private void Search_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();
            this.Close();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Greet_text_Click(object sender, EventArgs e)
        {

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

        private void Home_button_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in_and_Registration logreg = new Log_in_and_Registration();
            logreg.ShowDialog();
            this.Close();
        }

        private void admin_b_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin ad = new admin();
            ad.ShowDialog();
            this.Close();
        }
    }
}