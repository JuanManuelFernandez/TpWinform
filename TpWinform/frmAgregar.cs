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
using System.IO;
using System.Configuration;

namespace TpWinform
{
    public partial class frmAgregar : Form
    {
        private CatalogoArticulo datos = null;
        private Articulo nuevo = null;
        private CatalogoMarca datMarca = null;
        private CatalogoCategoria datCateg = null;
        private OpenFileDialog archivo = null;
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
            datMarca = new CatalogoMarca();
            datCateg = new CatalogoCategoria();
            if ((datCateg.validarRepetido(cboCategoria.Text))||(datMarca.validarRepetido(cboMarca.Text))) {
                MessageBox.Show("Ingrese la marca y/o la categoria por favor");
                return;
            }

            nuevo.Codigo = txtCodigo.Text;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Marc = (Marca)cboMarca.SelectedItem;
            nuevo.Categ = (Categoria)cboCategoria.SelectedItem;
            nuevo.Imagen = txtImagen.Text;
            nuevo.Precio = Decimal.Parse(txtPrecio.Text);

            datos.agregarArticulo(nuevo);

            /// SI NO ENCUENTRA EL DIRECTORIO QUE LO CREE
            if (archivo != null && !(txtImagen.Text.ToLower().Contains("http")))
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

            Close();
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
            CargarDatosCBO();
        }

        private void btnAgrMarca_Click(object sender, EventArgs e)
        {
            datMarca = new CatalogoMarca();
            string valor = cboMarca.Text;
            if (datMarca.validarRepetido(valor)){ 
                datMarca.agregarMarca(valor);
                cboMarca.Text = valor;
            }else
                MessageBox.Show("Ya se encuentra en la base de datos");
        }

        private void CargarDatosCBO() {
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

        private void btnAgrCateg_Click(object sender, EventArgs e)
        {
            datCateg = new CatalogoCategoria();
            string valor = cboCategoria.Text;
            if (datCateg.validarRepetido(valor))
                datCateg.agregarCategoria(valor);
            else
                MessageBox.Show("Ya se encuentra en la base de datos");
            cboCategoria.Text = valor;
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*jpg;|png|*png;|jpeg|*jpeg";
            if (archivo.ShowDialog() == DialogResult.OK) { 
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
