using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private bool change = true;
        public Form1()
        {
            InitializeComponent();
            galleryEllipse1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(change)
            {
                gallery1.Hide(); 
                galleryEllipse1.Show();
                change = false;
            }
            else
            {
                gallery1.Show();
                galleryEllipse1.Hide();
                change = true;
            }
        }
    }
}
