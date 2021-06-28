using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Medio_de_pago
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Medio_de_pago() { }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
