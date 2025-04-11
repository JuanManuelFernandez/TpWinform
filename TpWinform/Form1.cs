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
    public partial class FrmVentanaPrincipal : Form
    {

        public FrmVentanaPrincipal()
        {
            InitializeComponent();
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

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar ventana = new FrmAgregar(this);
            ventana.ShowDialog();
        }

        public void AgregarListMain(FrmAgregar.Articulo articulo) {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(articulo.IDCodigo.ToString());
            item.SubItems.Add(articulo.Nombre);
            item.SubItems.Add(articulo.Descripcion);
            item.SubItems.Add(articulo.Marca);
            item.SubItems.Add(articulo.Categoria);
            item.SubItems.Add(articulo.Precio.ToString());

            ListMain.Items.Add(item);
        }

    }
}
