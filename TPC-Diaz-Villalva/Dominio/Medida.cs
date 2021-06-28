using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Medida
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Largo { get; set; }
        public string Ancho { get; set; }
        public Medida() { }

        public Medida(string nombre)
        {
            this.Nombre = nombre;
        }

        public override string ToString()
        {
            if (Nombre==null)
            {
                string cm2 = Largo.ToString() + " x " + Ancho.ToString();
                Nombre = cm2;

            }
            return Nombre;
        }

    }
}
