using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Estado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Estado() { }
        public Estado(string nombre)
        {
            this.Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
