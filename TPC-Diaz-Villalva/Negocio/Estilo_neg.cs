using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAO;

namespace Negocio
{
    public class Estilo_neg
    {
        public List<Estilo> listarEstilos()
        {
            Estilo_dao est = new Estilo_dao();
            return est.GetEstilos();
        }
    }
}
