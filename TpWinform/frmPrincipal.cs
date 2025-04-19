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
using System.IO;

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
                ocultarColumnas();
                //CARGAR IMAGEN "NO PHOTO" CUANDO NO HAY DATOS CARGADOS
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
            if (dgvDatos.CurrentRow != null)
            {
                Articulo seleccion = new Articulo();
                seleccion = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                frmAgregar frm = new frmAgregar(seleccion);
                frm.Text = "Modificar";
                frm.ShowDialog();
                cargarDatos();
            }
            else 
            {
                MessageBox.Show(("No hay ningun elemnto seleccionado."));
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                Articulo aux = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                cargarImagen(aux.Imagen);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow != null)
            {
                CatalogoArticulo Articulo = new CatalogoArticulo();
                Articulo seleccionado;
                try
                {
                    seleccionado = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                    Articulo.EliminarArticulo(seleccionado.ID);
                    cargarDatos();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show(("No hay ningun elemnto seleccionado."));
            }
            
            
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatos.CurrentRow != null) {
                frmDetalle nuevo = new frmDetalle((Articulo)dgvDatos.CurrentRow.DataBoundItem);
                nuevo.ShowDialog();
            }
        }
    }
}
