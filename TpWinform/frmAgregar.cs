using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDeDatos;
using Articulos;
using Categorias;

namespace TpWinform
{
    public partial class frmAgregar : Form
    {
        private CatalogoArticulo datos = null;

        private Articulo nuevo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo art)
        {
            InitializeComponent();
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            datos = new CatalogoArticulo();
            nuevo = new Articulo();

            nuevo.Codigo = txtCodigo.Text;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Marc = (Marca)cboMarca.SelectedItem;
            nuevo.Categ = (Categoria)cboCategoria.SelectedItem;
            nuevo.Imagen = txtImagen.Text;
            nuevo.Precio = Decimal.Parse(txtPrecio.Text);

            datos.agregarArticulo(nuevo);
        }

        private void cargarImagen(string URL) {
            try
            {
                pboImgAgr.Load(URL);
            }
            catch (Exception)
            {

                pboImgAgr.Load("https://img.freepik.com/vector-premium/imagen-no-es-conjunto-iconos-disponibles-simbolo-vectorial-stock-fotos-faltante-defecto-estilo-relleno-delineado-negro-signo-no-encontro-imagen_268104-6708.jpg");
            }
            
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            CatalogoCategoria categ = new CatalogoCategoria();
            CatalogoMarca marc = new CatalogoMarca();
            try
            {
                cboCategoria.DataSource = categ.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marc.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
