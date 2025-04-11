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
    public partial class FrmAgregar : Form
    {
        private FrmVentanaPrincipal mainForm;

        public FrmAgregar(FrmVentanaPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Articulo entry = new Articulo(int.Parse(TxtCodAgr.Text), TxtNameAgr.Text, TxtDescripAgr.Text, TxtMarcaAgr.Text, TxtCategAgr.Text, int.Parse(TxtPrecioAgr.Text), PcbImagenAgr.Image);
            mainForm.AgregarListMain(entry);
        }

        public class Articulo
        {
            public int IDCodigo { get; set; } ///Cambiar a string
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string Marca { get; set; }
            public string Categoria { get; set; }
            public Image Imagen { get; set; }
            public int Precio { get; set; } ///Cambiar a string

            public Articulo(int cod, string nom, string desc, string marc, string cat, int pre, Image img) { 
                IDCodigo = cod;
                Nombre = nom;
                Descripcion = desc;
                Marca = marc;  
                Categoria = cat;
                Precio = pre;
                Imagen = img;
            }
        }

        private void ButtonImageAgr_Click(object sender, EventArgs e)
        {
            OpenFileDialog Seleccionar = new OpenFileDialog();
            Seleccionar.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;"; ///Arreglar esto para que tome cualquier imagen
            if (Seleccionar.ShowDialog() == DialogResult.OK)
            {
                string archivo = Seleccionar.FileName;
                PcbImagenAgr.Image = Image.FromFile(archivo);
                PcbImagenAgr.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
