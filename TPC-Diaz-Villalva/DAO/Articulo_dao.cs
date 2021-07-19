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
        public string DescArticulo(int id)
        {
            string descripcion="";
            string consulta = "SELECT DESCRIPCION_DE_ARTICULOS.DESCRIPCION FROM DESCRIPCION_DE_ARTICULOS WHERE DESCRIPCION_DE_ARTICULOS.ID_ARTICULO='" +id.ToString() +"' ";
            DataTable tabla = accesoDatos.ObtenerTabla("Descripcion", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                descripcion = tabla.Rows[i][0].ToString();
            }
            return descripcion;

        }
        AccesoDatos accesoDatos = new AccesoDatos();
        public List<Articulo> GetArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            string consulta = "SELECT ARTICULOS.ID,  ARTICULOS.NOMBRE, ARTICULOS.PRECIO,  ARTICULOS.IMAGEN,  ARTICULOS.STOCK,  CATEGORIAS.NOMBRE AS CATEGORIA,  COMPOSICIONES.NOMBRE AS COMPOSICION,  ISNULL(MEDIDAS.NOMBRE, MEDIDAS.ANCHO_CM+'x'+MEDIDAS.LARGO_CM) AS MEDIDA,  ESTILOS.NOMBRE AS ESTILO,  COLORES.CODIGO AS COLOR FROM ARTICULOS INNER JOIN MEDIDAS ON MEDIDAS.ID=ARTICULOS.ID_MEDIDA INNER JOIN CATEGORIAS ON CATEGORIAS.ID=ARTICULOS.ID_CATEGORIA INNER JOIN COMPOSICIONES ON COMPOSICIONES.ID=ARTICULOS.ID_COMPOSICION INNER JOIN ESTILOS ON ESTILOS.ID=ARTICULOS.ID_ESTILO INNER JOIN COLORES ON COLORES.ID=ARTICULOS.ID_COLOR";
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
        public bool delArticulo(Articulo articulo)
        {
            string consulta = "delete from ARTICULOS where Id=" + articulo.ID + "";
            int filas = accesoDatos.EjecutarConsulta(consulta);

            if (filas > 0)
            {
                return true;
            }

            return false;
        }
        public bool modArticulo(Articulo articulo)
        {
            string consulta = "UPDATE ARTICULOS SET NOMBRE='"+articulo.Nombre+"', PRECIO='"+articulo.Precio+"', IMAGEN='"+articulo.Imagen+"', STOCK='"+articulo.Cantidad+"', ID_CATEGORIA='"+articulo.categoria.ID+"', ID_COMPOSICION='"+articulo.composicion.ID+"', ID_MEDIDA='"+articulo.medida.ID+"', ID_ESTILO='"+articulo.estilo.ID+"', ID_COLOR='"+articulo.color.ID+"' WHERE ID='"+articulo.ID+"'" ;
            int filas = accesoDatos.EjecutarConsulta(consulta);

            if (filas > 0)
            {
                return true;
            }

            return false;
        }
        public bool setArticulo(Articulo articulo)
        {
            string consulta = "INSERT INTO ARTICULOS (NOMBRE,PRECIO, IMAGEN, STOCK, ID_CATEGORIA, ID_COMPOSICION, ID_MEDIDA	, ID_ESTILO,	ID_COLOR) VALUES('"+ articulo.Nombre  +"',	'"+articulo.Precio+"',	'"+articulo.Imagen+"',	'"+articulo.Cantidad+"',	'"+articulo.categoria.ID+"',	'"+articulo.composicion.ID+"',	'"+articulo.medida.ID+"',	'"+articulo.estilo.ID+"',	'"+articulo.color.ID+"')";
            int filas = accesoDatos.EjecutarConsulta(consulta);

            if (filas > 0)
            {
                return true;
            }

            return false;
        }
        public List<Articulo> getArticulosFiltrados(string valor)
        {

            List<Articulo> lista = new List<Articulo>();

            string consulta = "SELECT ARTICULOS.ID,  ARTICULOS.NOMBRE, ARTICULOS.PRECIO,  ARTICULOS.IMAGEN,  ARTICULOS.STOCK,  CATEGORIAS.NOMBRE AS CATEGORIA,  COMPOSICIONES.NOMBRE AS COMPOSICION,  ISNULL(MEDIDAS.NOMBRE, MEDIDAS.ANCHO_CM + 'x' + MEDIDAS.LARGO_CM) AS MEDIDA, ESTILOS.NOMBRE AS ESTILO,  COLORES.CODIGO AS COLOR FROM ARTICULOS INNER JOIN MEDIDAS ON MEDIDAS.ID = ARTICULOS.ID_MEDIDA INNER JOIN CATEGORIAS ON CATEGORIAS.ID = ARTICULOS.ID_CATEGORIA INNER JOIN COMPOSICIONES ON COMPOSICIONES.ID = ARTICULOS.ID_COMPOSICION INNER JOIN ESTILOS ON ESTILOS.ID = ARTICULOS.ID_ESTILO INNER JOIN COLORES ON COLORES.ID = ARTICULOS.ID_COLOR WHERE ARTICULOS.NOMBRE LIKE '%"+valor+ "%' OR CATEGORIAS.NOMBRE LIKE '%" + valor + "%' OR MEDIDAS.NOMBRE LIKE '%" + valor + "%' OR ESTILOS.NOMBRE LIKE '%" + valor + "%' ";

            DataTable tabla = accesoDatos.ObtenerTabla("Articulos", consulta);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Articulo art = new Articulo
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

                lista.Add(art);

            }

            return lista;
        }

    }
}
