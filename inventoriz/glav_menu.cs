using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inventoriz
{
    public partial class glav_menu : Form
    {
        public glav_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orginfo orginfo = new orginfo();
            orginfo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            users users = new users();
            users.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imushestvo imushestvo = new imushestvo();
            imushestvo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            inventory.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            peremestit peremestit = new peremestit();
            peremestit.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            spisanie spisanie = new spisanie();
            spisanie.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }

        private void glav_menu_Load(object sender, EventArgs e)
        {
            if(Form1.login=="MOL_yniversitet")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
            }
            if(Form1.login== "admin_sistem")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
            }
        }
    }
}
