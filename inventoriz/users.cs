using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventoriz
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
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

                string id = "";
                string []rol=comboBox1.SelectedItem.ToString().Split(',');

                command.CommandText = String.Format("select id_roli from roli where doljnost='{0}' and  prava_dostupa='{1}';", rol[0], rol[1]);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    id = data.Rows[0][0].ToString();
                }
                reader.Close();


                command.CommandText = String.Format("insert into polzovatel values (default, '{0}', '{1}','{2}',{3});", textBox1.Text, textBox2.Text,textBox3.Text,id);
                command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Роль добавлена");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;


            command.CommandText = String.Format("select doljnost || ',' || prava_dostupa from roli");
            comboBox1.Items.Clear();
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(reader);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    comboBox1.Items.Add(data.Rows[i][0].ToString());
                }
            }
            reader.Close();
            command.Dispose();
            sqlConnection.Close();
        }
    }
}
