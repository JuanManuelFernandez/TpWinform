using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbMarca.Items.Add("Nike");
            CmbMarca.Items.Add("Adidas");
            CmbMarca.Items.Add("Puma");
            CmbMarca.Items.Add("Android");
            CmbMarca.Items.Add("Apple");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CmbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonImage_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                // Do something with the file name
            }
            */
        }
    }
}
