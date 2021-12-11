using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {

        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public string Imagen { get; set; }
        public Composicion composicion { get; set; }
        public Medida medida { get; set; }
        public Estilo estilo { get; set; }
        public Color color { get; set; }
        public Categoria categoria { get; set; }
        public bool visible { get; set; }

    }
}
