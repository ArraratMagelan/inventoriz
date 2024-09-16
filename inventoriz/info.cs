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
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
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
            command.Dispose();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("select nazvanie from kategory;");
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

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("select FIO,doljnost,email from polzovatel;");
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

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("select doljnost,prava_dostupa  from roli;");
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

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("select *  from inv;");
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

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("select *  from hist;");
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

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("select *  from immmm;");
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

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            NpgsqlConnection sqlConnection = new NpgsqlConnection(Form1.sql);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("select *  from spis;");
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
    }
}
