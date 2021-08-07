using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Dominio;

namespace Negocio
{
    public class Estado_neg
    {
        public List<Estado> ListarEstados()
        {
            Estado_dao aux = new Estado_dao();
            return aux.GetEstados();
        }
    }
}
