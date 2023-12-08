namespace prjkn
{
    partial class account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account));
            PanelT = new Panel();
            Home_button = new Button();
            Search_Button = new Button();
            Menu_button = new Button();
            PanelL = new Panel();
            PanelR = new Panel();
            account_img = new PictureBox();
            firstname_label = new Label();
            lastname_label = new Label();
            login_label = new Label();
            mail_label = new Label();
            edit_linkLabel = new LinkLabel();
            exit_linkLabel = new LinkLabel();
            PanelT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)account_img).BeginInit();
            SuspendLayout();
            // 
            // PanelT
            // 
            PanelT.Controls.Add(Home_button);
            PanelT.Controls.Add(Search_Button);
            PanelT.Controls.Add(Menu_button);
            PanelT.Dock = DockStyle.Top;
            PanelT.Location = new Point(0, 0);
            PanelT.Margin = new Padding(3, 4, 3, 4);
            PanelT.Name = "PanelT";
            PanelT.Size = new Size(1514, 67);
            PanelT.TabIndex = 0;
            // 
            // Home_button
            // 
            Home_button.BackColor = Color.Transparent;
            Home_button.BackgroundImage = (Image)resources.GetObject("Home_button.BackgroundImage");
            Home_button.BackgroundImageLayout = ImageLayout.Stretch;
            Home_button.Location = new Point(104, 16);
            Home_button.Margin = new Padding(3, 4, 3, 4);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(40, 40);
            Home_button.TabIndex = 10;
            Home_button.UseVisualStyleBackColor = false;
            Home_button.Click += Home_button_Click;
            // 
            // Search_Button
            // 
            Search_Button.BackgroundImage = (Image)resources.GetObject("Search_Button.BackgroundImage");
            Search_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Button.Location = new Point(57, 16);
            Search_Button.Margin = new Padding(3, 4, 3, 4);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(40, 40);
            Search_Button.TabIndex = 11;
            Search_Button.UseVisualStyleBackColor = true;
            Search_Button.Click += Search_Button_Click;
            // 
            // Menu_button
            // 
            Menu_button.BackColor = Color.Transparent;
            Menu_button.BackgroundImage = (Image)resources.GetObject("Menu_button.BackgroundImage");
            Menu_button.BackgroundImageLayout = ImageLayout.Stretch;
            Menu_button.Location = new Point(14, 16);
            Menu_button.Margin = new Padding(3, 4, 3, 4);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new Size(37, 40);
            Menu_button.TabIndex = 10;
            Menu_button.UseVisualStyleBackColor = false;
            Menu_button.Click += Menu_button_Click;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 67);
            PanelL.Margin = new Padding(3, 4, 3, 4);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(139, 896);
            PanelL.TabIndex = 1;
            // 
            // PanelR
            // 
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(1375, 67);
            PanelR.Margin = new Padding(3, 4, 3, 4);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(139, 896);
            PanelR.TabIndex = 2;
            // 
            // account_img
            // 
            account_img.Location = new Point(146, 75);
            account_img.Margin = new Padding(3, 4, 3, 4);
            account_img.Name = "account_img";
            account_img.Size = new Size(343, 400);
            account_img.TabIndex = 3;
            account_img.TabStop = false;
            // 
            // firstname_label
            // 
            firstname_label.AutoSize = true;
            firstname_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            firstname_label.ForeColor = Color.White;
            firstname_label.Location = new Point(496, 175);
            firstname_label.Name = "firstname_label";
            firstname_label.Size = new Size(110, 54);
            firstname_label.TabIndex = 4;
            firstname_label.Text = "Имя:";
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lastname_label.ForeColor = Color.White;
            lastname_label.Location = new Point(496, 235);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(196, 54);
            lastname_label.TabIndex = 5;
            lastname_label.Text = "Фамилия:";
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            login_label.ForeColor = Color.White;
            login_label.Location = new Point(496, 295);
            login_label.Name = "login_label";
            login_label.Size = new Size(143, 54);
            login_label.TabIndex = 6;
            login_label.Text = "Логин:";
            // 
            // mail_label
            // 
            mail_label.AutoSize = true;
            mail_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            mail_label.ForeColor = Color.White;
            mail_label.Location = new Point(496, 355);
            mail_label.Name = "mail_label";
            mail_label.Size = new Size(143, 54);
            mail_label.TabIndex = 7;
            mail_label.Text = "Почта:";
            // 
            // edit_linkLabel
            // 
            edit_linkLabel.ActiveLinkColor = Color.White;
            edit_linkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edit_linkLabel.AutoSize = true;
            edit_linkLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            edit_linkLabel.LinkColor = Color.White;
            edit_linkLabel.Location = new Point(1084, 67);
            edit_linkLabel.Name = "edit_linkLabel";
            edit_linkLabel.Size = new Size(291, 54);
            edit_linkLabel.TabIndex = 8;
            edit_linkLabel.TabStop = true;
            edit_linkLabel.Text = "Редактировать";
            edit_linkLabel.VisitedLinkColor = Color.White;
            // 
            // exit_linkLabel
            // 
            exit_linkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exit_linkLabel.AutoSize = true;
            exit_linkLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            exit_linkLabel.LinkColor = Color.Red;
            exit_linkLabel.Location = new Point(1239, 891);
            exit_linkLabel.Name = "exit_linkLabel";
            exit_linkLabel.Size = new Size(136, 54);
            exit_linkLabel.TabIndex = 9;
            exit_linkLabel.TabStop = true;
            exit_linkLabel.Text = "Выйти";
            exit_linkLabel.VisitedLinkColor = Color.Red;
            exit_linkLabel.LinkClicked += exit_linkLabel_LinkClicked;
            // 
            // account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.circles;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1514, 963);
            Controls.Add(exit_linkLabel);
            Controls.Add(edit_linkLabel);
            Controls.Add(mail_label);
            Controls.Add(login_label);
            Controls.Add(lastname_label);
            Controls.Add(firstname_label);
            Controls.Add(account_img);
            Controls.Add(PanelR);
            Controls.Add(PanelL);
            Controls.Add(PanelT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Аккаунт";
            Load += account_Load;
            PanelT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)account_img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelT;
        private Panel PanelL;
        private Panel PanelR;
        private PictureBox account_img;
        private Label firstname_label;
        private Label lastname_label;
        private Label login_label;
        private Label mail_label;
        private LinkLabel edit_linkLabel;
        private LinkLabel exit_linkLabel;
        private Button Menu_button;
        private Button Search_Button;
        private Button Home_button;
    }
}