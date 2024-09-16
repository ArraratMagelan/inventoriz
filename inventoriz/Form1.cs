using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.UseSystemPasswordChar = true;
        }

        public static string sql = "";
        public static string login = "";
        glav_menu glav_Menu= new glav_menu();
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "admin_sistem" && textBox2.Text== "AdminAdmIN123")
            {
                sql = "Server=localhost;Port=5432;Database=peremesh;User Id=admin_sistem; Password=AdminAdmIN123;";
                MessageBox.Show("Вы зашли под администратором");
                login = "admin_sistem";
                glav_Menu.ShowDialog();
            }
            else
            {
                if (textBox1.Text == "MOL_yniversitet" && textBox2.Text == "MOL123mol")
                {
                    sql = "Server=localhost;Port=5432;Database=peremesh; User Id=mol_yniversitet; Password=MOL123mol;";
                    MessageBox.Show("Вы зашли под МОЛ университета");
                    login = "MOL_yniversitet";
                    glav_Menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не верные данные, попробуйте ещё раз.");
                }
            }
        }
    }
}
