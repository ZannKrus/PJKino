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
            panel1 = new Panel();
            label3 = new Label();
            mainrole_listBox = new ListBox();
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
            genre_listBox = new ListBox();
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
            PanelR.Location = new Point(1565, 67);
            PanelR.Margin = new Padding(3, 4, 3, 4);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(139, 988);
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
            PanelT.Margin = new Padding(3, 4, 3, 4);
            PanelT.Name = "PanelT";
            PanelT.Size = new Size(1704, 67);
            PanelT.TabIndex = 1;
            // 
            // PanelBack
            // 
            PanelBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelBack.BackgroundImageLayout = ImageLayout.Stretch;
            PanelBack.Controls.Add(pictureBox1);
            PanelBack.Location = new Point(1608, 4);
            PanelBack.Margin = new Padding(3, 4, 3, 4);
            PanelBack.Name = "PanelBack";
            PanelBack.Size = new Size(82, 59);
            PanelBack.TabIndex = 21;
            PanelBack.Click += PanelBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 59);
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
            Home_button.Location = new Point(107, 15);
            Home_button.Margin = new Padding(3, 4, 3, 4);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(40, 40);
            Home_button.TabIndex = 4;
            Home_button.UseVisualStyleBackColor = false;
            Home_button.Click += Home_button_Click;
            // 
            // Search_Button
            // 
            Search_Button.BackColor = Color.Transparent;
            Search_Button.BackgroundImage = (Image)resources.GetObject("Search_Button.BackgroundImage");
            Search_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Button.Location = new Point(61, 15);
            Search_Button.Margin = new Padding(3, 4, 3, 4);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(40, 40);
            Search_Button.TabIndex = 1;
            Search_Button.UseVisualStyleBackColor = false;
            Search_Button.Click += Search_Button_Click;
            // 
            // Menu_button
            // 
            Menu_button.BackColor = Color.Transparent;
            Menu_button.BackgroundImage = (Image)resources.GetObject("Menu_button.BackgroundImage");
            Menu_button.BackgroundImageLayout = ImageLayout.Stretch;
            Menu_button.Location = new Point(17, 15);
            Menu_button.Margin = new Padding(3, 4, 3, 4);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new Size(37, 40);
            Menu_button.TabIndex = 0;
            Menu_button.UseVisualStyleBackColor = false;
            Menu_button.Click += Menu_button_Click;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 67);
            PanelL.Margin = new Padding(3, 4, 3, 4);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(139, 988);
            PanelL.TabIndex = 2;
            PanelL.Paint += PanelL_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(146, 75);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.MaximumSize = new Size(343, 600);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(343, 600);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // film_name
            // 
            film_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            film_name.AutoSize = true;
            film_name.Font = new Font("Times New Roman", 50.25F, FontStyle.Regular, GraphicsUnit.Point);
            film_name.ForeColor = Color.White;
            film_name.Location = new Point(496, 68);
            film_name.Name = "film_name";
            film_name.Size = new Size(436, 95);
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
            director_label_fn.Location = new Point(0, 69);
            director_label_fn.Name = "director_label_fn";
            director_label_fn.Size = new Size(120, 29);
            director_label_fn.TabIndex = 15;
            director_label_fn.Text = "Режиссер:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(genre_listBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(mainrole_listBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(director_label_fn);
            panel1.Location = new Point(1266, 281);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 509);
            panel1.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 301);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 22;
            label3.Text = "Жанры:";
            // 
            // mainrole_listBox
            // 
            mainrole_listBox.BackColor = Color.Black;
            mainrole_listBox.BorderStyle = BorderStyle.None;
            mainrole_listBox.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            mainrole_listBox.ForeColor = Color.White;
            mainrole_listBox.FormattingEnabled = true;
            mainrole_listBox.ItemHeight = 29;
            mainrole_listBox.Location = new Point(3, 139);
            mainrole_listBox.Name = "mainrole_listBox";
            mainrole_listBox.Size = new Size(258, 145);
            mainrole_listBox.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 107);
            label2.Name = "label2";
            label2.Size = new Size(197, 29);
            label2.TabIndex = 21;
            label2.Text = "В главных ролях:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 35);
            label1.Name = "label1";
            label1.Size = new Size(120, 29);
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
            description_label.MinimumSize = new Size(526, 0);
            description_label.Name = "description_label";
            description_label.Size = new Size(526, 29);
            description_label.TabIndex = 14;
            description_label.Text = "Описание";
            description_label.Click += description_label_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(description_label);
            flowLayoutPanel1.Location = new Point(496, 173);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(763, 396);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "★ 10", "★ 9", "★ 8", "★ 7", "★ 6", "★ 5", "★ 4", "★ 3", "★ 2", "★ 1" });
            comboBox1.Location = new Point(393, 683);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.MaxDropDownItems = 10;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(95, 49);
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
            comboBox2.Location = new Point(146, 683);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(239, 49);
            comboBox2.TabIndex = 24;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // save
            // 
            save.Enabled = false;
            save.Location = new Point(146, 744);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(86, 31);
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
            flowLayoutPanel2.Location = new Point(146, 1012);
            flowLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel2.MaximumSize = new Size(686, 1333);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(686, 27);
            flowLayoutPanel2.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(146, 845);
            label4.Name = "label4";
            label4.Size = new Size(173, 54);
            label4.TabIndex = 27;
            label4.Text = "Отзывы:";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(146, 909);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(685, 93);
            richTextBox1.TabIndex = 28;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(839, 908);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 29;
            button1.Text = "Отправить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // genre_listBox
            // 
            genre_listBox.BackColor = Color.Black;
            genre_listBox.BorderStyle = BorderStyle.None;
            genre_listBox.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            genre_listBox.ForeColor = Color.White;
            genre_listBox.FormattingEnabled = true;
            genre_listBox.ItemHeight = 29;
            genre_listBox.Location = new Point(0, 333);
            genre_listBox.Name = "genre_listBox";
            genre_listBox.Size = new Size(258, 145);
            genre_listBox.TabIndex = 31;
            // 
            // Film_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1704, 1055);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Panel PanelBack;
        private Panel panel1;
        private Label description_label;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button save;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button button1;
        private ListBox mainrole_listBox;
        private ListBox genre_listBox;
    }
}