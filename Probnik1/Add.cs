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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        string path = "Host=localhost;Username=postgres;Password=cxNTVJas;Database=Lopushok";
        string pathImage;

        private void addButton_Click(object sender, EventArgs e)
        {
            try { 
            using (NpgsqlConnection connect = new NpgsqlConnection(path))
            {
                    string query = "Insert into products(name,articul,minprice,picture,type,count,number) values(@name,@articul,@minprice,@picture,@type,@count,@number)";
                NpgsqlCommand command = new NpgsqlCommand(query, connect);
                command.Parameters.AddWithValue("@name", textBox2.Text);
                command.Parameters.AddWithValue("@articul", textBox1.Text);
                command.Parameters.AddWithValue("@minprice", textBox5.Text);
                command.Parameters.AddWithValue("@type", comboBox1.Text);
                command.Parameters.AddWithValue("@count", textBox3.Text);
                command.Parameters.AddWithValue("@number", textBox4.Text);
                command.Parameters.AddWithValue("@picture", pathImage);
                    connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
            using(NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    string query = "insert into product_material(product,name,countneed) values(@product,@name,@countneed)";
                    NpgsqlCommand command = new NpgsqlCommand(query, connect);
                    command.Parameters.AddWithValue("@product", textBox1.Text);
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

        private void Add_Load(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    string query = "select type from products";
                    NpgsqlCommand command = new NpgsqlCommand(query, connect);
                    connect.Open();
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if(comboBox1.Items.Contains(reader.GetValue(0).ToString())==false)
                            {
                                comboBox1.Items.Add(reader.GetValue(0).ToString());
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Выбор изображения

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();
                pathImage = openFile.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
