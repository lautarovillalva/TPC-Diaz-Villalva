using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;

namespace DAO
{
    public class Articulo_dao
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public List<Articulo> GetArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            string consulta = "SELECT ARTICULOS.ID,  ARTICULOS.NOMBRE, ARTICULOS.PRECIO,  ARTICULOS.IMAGEN,  ARTICULOS.STOCK,  CATEGORIAS.NOMBRE AS CATEGORIA,  COMPOSICIONES.NOMBRE AS COMPOSICION,  ISNULL(MEDIDAS.NOMBRE, MEDIDAS.ANCHO_CM+'x'+MEDIDAS.LARGO_CM) AS MEDIDA,  ESTILOS.NOMBRE AS ESTILO,  COLORES.NOMBRE AS COLOR FROM ARTICULOS INNER JOIN MEDIDAS ON MEDIDAS.ID=ARTICULOS.ID_MEDIDA INNER JOIN CATEGORIAS ON CATEGORIAS.ID=ARTICULOS.ID_CATEGORIA INNER JOIN COMPOSICIONES ON COMPOSICIONES.ID=ARTICULOS.ID_COMPOSICION INNER JOIN ESTILOS ON ESTILOS.ID=ARTICULOS.ID_ESTILO INNER JOIN COLORES ON COLORES.ID=ARTICULOS.ID_COLOR";
            DataTable tabla = accesoDatos.ObtenerTabla("Articulos", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Articulo articulo = new Articulo
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Nombre = tabla.Rows[i][1].ToString(),
                    Precio = Convert.ToDouble(tabla.Rows[i][2]),
                    Imagen = tabla.Rows[i][3].ToString(),
                    Cantidad = Convert.ToInt32(tabla.Rows[i][4]),
                    categoria = new Categoria(tabla.Rows[i][5].ToString()),
                    composicion = new Composicion(tabla.Rows[i][6].ToString()),
                    medida = new Medida(tabla.Rows[i][7].ToString()),
                    estilo = new Estilo(tabla.Rows[i][8].ToString()),
                    color = new Color(tabla.Rows[i][9].ToString()),
                };


                lista.Add(articulo);
            }

            return lista;
        }
    }
}
