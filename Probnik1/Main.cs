using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections;
using System.IO;
using System.Globalization;
using Npgsql;

namespace Probnik1
{
    public partial class Main : Form
    {
        public int count = 0; // количeство строк
        List<UCproduct> products = new List<UCproduct>(); // список хранит значения без поиска, сортировки и фильтра
        List<UCproduct> list_product = new List<UCproduct>();
        List<string> types = new List<string>();
        string path = "Host=localhost;Username=postgres;Password=cxNTVJas;Database=Lopushok";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    string commandSql = "select * from products";
                    NpgsqlCommand command = new NpgsqlCommand(commandSql, connect);
                    connect.Open();
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UCproduct product = new UCproduct();
                            product.Name = (reader.GetValue(0).ToString());
                            product.Articul = (reader.GetValue(1).ToString());
                            product.Minprice = (reader.GetValue(2).ToString());
                            product.Picture = (reader.GetValue(3).ToString());
                            product.Type = (reader.GetValue(4).ToString());
                            list_product.Add(product);
                            products.Add(product);
                            count++;
                        }
                    }
                    connect.Close();
                    EnterProducts();
                    PageInstall(first.Text);
                }

                // Добавление типов в комбобокс

                using (NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    string commandSql = "select type from products";
                    NpgsqlCommand command = new NpgsqlCommand(commandSql, connect);
                    connect.Open();
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if(filter.Items.Contains(reader.GetValue(0).ToString())==false)
                            {
                                filter.Items.Add(reader.GetValue(0).ToString());
                                types.Add(reader.GetValue(0).ToString());
                            }
                        }
                    }
                    connect.Close();

                }

                // Добавление материалов

                using (NpgsqlConnection connect = new NpgsqlConnection(path))
                {
                    int i = 0;
                    string commandSql = "select name from product_material";
                    NpgsqlCommand command = new NpgsqlCommand(commandSql, connect);
                    connect.Open();
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list_product[i].Material = reader.GetValue(0).ToString();
                            i++;
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

        // Страницы
        public double Labels(double count)
        {
            double ostatok = count % 20;
            double n = count - ostatok; // количество строк без остатка
            if (ostatok==0)
            {
                return n / 20;
            }
            else
            {
                double pages = (n / 20) + 1; // количество страниц
                return pages;
            }
            
        }


        // Нажатие на левую стрелку
        private void left_Click(object sender, EventArgs e)
        {
            if (first.Text == "1")
            {
                MessageBox.Show("Дальше листать нельзя");
            }
            else
            {
                int firstPage = Convert.ToInt32(first.Text) - 1;
                first.Text = firstPage.ToString();
                int secondPage = Convert.ToInt32(second.Text) - 1;
                second.Text = secondPage.ToString();
                int thirdPage = Convert.ToInt32(third.Text) - 1;
                third.Text = thirdPage.ToString();
            }
        }


        // Нажатие на правую стрелку
        private void right_Click(object sender, EventArgs e)
        {
            string pages = Labels(Convert.ToDouble(count)).ToString();
            if (third.Text == pages)
            {
                MessageBox.Show("Больше страниц нет");
            }
            else
            {
                int firstPage = Convert.ToInt32(first.Text) + 1;
                first.Text = firstPage.ToString();
                int secondPage = Convert.ToInt32(second.Text) + 1;
                second.Text = secondPage.ToString();
                int thirdPage = Convert.ToInt32(third.Text) + 1;
                third.Text = thirdPage.ToString();
            }
        }

        // Нажатие на первую кнопку
        private void first_Click(object sender, EventArgs e)
        {
            panelProduct.Controls.Clear();
            filter.Text = filter.Items[0].ToString();
            PageInstall(first.Text);
        }

        // Перелистывание страниц

        public void PageInstall(string textNumber)
        {
            try
            {
                int indexUpper = 20 * Convert.ToInt32(textNumber);
                int indexLower = indexUpper - 20;
                for (int i= indexLower; i<indexUpper;i++)
                {
                    panelProduct.Controls.Add(list_product[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Нажатие второй кнопки
        private void second_Click(object sender, EventArgs e)
        {
            panelProduct.Controls.Clear();
            filter.Text = filter.Items[0].ToString();
            PageInstall(second.Text);
        }

        // Нажатие третьей кнопки
        private void third_Click(object sender, EventArgs e)
        {
            panelProduct.Controls.Clear();
            filter.Text = filter.Items[0].ToString();
            PageInstall(third.Text);
        }

        public void EnterProducts()
        {
            for (int i=0; i<20; i++)
            {
                panelProduct.Controls.Add(list_product[i]);
            }
        }

        // Применение фильтра

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelProduct.Controls.Clear();
            if (filter.SelectedItem.ToString() == "Все типы")
            {
                PageInstall(first.Text);
            }
            for (int i = 0; i < types.Count; i++)
            {
                if (filter.SelectedItem.ToString() == types[i])
                {
                    for (int j = 0; j < products.Count; j++)
                    {
                        if (products[j].Type == filter.SelectedItem.ToString())
                        {
                            panelProduct.Controls.Add(products[j]);
                        }
                    }
                }
            }
        }

        // Применение сортировки

        private void sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sort.Text== "Наименование - по возрастанию")
            {
                Sort("products.name", "ASC");
            }
            if (sort.Text == "Наименование - по убыванию")
            {
                Sort("products.name", "DESC");
            }
            if (sort.Text == "Номер производственного цеха - по возрастанию")
            {
                Sort("number", "ASC");
            }
            if (sort.Text == "Номер производственного цеха - по убыванию")
            {
                Sort("number", "DESC");
            }
            if (sort.Text == "Минимальная стоимость для агента - по возрастанию")
            {
                Sort("minprice", "ASC");
            }
            if (sort.Text == "Минимальная стоимость для агента - по убыванию")
            {
                Sort("minprice", "DESC");

            }
           
        }

        public void Sort(string variable, string kindOfSort)
        {
            List<UCproduct> sorted = new List<UCproduct>();
            panelProduct.Controls.Clear();
            using (NpgsqlConnection connect = new NpgsqlConnection(path))
            {
                string sql = $"select products.name,articul,minprice,picture,type,product_material.name from products,product_material order by {variable} {kindOfSort}";
                NpgsqlCommand command = new NpgsqlCommand(sql, connect);
                connect.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UCproduct product = new UCproduct();
                        product.Name = reader.GetValue(0).ToString();
                        product.Articul = reader.GetValue(1).ToString();
                        product.Minprice = reader.GetValue(2).ToString();
                        product.Picture = reader.GetValue(3).ToString();
                        product.Type = reader.GetValue(4).ToString();
                        product.Material = reader.GetValue(5).ToString();
                        sorted.Add(product);
                    }
                }
            }
            
            for(int i=0; i<sorted.Count;i++)
            {
                panelProduct.Controls.Add(sorted[i]);
            }


        }

        // Поиск

        public void Search(string searchText)
        {
            panelProduct.Controls.Clear();
            string[] words = searchText.Split(' ');
            List<UCproduct> search_product = new List<UCproduct>();
            for(int j=0; j<words.Length; j++)
            {
                for (int i = 0; i < list_product.Count; i++)
                {
                    if (list_product[i].Name.ToLower().Contains(words[j].ToLower())==true || list_product[i].Type.ToLower().Contains(words[j].ToLower()) == true || list_product[i].Material.ToLower().Contains(words[j].ToLower()) == true)
                    {
                        search_product.Add(list_product[i]);
                    }
                }
            }
            for(int i=0; i<search_product.Count;i++)
            {
                panelProduct.Controls.Add(search_product[i]);
            }

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            Add add_form = new Add();
            add_form.ShowDialog();
        }

        // Поиск

        private void Main_DoubleClick(object sender, EventArgs e)
        {
            Search(TBsearch.Text);
        }
    }
}
