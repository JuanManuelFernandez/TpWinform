using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;
using Categorias;

namespace Articulos
{
    public class CatalogoArticulo
    {
        List<Articulo> articulos;
        Catalogo datos = new Catalogo();

        public List<Articulo> listar(){
            articulos = new List<Articulo>();
            datos.Conectar();
            datos.Consultar("select A.ID, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio, I.ImagenUrl from ARTICULOS A left join MARCAS M on A.IDMarca = M.ID left join CATEGORIAS C on A.IdCategoria = C.Id left join IMAGENES I on A.Id = I.IdArticulo\r\n");
            datos.Leer();

            try
            {
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marc = new Marca();
                    aux.Categ = new Categoria();

                    aux.ID = datos.validarNullInt(datos.Lector["ID"]);
                    aux.Nombre = datos.validarNullString(datos.Lector["Nombre"]);
                    aux.Descripcion = datos.validarNullString(datos.Lector["Descripcion"]);
                    aux.Marc.Descripcion = datos.validarNullString(datos.Lector["Marca"]);
                    aux.Categ.Descripcion = datos.validarNullString(datos.Lector["Categoria"]);
                    aux.Imagen = datos.validarNullString(datos.Lector["ImagenUrl"]);
                    aux.Precio = datos.validarNullDecimal(datos.Lector["Precio"]);

                    articulos.Add(aux);
                }
            }
            catch (Exception er)
            {

               throw er;
            }
            datos.Cerrar();
            return articulos;
        }
    }
}
