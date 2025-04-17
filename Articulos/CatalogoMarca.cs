using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDeDatos;

namespace Articulos
{
    public class CatalogoMarca
    {
        private List<Marca> marcas = new List<Marca>();
        public List<Marca> Listar() {
            Catalogo datos = new Catalogo();
            Marca aux;
            try
            {
                datos.Conectar();
                datos.Consultar("Select ID, Descripcion from Marcas");
                datos.Leer();
                while(datos.Lector.Read()){ 
                    aux = new Marca();
                    aux.Id = datos.validarNullInt(datos.Lector["Id"]);
                    aux.Descripcion = datos.validarNullString(datos.Lector["Descripcion"]);
                    marcas.Add(aux);
                }
            }
            catch (Exception er)
            {

                throw er;
            }
            
            return marcas;
        }
    }
}
