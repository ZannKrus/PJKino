using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjkn
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
            pass_textBox.UseSystemPasswordChar = true;
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            PanelR.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelL.BackColor = Color.FromArgb(100, 0, 0, 0);
            PanelT.BackColor = Color.FromArgb(150, 100, 79, 47);
            Menu_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Search_button.BackColor = Color.FromArgb(0, 100, 79, 47);
            Home_button.BackColor = Color.FromArgb(0, 100, 79, 47);
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            list list = new list();
            list.ShowDialog();
            this.Close();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.ShowDialog();
            this.Close();
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcum wlc = new Welcum();
            wlc.ShowDialog();
            this.Close();
        }

        private void pass_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_checkBox.Checked)
            {
                pass_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                pass_textBox.UseSystemPasswordChar = true;
            }
        }

        private void exit_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Log_in_and_Registration lnr = new Log_in_and_Registration();
            lnr.ShowDialog();
            this.Close();
        }
    }
}
