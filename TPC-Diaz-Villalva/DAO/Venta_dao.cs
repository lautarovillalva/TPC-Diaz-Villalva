using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;

namespace DAO
{
    public class Venta_dao
    {
        AccesoDatos accesoDatos = new AccesoDatos();

        public List<Venta> GetVentas()
        {
            List<Venta> lista = new List<Venta>();
            string consulta= "SELECT VENTAS.ID, VENTAS.FECHA, VENTAS.ID_USUARIO, USUARIOS.MAIL, VENTAS.ID_ESTADO, ESTADOS.NOMBRE AS ESTADO, VENTAS.ID_MPAGO, MEDIOS_DE_PAGO.NOMBRE AS MPAGO FROM VENTAS INNER JOIN USUARIOS ON USUARIOS.ID=VENTAS.ID_USUARIO INNER JOIN ESTADOS ON ESTADOS.ID=VENTAS.ID_ESTADO INNER JOIN MEDIOS_DE_PAGO ON MEDIOS_DE_PAGO.ID=VENTAS.ID_MPAGO";
            DataTable tabla = accesoDatos.ObtenerTabla("ventas", consulta);

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Venta venta = new Venta();
                venta.ID = Convert.ToInt32(tabla.Rows[i][0]);
                venta.Fecha = Convert.ToDateTime(tabla.Rows[i][1]);

                Usuario usuario = new Usuario(Convert.ToInt32(tabla.Rows[i][2]), tabla.Rows[i][3].ToString());
                venta.usuario = usuario;

                Estado estado = new Estado(Convert.ToInt32(tabla.Rows[i][4]), tabla.Rows[i][5].ToString());
                venta.estado = estado;

                Medio_de_pago medio_De_Pago = new Medio_de_pago(Convert.ToInt32(tabla.Rows[i][6]), tabla.Rows[i][7].ToString());
                venta.pago = medio_De_Pago;

                venta.Total = getTotal(venta.ID);
                venta.Cantidad = getCantidad(venta.ID);
                venta.lista = getArticulos(venta.ID);
                lista.Add(venta);
            }


            return lista;
        }

        private List<Articulo> getArticulos(int idventa)
        {
            List<Articulo> lista = new List<Articulo>();
            string consulta = "SELECT ARTICULOS.ID,  ARTICULOS.NOMBRE, ARTICULOS.PRECIO,  ARTICULOS.IMAGEN, (SELECT COUNT(ARTICULOS_X_VENTAS.ID_VENTA) FROM ARTICULOS_X_VENTAS WHERE ARTICULOS.ID=ARTICULOS_X_VENTAS.ID_VENTA) AS CANTIDAD ,  CATEGORIAS.NOMBRE AS CATEGORIA,  COMPOSICIONES.NOMBRE AS COMPOSICION,  ISNULL(MEDIDAS.NOMBRE, MEDIDAS.ANCHO_CM+'x'+MEDIDAS.LARGO_CM) AS MEDIDA,  ESTILOS.NOMBRE AS ESTILO,  COLORES.CODIGO AS COLOR FROM ARTICULOS INNER JOIN MEDIDAS ON MEDIDAS.ID=ARTICULOS.ID_MEDIDA INNER JOIN CATEGORIAS ON CATEGORIAS.ID=ARTICULOS.ID_CATEGORIA INNER JOIN COMPOSICIONES ON COMPOSICIONES.ID=ARTICULOS.ID_COMPOSICION INNER JOIN ESTILOS ON ESTILOS.ID=ARTICULOS.ID_ESTILO INNER JOIN COLORES ON COLORES.ID=ARTICULOS.ID_COLOR INNER JOIN ARTICULOS_X_VENTAS ON ARTICULOS_X_VENTAS.ID_ARTICULO=ARTICULOS.ID WHERE ARTICULOS_X_VENTAS.ID_VENTA='"+idventa.ToString()+"'";
            DataTable tabla = accesoDatos.ObtenerTabla("articulos", consulta);
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

        private double getTotal(int id)
        {
            double total=0;
            string consulta = " SELECT ISNULL(SUM(ARTICULOS_X_VENTAS.PRECIO_UNITARIO * ARTICULOS_X_VENTAS.CANTIDAD), 0) AS TOTAL FROM ARTICULOS_X_VENTAS INNER JOIN VENTAS ON VENTAS.ID = ARTICULOS_X_VENTAS.ID_VENTA WHERE VENTAS.ID ='" + id.ToString() + "' ";

            DataTable tabla = accesoDatos.ObtenerTabla("total", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                total = Convert.ToDouble(tabla.Rows[i][0]);
            }
            return total;
        }

        private int getCantidad(int id)
        {
            int cantidad = 0;
            string consulta = "SELECT COUNT(ARTICULOS_X_VENTAS.ID_VENTA) AS CANTIDAD FROM ARTICULOS_X_VENTAS WHERE ARTICULOS_X_VENTAS.ID_VENTA='"+id.ToString()+"'";

            DataTable tabla = accesoDatos.ObtenerTabla("cantidad", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                cantidad = Convert.ToInt32(tabla.Rows[0][0]);
            }

            return cantidad;
        }
         
    }
}
