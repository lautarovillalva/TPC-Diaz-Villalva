using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Dominio;

namespace Negocio
{
    public class Articulo_neg
    {

        public List<Articulo> ListarArticulos()
        {
            Articulo_dao art = new Articulo_dao();
            return art.GetArticulos();
        }
        public bool eliminarArticulo(Articulo articulo)
        {

            Articulo_dao aux = new Articulo_dao();
            return aux.delArticulo(articulo);

        }
        public bool modificarArticulo(Articulo articulo)
        {

            Articulo_dao aux = new Articulo_dao();
            return aux.modArticulo(articulo);

        }
        public bool agregarArticulo(Articulo articulo)
        {

            Articulo_dao aux = new Articulo_dao();
            return aux.setArticulo(articulo);

        }

        public List<Articulo> ArticulosFiltrados(string valor)
        {
            Articulo_dao aux = new Articulo_dao();
            return aux.getArticulosFiltrados(valor);
        }

    }
}
