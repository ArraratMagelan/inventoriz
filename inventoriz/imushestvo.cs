using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inventoriz
{
    public partial class imushestvo : Form
    {
        public imushestvo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;


            command.CommandText = String.Format("select korpus || '.' || auditory from raspolojenie");
            comboBox2.Items.Clear();
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(reader);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    comboBox2.Items.Add(data.Rows[i][0].ToString());
                }
            }
            reader.Close();

            command.CommandText = String.Format("select nazvanie from kategory");
            comboBox3.Items.Clear();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(reader);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    comboBox3.Items.Add(data.Rows[i][0].ToString());
                }
            }
            reader.Close();

            command.Dispose();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;

            string id = "";
            string[] mesto = comboBox2.SelectedItem.ToString().Split('.');

            command.CommandText = String.Format("select id_raspolojenie from raspolojenie where korpus={0} and  auditory={1};", mesto[0], mesto[1]);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(reader);
                id = data.Rows[0][0].ToString();
            }
            reader.Close();

            string id_ = "";
            command.CommandText = String.Format("select id_kategory from kategory where nazvanie='{0}';", comboBox3.SelectedItem.ToString());
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(reader);
                id_ = data.Rows[0][0].ToString();
            }
            reader.Close();



            command.CommandText = String.Format("insert into imushestvo values (default, '{0}', {1}, 0 ,'{2}',{3},'{4}',{5},{6});", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,comboBox1.SelectedItem.ToString(),id,id_);
            command.ExecuteNonQuery();
            command.Dispose();
            sqlConnection.Close();
            MessageBox.Show("Имущество добавлено");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox3.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
        }
    }
}
