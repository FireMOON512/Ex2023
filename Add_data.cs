﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ex2023
{
    public partial class Add_data : Form
    {
        string connectionString = @"Data Source=DESKTOP-U870J16\SQLEXPRESS;Initial Catalog = Trade2023; Integrated Security = True";
        public bool AddRegime;
        public Add_data(bool Regime)

        {
            InitializeComponent();
            AddRegime = Regime;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            if (AddRegime)
            {
                command.CommandText = "AddProduct";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@name1", textBox1.Text);
                command.Parameters.AddWithValue("@decription1", textBox2.Text);
                command.Parameters.AddWithValue("@category", textBox3.Text);
                command.Parameters.AddWithValue("@manufacter", textBox4.Text);
                command.Parameters.AddWithValue("@price", Convert.ToInt32(textBox5.Text));
                command.Parameters.AddWithValue("@discount_amount", Convert.ToInt32(textBox6.Text));
                command.Parameters.AddWithValue("@quantity_at_sklad", Convert.ToInt32(textBox7.Text));
                command.Parameters.AddWithValue("@status", textBox8.Text);
                command.Parameters.AddWithValue("@article", textBox9.Text);
                command.Parameters.AddWithValue("@unit", textBox10.Text);
                command.Parameters.AddWithValue("@provider", textBox11.Text);
                command.Parameters.AddWithValue("@current", Convert.ToInt32(textBox12.Text));
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Успешно!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }

            Data_viewer fm = new Data_viewer();
            fm.Show();
            this.Hide();
        }
    }
}
