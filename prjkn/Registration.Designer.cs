namespace prjkn
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            PanelT = new Panel();
            Home_button = new Button();
            Search_button = new Button();
            Menu_button = new Button();
            PanelL = new Panel();
            PanelR = new Panel();
            label1 = new Label();
            fn_textBox = new TextBox();
            label2 = new Label();
            ln_textBox = new TextBox();
            label3 = new Label();
            login_textBox = new TextBox();
            label4 = new Label();
            mail_textBox = new TextBox();
            label5 = new Label();
            pass_textBox = new TextBox();
            Registration_button = new Button();
            pass_checkBox = new CheckBox();
            PanelT.SuspendLayout();
            SuspendLayout();
            // 
            // PanelT
            // 
            PanelT.Controls.Add(Home_button);
            PanelT.Controls.Add(Search_button);
            PanelT.Controls.Add(Menu_button);
            PanelT.Dock = DockStyle.Top;
            PanelT.Location = new Point(0, 0);
            PanelT.Name = "PanelT";
            PanelT.Size = new Size(968, 67);
            PanelT.TabIndex = 0;
            // 
            // Home_button
            // 
            Home_button.BackgroundImage = (Image)resources.GetObject("Home_button.BackgroundImage");
            Home_button.BackgroundImageLayout = ImageLayout.Stretch;
            Home_button.FlatAppearance.BorderSize = 0;
            Home_button.FlatStyle = FlatStyle.Flat;
            Home_button.Location = new Point(104, 16);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(40, 40);
            Home_button.TabIndex = 2;
            Home_button.UseVisualStyleBackColor = true;
            Home_button.Click += Home_button_Click;
            // 
            // Search_button
            // 
            Search_button.BackgroundImage = (Image)resources.GetObject("Search_button.BackgroundImage");
            Search_button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_button.FlatAppearance.BorderSize = 0;
            Search_button.FlatStyle = FlatStyle.Flat;
            Search_button.Location = new Point(57, 16);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(40, 40);
            Search_button.TabIndex = 1;
            Search_button.UseVisualStyleBackColor = true;
            Search_button.Click += Search_button_Click;
            // 
            // Menu_button
            // 
            Menu_button.BackgroundImage = (Image)resources.GetObject("Menu_button.BackgroundImage");
            Menu_button.BackgroundImageLayout = ImageLayout.Stretch;
            Menu_button.FlatAppearance.BorderSize = 0;
            Menu_button.FlatStyle = FlatStyle.Flat;
            Menu_button.Location = new Point(14, 16);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new Size(37, 40);
            Menu_button.TabIndex = 0;
            Menu_button.UseVisualStyleBackColor = true;
            Menu_button.Click += Menu_button_Click;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 67);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(139, 886);
            PanelL.TabIndex = 1;
            // 
            // PanelR
            // 
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(829, 67);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(139, 886);
            PanelR.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(150, 116);
            label1.Name = "label1";
            label1.Size = new Size(110, 54);
            label1.TabIndex = 3;
            label1.Text = "Имя:";
            // 
            // fn_textBox
            // 
            fn_textBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            fn_textBox.Location = new Point(161, 173);
            fn_textBox.Name = "fn_textBox";
            fn_textBox.Size = new Size(645, 38);
            fn_textBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(150, 244);
            label2.Name = "label2";
            label2.Size = new Size(196, 54);
            label2.TabIndex = 5;
            label2.Text = "Фамилия:";
            // 
            // ln_textBox
            // 
            ln_textBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ln_textBox.Location = new Point(161, 307);
            ln_textBox.Name = "ln_textBox";
            ln_textBox.Size = new Size(645, 38);
            ln_textBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(150, 371);
            label3.Name = "label3";
            label3.Size = new Size(143, 54);
            label3.TabIndex = 7;
            label3.Text = "Логин:";
            // 
            // login_textBox
            // 
            login_textBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            login_textBox.Location = new Point(161, 428);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(645, 38);
            login_textBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(150, 497);
            label4.Name = "label4";
            label4.Size = new Size(143, 54);
            label4.TabIndex = 9;
            label4.Text = "Почта:";
            // 
            // mail_textBox
            // 
            mail_textBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            mail_textBox.Location = new Point(161, 555);
            mail_textBox.Name = "mail_textBox";
            mail_textBox.Size = new Size(645, 38);
            mail_textBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(150, 617);
            label5.Name = "label5";
            label5.Size = new Size(169, 54);
            label5.TabIndex = 11;
            label5.Text = "Пароль:";
            // 
            // pass_textBox
            // 
            pass_textBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pass_textBox.Location = new Point(161, 675);
            pass_textBox.Name = "pass_textBox";
            pass_textBox.Size = new Size(645, 38);
            pass_textBox.TabIndex = 12;
            pass_textBox.UseSystemPasswordChar = true;
            // 
            // Registration_button
            // 
            Registration_button.BackColor = Color.White;
            Registration_button.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Registration_button.Location = new Point(278, 804);
            Registration_button.Name = "Registration_button";
            Registration_button.Size = new Size(401, 63);
            Registration_button.TabIndex = 13;
            Registration_button.Text = "Зарегистрироваться";
            Registration_button.UseVisualStyleBackColor = false;
            Registration_button.Click += Registration_button_Click;
            // 
            // pass_checkBox
            // 
            pass_checkBox.AutoSize = true;
            pass_checkBox.BackColor = Color.Transparent;
            pass_checkBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pass_checkBox.ForeColor = Color.White;
            pass_checkBox.Location = new Point(593, 719);
            pass_checkBox.Name = "pass_checkBox";
            pass_checkBox.Size = new Size(213, 35);
            pass_checkBox.TabIndex = 16;
            pass_checkBox.Text = "Показать пароль";
            pass_checkBox.UseVisualStyleBackColor = false;
            pass_checkBox.CheckedChanged += pass_checkBox_CheckedChanged;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(968, 953);
            Controls.Add(pass_checkBox);
            Controls.Add(Registration_button);
            Controls.Add(pass_textBox);
            Controls.Add(label5);
            Controls.Add(mail_textBox);
            Controls.Add(label4);
            Controls.Add(login_textBox);
            Controls.Add(label3);
            Controls.Add(ln_textBox);
            Controls.Add(label2);
            Controls.Add(fn_textBox);
            Controls.Add(label1);
            Controls.Add(PanelR);
            Controls.Add(PanelL);
            Controls.Add(PanelT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Registration";
            Text = "Регистрация";
            Load += Registration_Load;
            PanelT.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelT;
        private Panel PanelL;
        private Panel PanelR;
        private Button Menu_button;
        private Button Search_button;
        private Button Home_button;
        private Label label1;
        private TextBox fn_textBox;
        private Label label2;
        private TextBox ln_textBox;
        private Label label3;
        private TextBox login_textBox;
        private Label label4;
        private TextBox mail_textBox;
        private Label label5;
        private TextBox pass_textBox;
        private Button Registration_button;
        private CheckBox pass_checkBox;
    }
}