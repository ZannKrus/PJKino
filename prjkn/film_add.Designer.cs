namespace prjkn
{
    partial class film_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(film_add));
            PanelT = new Panel();
            Home_button = new Button();
            Search_button = new Button();
            Menu_button = new Button();
            PanelL = new Panel();
            PanelR = new Panel();
            button1 = new Button();
            genre = new TextBox();
            label5 = new Label();
            actors = new TextBox();
            label4 = new Label();
            dir = new TextBox();
            label3 = new Label();
            desc = new TextBox();
            label2 = new Label();
            name = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            PanelT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            PanelT.Size = new Size(766, 50);
            PanelT.TabIndex = 25;
            // 
            // Home_button
            // 
            Home_button.BackgroundImage = (Image)resources.GetObject("Home_button.BackgroundImage");
            Home_button.BackgroundImageLayout = ImageLayout.Stretch;
            Home_button.FlatAppearance.BorderSize = 0;
            Home_button.FlatStyle = FlatStyle.Flat;
            Home_button.Location = new Point(94, 11);
            Home_button.Margin = new Padding(3, 2, 3, 2);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(35, 30);
            Home_button.TabIndex = 4;
            Home_button.UseVisualStyleBackColor = true;
            Home_button.Click += Home_button_Click;
            // 
            // Search_button
            // 
            Search_button.BackgroundImage = (Image)resources.GetObject("Search_button.BackgroundImage");
            Search_button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_button.FlatAppearance.BorderSize = 0;
            Search_button.FlatStyle = FlatStyle.Flat;
            Search_button.Location = new Point(53, 11);
            Search_button.Margin = new Padding(3, 2, 3, 2);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(35, 30);
            Search_button.TabIndex = 3;
            Search_button.UseVisualStyleBackColor = true;
            Search_button.Click += Search_button_Click;
            // 
            // Menu_button
            // 
            Menu_button.BackgroundImage = (Image)resources.GetObject("Menu_button.BackgroundImage");
            Menu_button.BackgroundImageLayout = ImageLayout.Stretch;
            Menu_button.FlatAppearance.BorderSize = 0;
            Menu_button.FlatStyle = FlatStyle.Flat;
            Menu_button.Location = new Point(15, 11);
            Menu_button.Margin = new Padding(3, 2, 3, 2);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new Size(32, 30);
            Menu_button.TabIndex = 2;
            Menu_button.UseVisualStyleBackColor = true;
            Menu_button.Click += Menu_button_Click;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 50);
            PanelL.Margin = new Padding(3, 2, 3, 2);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(122, 462);
            PanelL.TabIndex = 26;
            // 
            // PanelR
            // 
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(644, 50);
            PanelR.Margin = new Padding(3, 2, 3, 2);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(122, 462);
            PanelR.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(312, 428);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(200, 46);
            button1.TabIndex = 38;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // genre
            // 
            genre.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            genre.Location = new Point(312, 255);
            genre.Margin = new Padding(3, 2, 3, 2);
            genre.Name = "genre";
            genre.Size = new Size(320, 45);
            genre.TabIndex = 37;
            genre.TextChanged += genre_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(173, 254);
            label5.Name = "label5";
            label5.Size = new Size(124, 45);
            label5.TabIndex = 36;
            label5.Text = "Жанры";
            // 
            // actors
            // 
            actors.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            actors.Location = new Point(312, 210);
            actors.Margin = new Padding(3, 2, 3, 2);
            actors.Name = "actors";
            actors.Size = new Size(320, 45);
            actors.TabIndex = 35;
            actors.TextChanged += actors_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(169, 210);
            label4.Name = "label4";
            label4.Size = new Size(129, 45);
            label4.TabIndex = 34;
            label4.Text = "Актеры";
            // 
            // dir
            // 
            dir.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            dir.Location = new Point(312, 165);
            dir.Margin = new Padding(3, 2, 3, 2);
            dir.Name = "dir";
            dir.Size = new Size(320, 45);
            dir.TabIndex = 33;
            dir.TextChanged += dir_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(135, 165);
            label3.Name = "label3";
            label3.Size = new Size(164, 45);
            label3.TabIndex = 32;
            label3.Text = "Режиссер";
            // 
            // desc
            // 
            desc.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            desc.Location = new Point(312, 120);
            desc.Margin = new Padding(3, 2, 3, 2);
            desc.Name = "desc";
            desc.Size = new Size(320, 45);
            desc.TabIndex = 31;
            desc.TextChanged += desc_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(135, 120);
            label2.Name = "label2";
            label2.Size = new Size(166, 45);
            label2.TabIndex = 30;
            label2.Text = "Описание";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(312, 75);
            name.Margin = new Padding(3, 2, 3, 2);
            name.Name = "name";
            name.Size = new Size(320, 45);
            name.TabIndex = 29;
            name.TextChanged += name_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 75);
            label1.Name = "label1";
            label1.Size = new Size(160, 45);
            label1.TabIndex = 28;
            label1.Text = "Название";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(312, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 118);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(169, 305);
            label6.Name = "label6";
            label6.Size = new Size(126, 45);
            label6.TabIndex = 40;
            label6.Text = "Постер";
            // 
            // film_add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(766, 512);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(genre);
            Controls.Add(label5);
            Controls.Add(actors);
            Controls.Add(label4);
            Controls.Add(dir);
            Controls.Add(label3);
            Controls.Add(desc);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(label1);
            Controls.Add(PanelR);
            Controls.Add(PanelL);
            Controls.Add(PanelT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "film_add";
            Text = "Добавить фильм";
            Load += film_add_Load;
            PanelT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PanelT;
        private Panel PanelL;
        private Panel PanelR;
        private Button button1;
        private TextBox genre;
        private Label label5;
        private TextBox actors;
        private Label label4;
        private TextBox dir;
        private Label label3;
        private TextBox desc;
        private Label label2;
        private TextBox name;
        private Label label1;
        private Button Menu_button;
        private Button Search_button;
        private Button Home_button;
        private PictureBox pictureBox1;
        private Label label6;
    }
}