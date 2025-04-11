using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //MARCA
            CmbMarca.Items.Add("Nike");
            CmbMarca.Items.Add("Adidas");
            CmbMarca.Items.Add("Puma");
            CmbMarca.Items.Add("Android");
            CmbMarca.Items.Add("Apple");
            //CATEGIORIA
            CmbCateg.Items.Add("Zapatilla");
            CmbCateg.Items.Add("Celular");
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

        //FUNCIONES PARA AGREGAR REGISTROS
        private void AgregarElementoTxt(System.Windows.Forms.TextBox txt, System.Windows.Forms.ListView lista)
        {
            // Agrega el texto del TextBox al ListBox
            if (txt != null)
            {
                lista.Items.Add(txt.Text);

                // Limpia el TextBox después de agregar el elemento
                txt.Clear();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios"); 
            }
        }
        private void AgregarElementoSelc(System.Windows.Forms.ComboBox elemento, System.Windows.Forms.ListView lista)
        {
            if (elemento.SelectedItem != null)
            {
                lista.Items.Add(elemento.SelectedItem.ToString());

                elemento.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
        }
        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            AgregarElementoTxt(TxtCod, ListMain);
            AgregarElementoTxt(TxtName, ListMain);
            AgregarElementoTxt(TxtDescrip, ListMain);
            AgregarElementoSelc(CmbMarca, ListMain);
            AgregarElementoSelc(CmbCateg, ListMain);
            AgregarElementoTxt(TxtPrecio, ListMain);
        }

        private void ListMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
