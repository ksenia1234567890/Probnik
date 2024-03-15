using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Probnik1
{
    public partial class Edit : Form
    {
        UCproduct product;
        string path = "Host=localhost;Username=postgres;Password=cxNTVJas;Database=Lopushok";
        public Edit(UCproduct product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    string query = "select * from products where name=@name";
                    NpgsqlCommand command = new NpgsqlCommand(query, connect);
                    command.Parameters.AddWithValue("@name", product.Name);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    connect.Open();
                    command.ExecuteNonQuery();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            textBox1.Text = reader.GetValue(1).ToString();
                            textBox2.Text = reader.GetValue(0).ToString();
                            textBox3.Text = reader.GetValue(5).ToString();
                            comboBox1.Text = reader.GetValue(4).ToString();
                            textBox4.Text = reader.GetValue(6).ToString();
                            textBox5.Text = reader.GetValue(2).ToString();
                            textBox7.Text = reader.GetValue(3).ToString();
                        }
                    }
                    connect.Close();
                }
                using (NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    string query = "select name from product_material where product=@name";
                    NpgsqlCommand command = new NpgsqlCommand(query, connect);
                    command.Parameters.AddWithValue("@name", product.Name);
                    NpgsqlDataReader reader = command.ExecuteReader();
                    connect.Open();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            textBox6.Text = reader.GetValue(0).ToString();
                        }
                    }
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    string query = "update products set name=@name,articul=@articul,minprice=@minprice,picture=@picture,type=@type,count=@count,number=@number where name=@name";
                    NpgsqlCommand command = new NpgsqlCommand(query, connect);
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@articul", textBox1.Text);
                    command.Parameters.AddWithValue("@minprcie", textBox5.Text);
                    command.Parameters.AddWithValue("@picture", textBox7.Text);
                    command.Parameters.AddWithValue("@type", comboBox1.Text);
                    command.Parameters.AddWithValue("@count", textBox3.Text);
                    command.Parameters.AddWithValue("@number", textBox4.Text);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }
                using (NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    string query = "update product_material set name=@name,countneed=@countneed where product=@product";
                    NpgsqlCommand command = new NpgsqlCommand(query, connect);
                    command.Parameters.AddWithValue("@product", product.Name);
                    command.Parameters.AddWithValue("@name", textBox6.Text);
                    command.Parameters.AddWithValue("@countneed", textBox3.Text);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    string query = "delete from products where name=@name";
                    NpgsqlCommand command = new NpgsqlCommand(query, connect);
                    command.Parameters.AddWithValue("@name", product.Name);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }
                using (NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    string query = "delete from product_material where product=@name";
                    NpgsqlCommand command = new NpgsqlCommand(query, connect);
                    command.Parameters.AddWithValue("@name", product.Name);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
