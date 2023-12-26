namespace prjkn
{
    partial class Film_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film_Page));
            PanelR = new Panel();
            PanelT = new Panel();
            PanelBack = new Panel();
            pictureBox1 = new PictureBox();
            Home_button = new Button();
            Search_Button = new Button();
            Menu_button = new Button();
            PanelL = new Panel();
            pictureBox2 = new PictureBox();
            film_name = new Label();
            director_label_fn = new Label();
            mainrole_label_fn = new Label();
            genre_label = new Label();
            panel1 = new Panel();
            mainrole_label_ln = new Label();
            director_label_ln = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            description_label = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            save = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            PanelT.SuspendLayout();
            PanelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelR
            // 
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(1369, 50);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(122, 888);
            PanelR.TabIndex = 0;
            PanelR.Paint += panel1_Paint;
            // 
            // PanelT
            // 
            PanelT.Controls.Add(PanelBack);
            PanelT.Controls.Add(Home_button);
            PanelT.Controls.Add(Search_Button);
            PanelT.Controls.Add(Menu_button);
            PanelT.Dock = DockStyle.Top;
            PanelT.Location = new Point(0, 0);
            PanelT.Name = "PanelT";
            PanelT.Size = new Size(1491, 50);
            PanelT.TabIndex = 1;
            // 
            // PanelBack
            // 
            PanelBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelBack.BackgroundImageLayout = ImageLayout.Stretch;
            PanelBack.Controls.Add(pictureBox1);
            PanelBack.Location = new Point(1407, 3);
            PanelBack.Name = "PanelBack";
            PanelBack.Size = new Size(72, 44);
            PanelBack.TabIndex = 21;
            PanelBack.Click += PanelBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PanelBack_Click;
            // 
            // Home_button
            // 
            Home_button.BackColor = Color.Transparent;
            Home_button.BackgroundImage = (Image)resources.GetObject("Home_button.BackgroundImage");
            Home_button.BackgroundImageLayout = ImageLayout.Stretch;
            Home_button.Location = new Point(94, 11);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(35, 30);
            Home_button.TabIndex = 4;
            Home_button.UseVisualStyleBackColor = false;
            Home_button.Click += Home_button_Click;
            // 
            // Search_Button
            // 
            Search_Button.BackColor = Color.Transparent;
            Search_Button.BackgroundImage = (Image)resources.GetObject("Search_Button.BackgroundImage");
            Search_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Button.Location = new Point(53, 11);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(35, 30);
            Search_Button.TabIndex = 1;
            Search_Button.UseVisualStyleBackColor = false;
            Search_Button.Click += Search_Button_Click;
            // 
            // Menu_button
            // 
            Menu_button.BackColor = Color.Transparent;
            Menu_button.BackgroundImage = (Image)resources.GetObject("Menu_button.BackgroundImage");
            Menu_button.BackgroundImageLayout = ImageLayout.Stretch;
            Menu_button.Location = new Point(15, 11);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new Size(32, 30);
            Menu_button.TabIndex = 0;
            Menu_button.UseVisualStyleBackColor = false;
            Menu_button.Click += Menu_button_Click;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 50);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(122, 888);
            PanelL.TabIndex = 2;
            PanelL.Paint += PanelL_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(128, 56);
            pictureBox2.MaximumSize = new Size(300, 450);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 450);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // film_name
            // 
            film_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            film_name.AutoSize = true;
            film_name.Font = new Font("Times New Roman", 50.25F, FontStyle.Regular, GraphicsUnit.Point);
            film_name.ForeColor = Color.White;
            film_name.Location = new Point(434, 51);
            film_name.Name = "film_name";
            film_name.Size = new Size(350, 76);
            film_name.TabIndex = 13;
            film_name.Text = "Film_Name";
            film_name.TextAlign = ContentAlignment.MiddleCenter;
            film_name.Click += film_name_Click;
            // 
            // director_label_fn
            // 
            director_label_fn.AutoSize = true;
            director_label_fn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            director_label_fn.ForeColor = Color.White;
            director_label_fn.Location = new Point(0, 52);
            director_label_fn.Name = "director_label_fn";
            director_label_fn.Size = new Size(98, 22);
            director_label_fn.TabIndex = 15;
            director_label_fn.Text = "Режиссер:";
            // 
            // mainrole_label_fn
            // 
            mainrole_label_fn.AutoSize = true;
            mainrole_label_fn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            mainrole_label_fn.ForeColor = Color.White;
            mainrole_label_fn.Location = new Point(0, 154);
            mainrole_label_fn.Name = "mainrole_label_fn";
            mainrole_label_fn.Size = new Size(155, 22);
            mainrole_label_fn.TabIndex = 17;
            mainrole_label_fn.Text = "В главных ролях:";
            // 
            // genre_label
            // 
            genre_label.AutoSize = true;
            genre_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            genre_label.ForeColor = Color.White;
            genre_label.Location = new Point(0, 250);
            genre_label.Name = "genre_label";
            genre_label.Size = new Size(77, 22);
            genre_label.TabIndex = 19;
            genre_label.Text = "Жанры:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(mainrole_label_ln);
            panel1.Controls.Add(director_label_ln);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(genre_label);
            panel1.Controls.Add(director_label_fn);
            panel1.Controls.Add(mainrole_label_fn);
            panel1.Location = new Point(1108, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 295);
            panel1.TabIndex = 21;
            // 
            // mainrole_label_ln
            // 
            mainrole_label_ln.AutoSize = true;
            mainrole_label_ln.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            mainrole_label_ln.ForeColor = Color.White;
            mainrole_label_ln.Location = new Point(44, 154);
            mainrole_label_ln.Name = "mainrole_label_ln";
            mainrole_label_ln.Size = new Size(155, 22);
            mainrole_label_ln.TabIndex = 24;
            mainrole_label_ln.Text = "В главных ролях:";
            // 
            // director_label_ln
            // 
            director_label_ln.AutoSize = true;
            director_label_ln.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            director_label_ln.ForeColor = Color.White;
            director_label_ln.Location = new Point(79, 52);
            director_label_ln.Name = "director_label_ln";
            director_label_ln.Size = new Size(98, 22);
            director_label_ln.TabIndex = 23;
            director_label_ln.Text = "Режиссер:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 224);
            label3.Name = "label3";
            label3.Size = new Size(77, 22);
            label3.TabIndex = 22;
            label3.Text = "Жанры:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 128);
            label2.Name = "label2";
            label2.Size = new Size(155, 22);
            label2.TabIndex = 21;
            label2.Text = "В главных ролях:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 26);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 20;
            label1.Text = "Режиссер:";
            // 
            // description_label
            // 
            description_label.AutoSize = true;
            description_label.Dock = DockStyle.Fill;
            description_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            description_label.ForeColor = Color.White;
            description_label.Location = new Point(3, 0);
            description_label.MinimumSize = new Size(460, 0);
            description_label.Name = "description_label";
            description_label.Size = new Size(460, 22);
            description_label.TabIndex = 14;
            description_label.Text = "Описание";
            description_label.Click += description_label_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(description_label);
            flowLayoutPanel1.Location = new Point(434, 130);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(668, 297);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "★ 10", "★ 9", "★ 8", "★ 7", "★ 6", "★ 5", "★ 4", "★ 3", "★ 2", "★ 1" });
            comboBox1.Location = new Point(344, 512);
            comboBox1.MaxDropDownItems = 10;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(84, 40);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "", "Любимое", "Просмотрено", "В планах", "Неинтересен" });
            comboBox2.Location = new Point(128, 512);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(210, 40);
            comboBox2.TabIndex = 24;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // save
            // 
            save.Enabled = false;
            save.Location = new Point(128, 558);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 25;
            save.Text = "Сохранить";
            save.UseVisualStyleBackColor = true;
            save.Visible = false;
            save.Click += save_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Location = new Point(128, 759);
            flowLayoutPanel2.MaximumSize = new Size(600, 1000);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(600, 167);
            flowLayoutPanel2.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(128, 634);
            label4.Name = "label4";
            label4.Size = new Size(141, 45);
            label4.TabIndex = 27;
            label4.Text = "Отзывы:";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(128, 682);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(600, 71);
            richTextBox1.TabIndex = 28;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(734, 681);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 29;
            button1.Text = "Отправить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Film_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1491, 938);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(save);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(film_name);
            Controls.Add(pictureBox2);
            Controls.Add(PanelL);
            Controls.Add(PanelR);
            Controls.Add(PanelT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Film_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Film_Page";
            Load += Film_Page_Load;
            PanelT.ResumeLayout(false);
            PanelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelR;
        private Panel PanelT;
        private Panel PanelL;
        private Button Menu_button;
        private Button Search_Button;
        private Button Home_button;
        private PictureBox pictureBox2;
        private Label film_name;
        private Label director_label_fn;
        private Label mainrole_label_fn;
        private Label genre_label;
        private Panel PanelBack;
        private Panel panel1;
        private Label description_label;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label mainrole_label_ln;
        private Label director_label_ln;
        private PictureBox pictureBox1;
        private Button save;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}