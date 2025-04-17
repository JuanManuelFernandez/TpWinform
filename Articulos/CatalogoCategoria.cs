using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;
using Categorias;

namespace Articulos
{
    public class CatalogoCategoria
    {
        private List<Categoria> categorias = null;
        public List<Categoria> Listar() { 
            categorias = new List<Categoria>();
            Catalogo datos = new Catalogo();
            try
            {
                datos.Conectar();
                datos.Consultar("Select Id, Descripcion from CATEGORIAS");
                datos.Leer();
                while (datos.Lector.Read()) { 
                    Categoria aux = new Categoria();
                    aux.Id = datos.validarNullInt(datos.Lector["Id"]);
                    aux.Descripcion = datos.validarNullString(datos.Lector["Descripcion"]);

                    categorias.Add(aux);
                }
            }
            catch (Exception er)
            {

                throw er;
            }
            datos.Cerrar();
            return categorias;
        }

    }
}
