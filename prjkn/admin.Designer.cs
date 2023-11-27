namespace prjkn
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            PanelT = new Panel();
            Home_button = new Button();
            Search_button = new Button();
            Menu_button = new Button();
            PanelBack = new Panel();
            PanelL = new Panel();
            PanelR = new Panel();
            PanelT.SuspendLayout();
            SuspendLayout();
            // 
            // PanelT
            // 
            PanelT.Controls.Add(Home_button);
            PanelT.Controls.Add(Search_button);
            PanelT.Controls.Add(Menu_button);
            PanelT.Controls.Add(PanelBack);
            PanelT.Dock = DockStyle.Top;
            PanelT.Location = new Point(0, 0);
            PanelT.Name = "PanelT";
            PanelT.Size = new Size(1134, 67);
            PanelT.TabIndex = 0;
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
            Home_button.TabIndex = 3;
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
            Search_button.TabIndex = 2;
            Search_button.UseVisualStyleBackColor = true;
            Search_button.Click += Search_button_Click;
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
            Menu_button.TabIndex = 1;
            Menu_button.UseVisualStyleBackColor = true;
            Menu_button.Click += Menu_button_Click;
            // 
            // PanelBack
            // 
            PanelBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PanelBack.Location = new Point(1038, 4);
            PanelBack.Name = "PanelBack";
            PanelBack.Size = new Size(82, 59);
            PanelBack.TabIndex = 0;
            PanelBack.Click += PanelBack_Click;
            // 
            // PanelL
            // 
            PanelL.Dock = DockStyle.Left;
            PanelL.Location = new Point(0, 67);
            PanelL.Name = "PanelL";
            PanelL.Size = new Size(139, 609);
            PanelL.TabIndex = 1;
            // 
            // PanelR
            // 
            PanelR.Dock = DockStyle.Right;
            PanelR.Location = new Point(995, 67);
            PanelR.Name = "PanelR";
            PanelR.Size = new Size(139, 609);
            PanelR.TabIndex = 2;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1134, 676);
            Controls.Add(PanelR);
            Controls.Add(PanelL);
            Controls.Add(PanelT);
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            PanelT.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelT;
        private Panel PanelL;
        private Panel PanelR;
        private Panel PanelBack;
        private Button Menu_button;
        private Button Search_button;
        private Button Home_button;
    }
}