namespace prjkn
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            PanelT = new Panel();
            Home_button = new Button();
            Search_button = new Button();
            Menu_button = new Button();
            PanelL = new Panel();
            PanelR = new Panel();
            label3 = new Label();
            login_textBox = new TextBox();
            label5 = new Label();
            pass_textBox = new TextBox();
            Log_in_button = new Button();
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
            PanelT.Margin = new Padding(3, 2, 3, 2);
            PanelT.Name = "PanelT";
            PanelT.Size = new Size(680, 50);
            PanelT.TabIndex = 0;
            // 
            // Home_button
            // 
            Home_button.BackgroundImage = (Image)resources.GetObject("Home_button.BackgroundImage");
            Home_button.BackgroundImageLayout = ImageLayout.Stretch;
            Home_button.FlatAppearance.BorderSize = 0;
            Home_button.FlatStyle = FlatStyle.Flat;
            Home_button.Location = new Point(91, 12);
            Home_button.Margin = new Padding(3, 2, 3, 2);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(35, 30);
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
            Search_button.Location = new Point(50, 12);
            Search_button.Margin = new Padding(3, 2, 3, 2);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(35, 30);
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
            Menu_button.Location = new Point(12, 12);
            Menu_button.Margin = new Padding(3, 2, 3, 2);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new Size(32, 30);
            Menu_button.TabIndex = 0;
            Menu_button.UseVisualStyleBackColor = true;
            Menu_button.Click += Menu_button_Click;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 50);
            PanelL.Margin = new Padding(3, 2, 3, 2);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(122, 420);
            PanelL.TabIndex = 1;
            // 
            // PanelR
            // 
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(558, 50);
            PanelR.Margin = new Padding(3, 2, 3, 2);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(122, 420);
            PanelR.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(141, 154);
            label3.Name = "label3";
            label3.Size = new Size(117, 45);
            label3.TabIndex = 8;
            label3.Text = "Логин:";
            // 
            // login_textBox
            // 
            login_textBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            login_textBox.Location = new Point(272, 166);
            login_textBox.Margin = new Padding(3, 2, 3, 2);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(260, 32);
            login_textBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(140, 206);
            label5.Name = "label5";
            label5.Size = new Size(137, 45);
            label5.TabIndex = 12;
            label5.Text = "Пароль:";
            // 
            // pass_textBox
            // 
            pass_textBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pass_textBox.Location = new Point(272, 218);
            pass_textBox.Margin = new Padding(3, 2, 3, 2);
            pass_textBox.Name = "pass_textBox";
            pass_textBox.Size = new Size(260, 32);
            pass_textBox.TabIndex = 13;
            pass_textBox.UseSystemPasswordChar = true;
            // 
            // Log_in_button
            // 
            Log_in_button.BackColor = Color.White;
            Log_in_button.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Log_in_button.Location = new Point(242, 323);
            Log_in_button.Margin = new Padding(3, 2, 3, 2);
            Log_in_button.Name = "Log_in_button";
            Log_in_button.Size = new Size(175, 45);
            Log_in_button.TabIndex = 14;
            Log_in_button.Text = "Войти";
            Log_in_button.UseVisualStyleBackColor = false;
            // 
            // pass_checkBox
            // 
            pass_checkBox.AutoSize = true;
            pass_checkBox.BackColor = Color.Transparent;
            pass_checkBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            pass_checkBox.ForeColor = Color.White;
            pass_checkBox.Location = new Point(353, 254);
            pass_checkBox.Margin = new Padding(3, 2, 3, 2);
            pass_checkBox.Name = "pass_checkBox";
            pass_checkBox.Size = new Size(179, 29);
            pass_checkBox.TabIndex = 15;
            pass_checkBox.Text = "Показать пароль";
            pass_checkBox.UseVisualStyleBackColor = false;
            pass_checkBox.CheckedChanged += pass_checkBox_CheckedChanged;
            // 
            // Log_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(680, 470);
            Controls.Add(pass_checkBox);
            Controls.Add(Log_in_button);
            Controls.Add(pass_textBox);
            Controls.Add(label5);
            Controls.Add(login_textBox);
            Controls.Add(label3);
            Controls.Add(PanelR);
            Controls.Add(PanelL);
            Controls.Add(PanelT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Log_in";
            Text = "Вход";
            Load += Log_in_Load;
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
        private Label label3;
        private TextBox login_textBox;
        private Label label5;
        private TextBox pass_textBox;
        private Button Log_in_button;
        private CheckBox pass_checkBox;
    }
}