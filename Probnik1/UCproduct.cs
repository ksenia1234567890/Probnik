using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probnik1
{
    public partial class UCproduct : UserControl
    {
        public UCproduct()
        {
            InitializeComponent();
        }
        private string picture = "";


        public string Name
        {
            get
            {
                return name.Text;
            }
            set
            {
                name.Text = value;
            }
        }

        public string Articul
        {
            get
            {
                return articul.Text;
            }
            set
            {
                articul.Text = value;
            }
        }

        public string Minprice
        {
            get
            {
                return price.Text;
            }
            set
            {
                price.Text = value;
            }
        }

        public string Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
            }
        }
        public Image Photo
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }

        public string Type
        {
            get
            {
                return type.Text;
            }
            set
            {
                type.Text = value;
            }
        }

        public string Material
        {
            get
            {
                return material1.Text;
            }
            set
            {
                material1.Text = value;
            }
        }

        private void UCproduct_Click(object sender, EventArgs e)
        {
            Edit edit_form = new Edit(this);
            edit_form.ShowDialog();
        }
    }
}
