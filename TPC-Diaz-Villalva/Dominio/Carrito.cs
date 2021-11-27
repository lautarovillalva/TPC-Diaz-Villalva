using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public List<Articulo> articulos;

        public Carrito()
        {
            articulos = new List<Articulo>();
        }
        public int cantidadArticulos()
        {
            int cantidad = 0;

            for (int i = 0; i < articulos.Count; i++)
            {
                cantidad += articulos[i].Cantidad;
            }

            return cantidad;
        }
        public double montoTotal()
        {
            double total = 0;
            for (int i = 0; i < articulos.Count; i++)
            {
                total += articulos[i].Precio * articulos[i].Cantidad;

            }
            return total;
        }
    }
}
