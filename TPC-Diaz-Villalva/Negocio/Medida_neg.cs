using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAO;

namespace Negocio
{
    public class Medida_neg
    {
        public List<Medida> ListarMedidas()
        {
            Medida_dao aux = new Medida_dao();
            return aux.GetMedidas();
        }
    }
}
