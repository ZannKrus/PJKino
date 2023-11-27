namespace prjkn
{
    partial class Log_in_and_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in_and_Registration));
            PanelT = new Panel();
            Home_button = new Button();
            Search_button = new Button();
            Menu_button = new Button();
            PanelL = new Panel();
            PanelR = new Panel();
            Reg_button = new Button();
            Log_in_button = new Button();
            PanelT.SuspendLayout();
            SuspendLayout();
            // 
            // PanelT
            // 
            PanelT.Controls.Add(Home_button);
            PanelT.Controls.Add(Search_button);
            PanelT.Controls.Add(Menu_button);
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
            Menu_button.Size = new Size(39, 40);
            Menu_button.TabIndex = 0;
            Menu_button.UseVisualStyleBackColor = true;
            Menu_button.Click += Menu_button_Click;
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
            // Reg_button
            // 
            Reg_button.BackColor = Color.White;
            Reg_button.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Reg_button.Location = new Point(434, 378);
            Reg_button.Name = "Reg_button";
            Reg_button.Size = new Size(263, 63);
            Reg_button.TabIndex = 14;
            Reg_button.Text = "Регистрация";
            Reg_button.UseVisualStyleBackColor = false;
            Reg_button.Click += Reg_button_Click;
            // 
            // Log_in_button
            // 
            Log_in_button.BackColor = Color.White;
            Log_in_button.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Log_in_button.Location = new Point(434, 266);
            Log_in_button.Name = "Log_in_button";
            Log_in_button.Size = new Size(263, 63);
            Log_in_button.TabIndex = 15;
            Log_in_button.Text = "Войти";
            Log_in_button.UseVisualStyleBackColor = false;
            Log_in_button.Click += Log_in_button_Click;
            // 
            // Log_in_and_Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1134, 676);
            Controls.Add(Log_in_button);
            Controls.Add(Reg_button);
            Controls.Add(PanelR);
            Controls.Add(PanelL);
            Controls.Add(PanelT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Log_in_and_Registration";
            Text = "Log_in_and_Registration";
            Load += Log_in_and_Registration_Load;
            PanelT.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelT;
        private Panel PanelL;
        private Button Menu_button;
        private Panel PanelR;
        private Button Home_button;
        private Button Search_button;
        private Button Reg_button;
        private Button Log_in_button;
    }
}