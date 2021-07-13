using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Dominio;

namespace Negocio
{
    public class Color_neg
    {
        public List<Color> ListarColores()
        {
            Color_dao aux = new Color_dao();
            return aux.GetColores();
        }
    }
}
