using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Dominio;

namespace Negocio
{
    public class Medio_de_pago_neg
    {
        public List<Medio_de_pago> medios_De_Pago()
        {
            Medio_de_pago_dao aux = new Medio_de_pago_dao();
            return aux.GetMedio_De_Pagos();
        }
        
    }
}
