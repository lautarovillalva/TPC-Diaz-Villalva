using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAO;

namespace Negocio
{
    public class Categoria_neg
    {
        public List<Categoria> ListarCategorias()
        {
            Categoria_dao aux = new Categoria_dao();
            return aux.GetCategorias();
        }
    }
}
