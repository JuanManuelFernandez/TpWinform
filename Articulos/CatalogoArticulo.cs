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
                    aux.ID = (int)datos.Lector["ID"];
                    aux.Nombre = (string)validarNull(datos.Lector, "Nombre");
                    //aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = (string)datos.Lector["Marca"];

                    aux.Categ = new Categoria();
                    aux.Categ.Descripcion = (string)validarNull(datos.Lector,"Categoria") ?? string.Empty;
                    ///aux.Categ.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Precio = (System.Decimal)datos.Lector["Precio"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];

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

        public object validarNull(SqlDataReader Rdr, string columna) {
            if (!(Rdr[columna] is DBNull)) {
                return Rdr[columna];
            }
            return null;
        }

    }
}
