namespace prjkn
{
    partial class account_edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account_edit));
            PanelT = new Panel();
            Home_button = new Button();
            Search_Button = new Button();
            Menu_button = new Button();
            PanelL = new Panel();
            PanelR = new Panel();
            mail_label = new Label();
            login_label = new Label();
            lastname_label = new Label();
            firstname_label = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Save_button = new Button();
            openFileDialog1 = new OpenFileDialog();
            PanelT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelT
            // 
            PanelT.Controls.Add(Home_button);
            PanelT.Controls.Add(Search_Button);
            PanelT.Controls.Add(Menu_button);
            PanelT.Dock = DockStyle.Top;
            PanelT.Location = new Point(0, 0);
            PanelT.Name = "PanelT";
            PanelT.Size = new Size(1325, 50);
            PanelT.TabIndex = 1;
            // 
            // Home_button
            // 
            Home_button.BackColor = Color.Transparent;
            Home_button.BackgroundImage = (Image)resources.GetObject("Home_button.BackgroundImage");
            Home_button.BackgroundImageLayout = ImageLayout.Stretch;
            Home_button.Location = new Point(91, 12);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(35, 30);
            Home_button.TabIndex = 10;
            Home_button.UseVisualStyleBackColor = false;
            Home_button.Click += Home_button_Click;
            // 
            // Search_Button
            // 
            Search_Button.BackgroundImage = (Image)resources.GetObject("Search_Button.BackgroundImage");
            Search_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Button.Location = new Point(50, 12);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(35, 30);
            Search_Button.TabIndex = 11;
            Search_Button.UseVisualStyleBackColor = true;
            Search_Button.Click += Search_Button_Click;
            // 
            // Menu_button
            // 
            Menu_button.BackColor = Color.Transparent;
            Menu_button.BackgroundImage = (Image)resources.GetObject("Menu_button.BackgroundImage");
            Menu_button.BackgroundImageLayout = ImageLayout.Stretch;
            Menu_button.Location = new Point(12, 12);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new Size(32, 30);
            Menu_button.TabIndex = 10;
            Menu_button.UseVisualStyleBackColor = false;
            Menu_button.Click += Menu_button_Click;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 50);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(122, 672);
            PanelL.TabIndex = 2;
            // 
            // PanelR
            // 
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(1203, 50);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(122, 672);
            PanelR.TabIndex = 3;
            // 
            // mail_label
            // 
            mail_label.AutoSize = true;
            mail_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            mail_label.ForeColor = Color.White;
            mail_label.Location = new Point(434, 266);
            mail_label.Name = "mail_label";
            mail_label.Size = new Size(116, 45);
            mail_label.TabIndex = 12;
            mail_label.Text = "Почта:";
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            login_label.ForeColor = Color.White;
            login_label.Location = new Point(434, 221);
            login_label.Name = "login_label";
            login_label.Size = new Size(117, 45);
            login_label.TabIndex = 11;
            login_label.Text = "Логин:";
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lastname_label.ForeColor = Color.White;
            lastname_label.Location = new Point(434, 176);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(159, 45);
            lastname_label.TabIndex = 10;
            lastname_label.Text = "Фамилия:";
            // 
            // firstname_label
            // 
            firstname_label.AutoSize = true;
            firstname_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            firstname_label.ForeColor = Color.White;
            firstname_label.Location = new Point(434, 131);
            firstname_label.Name = "firstname_label";
            firstname_label.Size = new Size(89, 45);
            firstname_label.TabIndex = 9;
            firstname_label.Text = "Имя:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(128, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(612, 131);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 43);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(612, 176);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 43);
            textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(612, 221);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 43);
            textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(612, 266);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(320, 43);
            textBox4.TabIndex = 16;
            // 
            // Save_button
            // 
            Save_button.BackColor = Color.White;
            Save_button.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Save_button.Location = new Point(675, 452);
            Save_button.Margin = new Padding(3, 2, 3, 2);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(200, 46);
            Save_button.TabIndex = 17;
            Save_button.Text = "Сохранить";
            Save_button.UseVisualStyleBackColor = false;
            Save_button.Click += Save_button_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // account_edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1325, 722);
            Controls.Add(Save_button);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(mail_label);
            Controls.Add(login_label);
            Controls.Add(lastname_label);
            Controls.Add(firstname_label);
            Controls.Add(pictureBox1);
            Controls.Add(PanelR);
            Controls.Add(PanelL);
            Controls.Add(PanelT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "account_edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактор аккаунта";
            Load += account_edit_Load;
            PanelT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelT;
        private Button Home_button;
        private Button Search_Button;
        private Button Menu_button;
        private Panel PanelL;
        private Panel PanelR;
        private Label mail_label;
        private Label login_label;
        private Label lastname_label;
        private Label firstname_label;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Save_button;
        private OpenFileDialog openFileDialog1;
    }
}