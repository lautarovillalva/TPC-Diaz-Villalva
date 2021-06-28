using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Articulo
    {

        int ID { get; set; }
        string Nombre { get; set; }
        double Precio { get; set; }
        int Cantidad { get; set; }
        Composicion composicion { get; set; }
        Medida medida { get; set; }
        Estilo estilo { get; set; }
        Color color { get; set; }
        Categoria categoria { get; set; }

    }
}
