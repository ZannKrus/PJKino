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
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            Home_button = new Button();
            Search_Button = new Button();
            Menu_button = new Button();
            PanelL = new Panel();
            pictureBox2 = new PictureBox();
            film_name = new Label();
            description_label = new Label();
            director_label = new Label();
            director_name_label = new Label();
            mainrole_label = new Label();
            mainrole_name_label = new Label();
            genre_label = new Label();
            genre_name_label = new Label();
            PanelT.SuspendLayout();
            PanelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PanelR
            // 
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(870, 50);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(122, 457);
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
            PanelT.Size = new Size(992, 50);
            PanelT.TabIndex = 1;
            // 
            // PanelBack
            // 
            PanelBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelBack.BackgroundImageLayout = ImageLayout.Stretch;
            PanelBack.Controls.Add(pictureBox3);
            PanelBack.Controls.Add(pictureBox1);
            PanelBack.Location = new Point(908, 3);
            PanelBack.Name = "PanelBack";
            PanelBack.Size = new Size(72, 44);
            PanelBack.TabIndex = 21;
            PanelBack.Paint += PanelBack_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox3.Location = new Point(14, 0);
            pictureBox3.MaximumSize = new Size(44, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 44);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Location = new Point(-50, 0);
            pictureBox1.MaximumSize = new Size(44, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            PanelL.Size = new Size(122, 457);
            PanelL.TabIndex = 2;
            PanelL.Paint += PanelL_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(159, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 205);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // film_name
            // 
            film_name.AutoSize = true;
            film_name.Font = new Font("Times New Roman", 50.25F, FontStyle.Regular, GraphicsUnit.Point);
            film_name.ForeColor = Color.White;
            film_name.Location = new Point(416, 68);
            film_name.Name = "film_name";
            film_name.Size = new Size(350, 76);
            film_name.TabIndex = 13;
            film_name.Text = "Film_Name";
            film_name.TextAlign = ContentAlignment.MiddleCenter;
            film_name.Click += film_name_Click;
            // 
            // description_label
            // 
            description_label.AutoSize = true;
            description_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            description_label.ForeColor = Color.White;
            description_label.Location = new Point(315, 169);
            description_label.Name = "description_label";
            description_label.Size = new Size(95, 22);
            description_label.TabIndex = 14;
            description_label.Text = "Описание";
            // 
            // director_label
            // 
            director_label.AutoSize = true;
            director_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            director_label.ForeColor = Color.White;
            director_label.Location = new Point(693, 169);
            director_label.Name = "director_label";
            director_label.Size = new Size(98, 22);
            director_label.TabIndex = 15;
            director_label.Text = "Режиссер:";
            // 
            // director_name_label
            // 
            director_name_label.AutoSize = true;
            director_name_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            director_name_label.ForeColor = Color.White;
            director_name_label.Location = new Point(693, 204);
            director_name_label.Name = "director_name_label";
            director_name_label.Size = new Size(98, 22);
            director_name_label.TabIndex = 16;
            director_name_label.Text = "Режиссер:";
            // 
            // mainrole_label
            // 
            mainrole_label.AutoSize = true;
            mainrole_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            mainrole_label.ForeColor = Color.White;
            mainrole_label.Location = new Point(693, 238);
            mainrole_label.Name = "mainrole_label";
            mainrole_label.Size = new Size(155, 22);
            mainrole_label.TabIndex = 17;
            mainrole_label.Text = "В главных ролях:";
            // 
            // mainrole_name_label
            // 
            mainrole_name_label.AutoSize = true;
            mainrole_name_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            mainrole_name_label.ForeColor = Color.White;
            mainrole_name_label.Location = new Point(693, 275);
            mainrole_name_label.Name = "mainrole_name_label";
            mainrole_name_label.Size = new Size(155, 22);
            mainrole_name_label.TabIndex = 18;
            mainrole_name_label.Text = "В главных ролях:";
            // 
            // genre_label
            // 
            genre_label.AutoSize = true;
            genre_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            genre_label.ForeColor = Color.White;
            genre_label.Location = new Point(693, 310);
            genre_label.Name = "genre_label";
            genre_label.Size = new Size(77, 22);
            genre_label.TabIndex = 19;
            genre_label.Text = "Жанры:";
            // 
            // genre_name_label
            // 
            genre_name_label.AutoSize = true;
            genre_name_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            genre_name_label.ForeColor = Color.White;
            genre_name_label.Location = new Point(693, 342);
            genre_name_label.Name = "genre_name_label";
            genre_name_label.Size = new Size(77, 22);
            genre_name_label.TabIndex = 20;
            genre_name_label.Text = "Жанры:";
            // 
            // Film_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(992, 507);
            Controls.Add(genre_name_label);
            Controls.Add(genre_label);
            Controls.Add(mainrole_name_label);
            Controls.Add(mainrole_label);
            Controls.Add(director_name_label);
            Controls.Add(director_label);
            Controls.Add(description_label);
            Controls.Add(film_name);
            Controls.Add(pictureBox2);
            Controls.Add(PanelL);
            Controls.Add(PanelR);
            Controls.Add(PanelT);
            Name = "Film_Page";
            Text = "Film_Page";
            FormClosing += Film_Page_FormClosing;
            Load += Film_Page_Load;
            PanelT.ResumeLayout(false);
            PanelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label description_label;
        private Label director_label;
        private Label director_name_label;
        private Label mainrole_label;
        private Label mainrole_name_label;
        private Label genre_label;
        private Label genre_name_label;
        private Panel PanelBack;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}