using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAO;

namespace Negocio
{
    public class Composicion_neg
    {
        public List<Composicion> ListarComposiciones()
        {
            Composicion_dao aux = new Composicion_dao();
            return aux.GetComposiciones();
        }
    }
}
