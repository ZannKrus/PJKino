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
            director_label = new Label();
            mainrole_label = new Label();
            genre_label = new Label();
            panel1 = new Panel();
            description_label = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            PanelT.SuspendLayout();
            PanelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            PanelR.Size = new Size(122, 785);
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
            PanelBack.Controls.Add(pictureBox3);
            PanelBack.Controls.Add(pictureBox1);
            PanelBack.Location = new Point(1407, 3);
            PanelBack.Name = "PanelBack";
            PanelBack.Size = new Size(72, 44);
            PanelBack.TabIndex = 21;
            PanelBack.Click += PanelBack_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox3.Location = new Point(14, 0);
            pictureBox3.MaximumSize = new Size(44, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 0);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
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
            PanelL.Size = new Size(122, 785);
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
            film_name.Location = new Point(434, 48);
            film_name.Name = "film_name";
            film_name.Size = new Size(350, 76);
            film_name.TabIndex = 13;
            film_name.Text = "Film_Name";
            film_name.TextAlign = ContentAlignment.MiddleCenter;
            film_name.Click += film_name_Click;
            // 
            // director_label
            // 
            director_label.AutoSize = true;
            director_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            director_label.ForeColor = Color.White;
            director_label.Location = new Point(0, 0);
            director_label.Name = "director_label";
            director_label.Size = new Size(98, 22);
            director_label.TabIndex = 15;
            director_label.Text = "Режиссер:";
            // 
            // mainrole_label
            // 
            mainrole_label.AutoSize = true;
            mainrole_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            mainrole_label.ForeColor = Color.White;
            mainrole_label.Location = new Point(0, 102);
            mainrole_label.Name = "mainrole_label";
            mainrole_label.Size = new Size(155, 22);
            mainrole_label.TabIndex = 17;
            mainrole_label.Text = "В главных ролях:";
            // 
            // genre_label
            // 
            genre_label.AutoSize = true;
            genre_label.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            genre_label.ForeColor = Color.White;
            genre_label.Location = new Point(0, 197);
            genre_label.Name = "genre_label";
            genre_label.Size = new Size(77, 22);
            genre_label.TabIndex = 19;
            genre_label.Text = "Жанры:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(genre_label);
            panel1.Controls.Add(director_label);
            panel1.Controls.Add(mainrole_label);
            panel1.Location = new Point(1108, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 295);
            panel1.TabIndex = 21;
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
            flowLayoutPanel1.Location = new Point(434, 127);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(668, 297);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // Film_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1491, 835);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(film_name);
            Controls.Add(pictureBox2);
            Controls.Add(PanelL);
            Controls.Add(PanelR);
            Controls.Add(PanelT);
            Name = "Film_Page";
            Text = "Film_Page";
            Load += Film_Page_Load;
            PanelT.ResumeLayout(false);
            PanelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label director_label;
        private Label mainrole_label;
        private Label genre_label;
        private Panel PanelBack;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label description_label;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}