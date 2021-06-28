using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Composicion
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Composicion() { }
        public Composicion(string nombre)
        {
            this.Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
