﻿namespace prjkn
{
    partial class list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list));
            PanelT = new Panel();
            PanelBack = new Panel();
            pictureBox1 = new PictureBox();
            Home_button = new Button();
            Search_Button = new Button();
            Menu_button = new Button();
            PanelL = new Panel();
            PanelR = new Panel();
            list_label = new Label();
            listView1 = new ListView();
            PanelT.SuspendLayout();
            PanelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            PanelT.Size = new Size(1170, 50);
            PanelT.TabIndex = 1;
            // 
            // PanelBack
            // 
            PanelBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelBack.BackgroundImageLayout = ImageLayout.Stretch;
            PanelBack.Controls.Add(pictureBox1);
            PanelBack.Location = new Point(1086, 3);
            PanelBack.Name = "PanelBack";
            PanelBack.Size = new Size(72, 44);
            PanelBack.TabIndex = 5;
            PanelBack.Click += PanelBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PanelBack_Click;
            // 
            // Home_button
            // 
            Home_button.BackColor = Color.Transparent;
            Home_button.BackgroundImage = (Image)resources.GetObject("Home_button.BackgroundImage");
            Home_button.BackgroundImageLayout = ImageLayout.Stretch;
            Home_button.Location = new Point(91, 12);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(35, 30);
            Home_button.TabIndex = 5;
            Home_button.UseVisualStyleBackColor = false;
            Home_button.Click += Home_button_Click;
            // 
            // Search_Button
            // 
            Search_Button.BackgroundImage = (Image)resources.GetObject("Search_Button.BackgroundImage");
            Search_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Search_Button.Location = new Point(50, 12);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(35, 30);
            Search_Button.TabIndex = 11;
            Search_Button.UseVisualStyleBackColor = true;
            Search_Button.Click += Search_Button_Click;
            // 
            // Menu_button
            // 
            Menu_button.BackColor = Color.Transparent;
            Menu_button.BackgroundImage = (Image)resources.GetObject("Menu_button.BackgroundImage");
            Menu_button.BackgroundImageLayout = ImageLayout.Stretch;
            Menu_button.Location = new Point(12, 12);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new Size(32, 30);
            Menu_button.TabIndex = 10;
            Menu_button.UseVisualStyleBackColor = false;
            Menu_button.Click += Menu_button_Click;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 50);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(122, 725);
            PanelL.TabIndex = 2;
            // 
            // PanelR
            // 
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(1048, 50);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(122, 725);
            PanelR.TabIndex = 3;
            // 
            // list_label
            // 
            list_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            list_label.Font = new Font("Segoe UI", 96F, FontStyle.Regular, GraphicsUnit.Point);
            list_label.ForeColor = Color.White;
            list_label.ImageAlign = ContentAlignment.TopCenter;
            list_label.Location = new Point(128, 53);
            list_label.Name = "list_label";
            list_label.Size = new Size(914, 141);
            list_label.TabIndex = 4;
            list_label.Text = "Мой список";
            list_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Black;
            listView1.ForeColor = Color.White;
            listView1.GridLines = true;
            listView1.Location = new Point(128, 197);
            listView1.Name = "listView1";
            listView1.Size = new Size(914, 566);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // list
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.circles;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1170, 775);
            Controls.Add(listView1);
            Controls.Add(list_label);
            Controls.Add(PanelR);
            Controls.Add(PanelL);
            Controls.Add(PanelT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "list";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мой список";
            Load += list_Load;
            PanelT.ResumeLayout(false);
            PanelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelT;
        private Button Search_Button;
        private Button Menu_button;
        private Panel PanelL;
        private Panel PanelR;
        private Label list_label;
        private Button Home_button;
        private Panel PanelBack;
        private PictureBox pictureBox1;
        private ListView listView1;
    }
}