using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BaseDeDatos;
using Categorias;

namespace Articulos
{
    public class CatalogoArticulo
    {
        private List<Articulo> articulos;
        private Catalogo datos = new Catalogo();

        public List<Articulo> listar(){
            articulos = new List<Articulo>();
            datos.Conectar();
            datos.Consultar("select A.ID, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.Precio, I.ImagenUrl from ARTICULOS A left join MARCAS M on A.IDMarca = M.ID left join CATEGORIAS C on A.IdCategoria = C.Id left join IMAGENES I on A.Id = I.IdArticulo\r\n");
            datos.Leer();

            try
            {
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marc = new Marca();
                    aux.Categ = new Categoria();

                    aux.ID = datos.validarNullInt(datos.Lector["ID"]);
                    aux.Codigo = datos.validarNullString(datos.Lector["Codigo"]);
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
        public void agregarArticulo(Articulo aux) { 
            CatalogoArticulo articulo = new CatalogoArticulo();
            try
            {
                datos.Conectar();
                datos.Consultar("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @IdPrecio)");
                datos.setearParametro("@Codigo", aux.Codigo);
                datos.setearParametro("@Nombre", aux.Nombre);
                datos.setearParametro("@Descripcion", aux.Descripcion);
                datos.setearParametro("@IdMarca", aux.Marc.Id);
                datos.setearParametro("@IDCategoria", aux.Categ.Id);
                datos.setearParametro("@IdPrecio", aux.Precio);
                datos.EjecutarNonQuery();
                datos.Cerrar();

                datos.Conectar();
                List<Articulo> art = articulo.listar();
                datos.Consultar("insert into Imagenes (IdArticulo, ImagenUrl) values (@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", art[art.Count - 1].ID);
                datos.setearParametro("@ImagenUrl", aux.Imagen);
                datos.EjecutarNonQuery();
            }
            catch (Exception er)
            {

                throw er;
            }
            finally {
                datos.Cerrar();
            }
        }
        public void EliminarArticulo(int id)
        {
            try
            {
                Catalogo datos = new Catalogo();
                datos.Conectar();
                datos.Consultar("DELETE FROM ARTICULOS WHERE ID = @IdArticulo");
                datos.setearParametro("IdArticulo", id);
                datos.EjecutarNonQuery();

                datos.Cerrar();

                datos.Conectar();
                datos.Consultar("DELETE FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                datos.setearParametro("IdArticulo", id);
                datos.EjecutarNonQuery();

                datos.Cerrar();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
