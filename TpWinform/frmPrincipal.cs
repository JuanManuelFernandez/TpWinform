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

namespace TpWinform
{
    public partial class frmPrincipal : Form
    {

        private List<Articulo> articulos;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void cargarDatos()
        {
            CatalogoArticulo ejemplo = new CatalogoArticulo();
            try
            {
                articulos = ejemplo.listar();
                dgvDatos.DataSource = articulos;
                cargarImagen(articulos[0].Imagen);
                ocultarColumnas();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        public void cargarImagen(string imagen) {
            try
            {
                pbxImg.Load(imagen);
            }
            catch (Exception)
            {

                pbxImg.Load("https://img.freepik.com/vector-premium/imagen-no-es-conjunto-iconos-disponibles-simbolo-vectorial-stock-fotos-faltante-defecto-estilo-relleno-delineado-negro-signo-no-encontro-imagen_268104-6708.jpg");
            }
        }
        public void ocultarColumnas() {
            dgvDatos.Columns["ID"].Visible = false;
            dgvDatos.Columns["Imagen"].Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frm = new frmAgregar();
            frm.ShowDialog();
            cargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccion = new Articulo();
            seleccion = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
            frmAgregar frm = new frmAgregar(seleccion);
            frm.Text = "Modificar";
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarDatos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null) {
                Articulo aux = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                cargarImagen(aux.Imagen);
            }
            if (dgvDatos.CurrentRow != null)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
    }
}
