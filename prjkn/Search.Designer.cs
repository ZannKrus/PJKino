﻿namespace prjkn
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            PanelT = new Panel();
            PanelBack = new Panel();
            Home_button = new Button();
            Search_button = new Button();
            Menu_button = new Button();
            listView1 = new ListView();
            listView2 = new ListView();
            panel1 = new Panel();
            page_f = new Button();
            page_b = new Button();
            page_text = new Label();
            search_textBox = new TextBox();
            button_search = new Button();
            PanelT.SuspendLayout();
            SuspendLayout();
            // 
            // PanelT
            // 
            PanelT.Controls.Add(PanelBack);
            PanelT.Controls.Add(Home_button);
            PanelT.Controls.Add(Search_button);
            PanelT.Controls.Add(Menu_button);
            PanelT.Dock = DockStyle.Top;
            PanelT.Location = new Point(0, 0);
            PanelT.Name = "PanelT";
            PanelT.Size = new Size(1448, 67);
            PanelT.TabIndex = 0;
            // 
            // PanelBack
            // 
            PanelBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelBack.Location = new Point(1362, 3);
            PanelBack.Name = "PanelBack";
            PanelBack.Size = new Size(82, 59);
            PanelBack.TabIndex = 3;
            PanelBack.Click += PanelBack_Click;
            // 
            // Home_button
            // 
            Home_button.BackgroundImage = (Image)resources.GetObject("Home_button.BackgroundImage");
            Home_button.BackgroundImageLayout = ImageLayout.Stretch;
            Home_button.FlatAppearance.BorderSize = 0;
            Home_button.FlatStyle = FlatStyle.Flat;
            Home_button.Location = new Point(107, 15);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(40, 40);
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
            Search_button.Location = new Point(61, 15);
            Search_button.Name = "Search_button";
            Search_button.Size = new Size(40, 40);
            Search_button.TabIndex = 1;
            Search_button.UseVisualStyleBackColor = true;
            // 
            // Menu_button
            // 
            Menu_button.BackgroundImage = (Image)resources.GetObject("Menu_button.BackgroundImage");
            Menu_button.BackgroundImageLayout = ImageLayout.Stretch;
            Menu_button.FlatAppearance.BorderSize = 0;
            Menu_button.FlatStyle = FlatStyle.Flat;
            Menu_button.Location = new Point(17, 15);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new Size(37, 40);
            Menu_button.TabIndex = 0;
            Menu_button.UseVisualStyleBackColor = true;
            Menu_button.Click += Menu_button_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = Color.Black;
            listView1.Location = new Point(163, 73);
            listView1.Margin = new Padding(139, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(1111, 849);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.Click += listView1_Click;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // listView2
            // 
            listView2.BackColor = Color.DimGray;
            listView2.Location = new Point(0, 67);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(139, 819);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.List;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1309, 67);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 896);
            panel1.TabIndex = 4;
            // 
            // page_f
            // 
            page_f.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            page_f.Location = new Point(1190, 893);
            page_f.Margin = new Padding(3, 4, 3, 4);
            page_f.Name = "page_f";
            page_f.Size = new Size(86, 31);
            page_f.TabIndex = 5;
            page_f.Text = "Вперед";
            page_f.UseVisualStyleBackColor = true;
            page_f.Click += page_f_Click;
            // 
            // page_b
            // 
            page_b.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            page_b.Location = new Point(163, 893);
            page_b.Margin = new Padding(3, 4, 3, 4);
            page_b.Name = "page_b";
            page_b.Size = new Size(86, 31);
            page_b.TabIndex = 6;
            page_b.Text = "Назад";
            page_b.UseVisualStyleBackColor = true;
            page_b.Click += page_b_Click;
            // 
            // page_text
            // 
            page_text.AutoSize = true;
            page_text.BackColor = Color.Transparent;
            page_text.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            page_text.ForeColor = Color.White;
            page_text.Location = new Point(658, 875);
            page_text.Name = "page_text";
            page_text.Size = new Size(109, 46);
            page_text.TabIndex = 7;
            page_text.Text = "label1";
            // 
            // search_textBox
            // 
            search_textBox.Location = new Point(0, 895);
            search_textBox.Margin = new Padding(3, 4, 3, 4);
            search_textBox.Name = "search_textBox";
            search_textBox.Size = new Size(139, 27);
            search_textBox.TabIndex = 8;
            search_textBox.TextChanged += search_textBox_TextChanged;
            // 
            // button_search
            // 
            button_search.Location = new Point(0, 932);
            button_search.Margin = new Padding(3, 4, 3, 4);
            button_search.Name = "button_search";
            button_search.Size = new Size(139, 31);
            button_search.TabIndex = 9;
            button_search.Text = "Поиск";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1448, 963);
            Controls.Add(button_search);
            Controls.Add(search_textBox);
            Controls.Add(page_text);
            Controls.Add(page_b);
            Controls.Add(page_f);
            Controls.Add(panel1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(PanelT);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск";
            Load += Search_Load;
            PanelT.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelT;
        private Button Menu_button;
        private Button Home_button;
        private Button Search_button;
        private Panel PanelBack;
        private ListView listView1;
        private ListView listView2;
        private Panel panel1;
        private Button page_f;
        private Button page_b;
        private Label page_text;
        private TextBox search_textBox;
        private Button button_search;
    }
}