using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Color
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }


        public Color() { }
        public Color(string Codigo)
        {
            this.Codigo = Codigo;
        }


        public override string ToString()
        {
            return Codigo;
        }
    }
}
