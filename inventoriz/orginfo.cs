using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace inventoriz
{
    public partial class orginfo : Form
    {
        public orginfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("insert into raspolojenie values (default, {0}, {1});", textBox1.Text, textBox2.Text);
                command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Расположение добавлено");
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("insert into kategory values (default, '{0}');", textBox3.Text);
                command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Категория добавлена");
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("insert into roli values (default, '{0}', '{1}');", textBox4.Text,textBox5.Text);
                command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Роль добавлена");
                textBox4.Clear();
                textBox5.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
