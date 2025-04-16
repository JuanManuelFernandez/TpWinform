using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;
using Categorias;

namespace Articulos
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public Categoria Categ { get; set; }
        public string Imagen { get; set; }
        public System.Decimal Precio { get; set; }

        public Articulo() { }
        public Articulo(int ID, string Nombre, string Descripcion, string Marca, Categoria Categ, string Imagenm, int Precio)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Marca = Marca;
            this.Categ = Categ;
            this.Imagen = Imagen;
            this.Precio = Precio;
        }
    }
}
