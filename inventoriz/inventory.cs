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
    public partial class inventory : Form
    {
        public inventory()
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


            command.CommandText = String.Format("select FIO || ',' || doljnost from polzovatel");
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
                string[] use = comboBox1.SelectedItem.ToString().Split(',');

                command.CommandText = String.Format("select id_polzovatel from polzovatel where FIO='{0}' and  doljnost='{1}';", use[0], use[1]);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    id = data.Rows[0][0].ToString();
                }
                reader.Close();




                command.CommandText = String.Format("insert into invenoriz values (default, '{0}', {1});", textBox1.Text, id);
                command.ExecuteNonQuery();



                command.CommandText = String.Format("select id_invenoriz from invenoriz order by id_invenoriz desc limit 1;");
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    id = data.Rows[0][0].ToString();
                }
                reader.Close();

                command.CommandText = String.Format("SELECT generate_detali_invenoriz({0});", id);
                command.ExecuteNonQuery();

                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Инветоризация проведена");
                textBox1.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select * from inv WHERE  Номер_инвентаризации = (SELECT max(Номер_инвентаризации) FROM inv);");
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;


            command.CommandText = String.Format("select nazvanie || ',' || serial_nomer || ',' || inv_nomer from imushestvo");
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
            command.Dispose();
            sqlConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;

                string id = "";
                string[] im = comboBox2.SelectedItem.ToString().Split(',');

                command.CommandText = String.Format("select id_imushestvo from imushestvo where nazvanie='{0}' and  serial_nomer={1} and  inv_nomer={2};", im[0], im[1], im[2]);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    id = data.Rows[0][0].ToString();
                }
                reader.Close();




                command.CommandText = String.Format("update detali_invenoriz set comment_in='{0}' where id_imushestvo={1} and id_invenoriz={2};", textBox2.Text, id, textBox3.Text);
                command.ExecuteNonQuery();


                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Комментарий добавлен");
                textBox2.Clear();
                textBox3.Clear();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
