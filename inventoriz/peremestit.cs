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
    public partial class peremestit : Form
    {
        public peremestit()
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select korpus,auditory from raspolojenie;");
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();

                command.CommandText = String.Format("select * from immmm;");
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView2.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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

                string id_chel = "";
                string[] сhel = comboBox1.SelectedItem.ToString().Split(',');
                string id_mesto = "";
                string id_mesto_staroe = "";
                string[] mesto = textBox1.Text.Split('.');
                string id_im = "";
                string[] im = textBox2.Text.Split(',');



                command.CommandText = String.Format("select id_raspolojenie from raspolojenie where korpus={0} and  auditory={1};", mesto[0], mesto[1]);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    id_mesto = data.Rows[0][0].ToString();
                }
                reader.Close();




                command.CommandText = String.Format("select id_imushestvo from imushestvo where nazvanie='{0}' and serial_nomer={1};", im[0], im[1]);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    id_im = data.Rows[0][0].ToString();
                }
                reader.Close();


                command.CommandText = String.Format("select id_polzovatel from polzovatel where FIO='{0}' and doljnost='{1}';", сhel[0], сhel[1]);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    id_chel = data.Rows[0][0].ToString();
                }
                reader.Close();

                command.CommandText = String.Format("select id_raspolojenie from imushestvo where id_imushestvo={0};", id_im);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    id_mesto_staroe = data.Rows[0][0].ToString();
                }
                reader.Close();

                command.CommandText = String.Format("insert into history_peremesh values (default, {0}, '{1}' ,{2},{3},{4});", id_im, textBox3.Text, id_mesto, id_mesto_staroe, id_chel);
                command.ExecuteNonQuery();

                command.CommandText = String.Format("update imushestvo set id_raspolojenie={0} where id_imushestvo={1} ;", id_mesto, id_im);
                command.ExecuteNonQuery();


                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Имущество перемещено");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
