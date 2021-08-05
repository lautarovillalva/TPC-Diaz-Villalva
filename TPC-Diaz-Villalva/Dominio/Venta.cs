using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Venta
    {
        public int ID { get; set; } //
        public Usuario usuario { get; set; } //
        public List<Articulo> lista { get; set; }
        public DateTime Fecha { get; set; }//
        public int Cantidad { get; set; } //
        public double Total { get; set; } //
        public Medio_de_pago pago { get; set; } //
        public Estado estado { get; set; } //




    }
}
