using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Venta
    {
        int ID { get; set; }
        Usuario usuario { get; set; }
        List<Articulo> lista { get; set; }
        DateTime Fecha { get; set; }
        int Cantidad { get; set; }
        double Total { get; set; }
        Medio_de_pago pago { get; set; }
        Estado estado { get; set; }




    }
}
