namespace prjkn
{
    partial class Welcum
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcum));
            PanelT = new Panel();
            admin_b = new Button();
            Home_button = new Button();
            PanelBack = new Panel();
            pictureBox1 = new PictureBox();
            Search_Button = new Button();
            Menu_button = new Button();
            PanelR = new Panel();
            PanelL = new Panel();
            Greet_text = new Label();
            button2 = new Button();
            PanelT.SuspendLayout();
            PanelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelT
            // 
            PanelT.Controls.Add(admin_b);
            PanelT.Controls.Add(Home_button);
            PanelT.Controls.Add(PanelBack);
            PanelT.Controls.Add(Search_Button);
            PanelT.Controls.Add(Menu_button);
            PanelT.Dock = DockStyle.Top;
            PanelT.Location = new Point(0, 0);
            PanelT.Name = "PanelT";
            PanelT.Size = new Size(1267, 50);
            PanelT.TabIndex = 2;
            PanelT.Paint += panel2_Paint;
            // 
            // admin_b
            // 
            admin_b.Anchor = AnchorStyles.Right;
            admin_b.BackColor = Color.Transparent;
            admin_b.BackgroundImage = Properties.Resources.wrench;
            admin_b.BackgroundImageLayout = ImageLayout.Stretch;
            admin_b.Location = new Point(1142, 11);
            admin_b.Name = "admin_b";
            admin_b.Size = new Size(35, 30);
            admin_b.TabIndex = 9;
            admin_b.UseVisualStyleBackColor = false;
            admin_b.Click += admin_b_Click;
            // 
            // Home_button
            // 
            Home_button.BackColor = Color.Transparent;
            Home_button.BackgroundImage = (Image)resources.GetObject("Home_button.BackgroundImage");
            Home_button.BackgroundImageLayout = ImageLayout.Stretch;
            Home_button.Location = new Point(94, 11);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(35, 30);
            Home_button.TabIndex = 7;
            Home_button.UseVisualStyleBackColor = false;
            Home_button.Click += Home_button_Click;
            // 
            // PanelBack
            // 
            PanelBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelBack.BackgroundImageLayout = ImageLayout.Stretch;
            PanelBack.Controls.Add(pictureBox1);
            PanelBack.Location = new Point(1183, 3);
            PanelBack.Name = "PanelBack";
            PanelBack.Size = new Size(72, 44);
            PanelBack.TabIndex = 2;
            PanelBack.Click += PanelBack_Click;
            PanelBack.Paint += panel2_Paint_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Location = new Point(14, 0);
            pictureBox1.MaximumSize = new Size(44, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PanelBack_Click;
            // 
            // Search_Button
            // 
            Search_Button.BackgroundImage = (Image)resources.GetObject("Search_Button.BackgroundImage");
            Search_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Button.Location = new Point(53, 11);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(35, 30);
            Search_Button.TabIndex = 1;
            Search_Button.UseVisualStyleBackColor = true;
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
            // PanelR
            // 
            PanelR.BackColor = Color.White;
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(1145, 50);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(122, 672);
            PanelR.TabIndex = 3;
            PanelR.Paint += panel3_Paint;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 50);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(122, 672);
            PanelL.TabIndex = 4;
            PanelL.Paint += panel4_Paint;
            // 
            // Greet_text
            // 
            Greet_text.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Greet_text.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Greet_text.ForeColor = Color.White;
            Greet_text.Location = new Point(128, 311);
            Greet_text.Name = "Greet_text";
            Greet_text.Size = new Size(1011, 55);
            Greet_text.TabIndex = 5;
            Greet_text.Text = "Добро пожаловать, гость";
            Greet_text.TextAlign = ContentAlignment.MiddleCenter;
            Greet_text.Click += Greet_text_Click;
            // 
            // button2
            // 
            button2.Location = new Point(871, 644);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Welcum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1267, 722);
            Controls.Add(button2);
            Controls.Add(Greet_text);
            Controls.Add(PanelL);
            Controls.Add(PanelR);
            Controls.Add(PanelT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Welcum";
            Text = "КиноНепоиск";
            Load += Welcum_Load;
            PanelT.ResumeLayout(false);
            PanelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelT;
        private Panel PanelR;
        private Panel PanelL;
        private Button Menu_button;
        private Button Search_Button;
        private Panel PanelBack;
        private PictureBox pictureBox1;
        private Label Greet_text;
        private Button Home_button;
        private Button button2;
        private Button admin_b;
    }
}