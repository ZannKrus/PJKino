﻿namespace prjkn
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
            Home_button = new Button();
            PanelBack = new Panel();
            pictureBox1 = new PictureBox();
            Search_Button = new Button();
            Menu_button = new Button();
            PanelR = new Panel();
            PanelL = new Panel();
            Greet_text = new Label();
            button1 = new Button();
            button2 = new Button();
            PanelT.SuspendLayout();
            PanelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelT
            // 
            PanelT.Controls.Add(Home_button);
            PanelT.Controls.Add(PanelBack);
            PanelT.Controls.Add(Search_Button);
            PanelT.Controls.Add(Menu_button);
            PanelT.Dock = DockStyle.Top;
            PanelT.Location = new Point(0, 0);
            PanelT.Margin = new Padding(3, 4, 3, 4);
            PanelT.Name = "PanelT";
            PanelT.Size = new Size(1134, 67);
            PanelT.TabIndex = 2;
            PanelT.Paint += panel2_Paint;
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
            Home_button.TabIndex = 7;
            Home_button.UseVisualStyleBackColor = false;
            Home_button.Click += Home_button_Click;
            // 
            // PanelBack
            // 
            PanelBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelBack.BackgroundImageLayout = ImageLayout.Stretch;
            PanelBack.Controls.Add(pictureBox1);
            PanelBack.Location = new Point(1038, 4);
            PanelBack.Margin = new Padding(3, 4, 3, 4);
            PanelBack.Name = "PanelBack";
            PanelBack.Size = new Size(82, 59);
            PanelBack.TabIndex = 2;
            PanelBack.Click += PanelBack_Click;
            PanelBack.Paint += panel2_Paint_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Location = new Point(16, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.MaximumSize = new Size(50, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 0);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PanelBack_Click;
            // 
            // Search_Button
            // 
            Search_Button.BackgroundImage = (Image)resources.GetObject("Search_Button.BackgroundImage");
            Search_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Button.Location = new Point(61, 15);
            Search_Button.Margin = new Padding(3, 4, 3, 4);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(40, 40);
            Search_Button.TabIndex = 1;
            Search_Button.UseVisualStyleBackColor = true;
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
            // PanelR
            // 
            PanelR.BackColor = Color.White;
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(995, 67);
            PanelR.Margin = new Padding(3, 4, 3, 4);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(139, 609);
            PanelR.TabIndex = 3;
            PanelR.Paint += panel3_Paint;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 67);
            PanelL.Margin = new Padding(3, 4, 3, 4);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(139, 609);
            PanelL.TabIndex = 4;
            PanelL.Paint += panel4_Paint;
            // 
            // Greet_text
            // 
            Greet_text.Anchor = AnchorStyles.None;
            Greet_text.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Greet_text.ForeColor = Color.White;
            Greet_text.Location = new Point(269, 271);
            Greet_text.Name = "Greet_text";
            Greet_text.Size = new Size(594, 73);
            Greet_text.TabIndex = 5;
            Greet_text.Text = "Добро пожаловать,  WIP";
            Greet_text.TextAlign = ContentAlignment.MiddleCenter;
            Greet_text.Click += Greet_text_Click;
            // 
            // button1
            // 
            button1.Location = new Point(635, 528);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(769, 528);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Welcum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1134, 676);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Greet_text);
            Controls.Add(PanelL);
            Controls.Add(PanelR);
            Controls.Add(PanelT);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Welcum";
            Text = "Form1";
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
        private Button button1;
        private Button Home_button;
        private Button button2;
    }
}