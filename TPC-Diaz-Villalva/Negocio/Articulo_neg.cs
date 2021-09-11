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
        public string DescripcionArticulo(int id)
        {
            Articulo_dao aux = new Articulo_dao();
            return aux.DescArticulo(id);
        }
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

        public bool bajaArticulo(string id, bool baja)
        {
            Articulo_dao aux = new Articulo_dao();
            return aux.bajaLogicaArticulo(id, baja);
        }


        public bool agregarArticulo(Articulo articulo)
        {

            Articulo_dao aux = new Articulo_dao();
            return aux.setArticulo(articulo);

        }

        public List<Articulo> ArticulosFiltrados(string valor, bool tipo)
        {
            Articulo_dao aux = new Articulo_dao();
            return aux.getArticulosFiltrados(valor, tipo);
        }


        public List<Articulo> armarFiltro(string categoria, string estilos, string composicion, string medidas)
        {
            string consulta = "WHERE CATEGORIAS.NOMBRE = '" + categoria + "' AND  MEDIDAS.NOMBRE = '" + medidas + "' AND  ESTILOS.NOMBRE = '" + estilos + "' AND  COMPOSICIONES.NOMBRE = '" + composicion +"'";
            return ArticulosFiltrados(consulta, false);
        }


    }
}
