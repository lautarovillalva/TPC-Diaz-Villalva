using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;

namespace DAO
{
    public class Color_dao
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public List<Color> GetColores()
        {
            List<Color> lista = new List<Color>();
            string consulta = "SELECT COLORES.ID, COLORES.NOMBRE, COLORES.CODIGO FROM COLORES";
            DataTable tabla = accesoDatos.ObtenerTabla("Colores", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Color color = new Color
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Nombre = tabla.Rows[i][1].ToString(),
                    Codigo = tabla.Rows[i][2].ToString(),
                };


                lista.Add(color);
            }

            return lista;
        }
        public bool modColor(Color color)
        {
            string consulta = "UPDATE ESTILOS SET NOMBRE='" + color.Nombre + "', CODIGO='"+color.Codigo+"' WHERE ID='" + color.ID + "' ";
            int filas = accesoDatos.EjecutarConsulta(consulta);

            if (filas > 0)
            {
                return true;
            }

            return false;
        }
        public bool setColor(Color color)
        {
            string consulta = "INSERT INTO COLORES(NOMBRE, CODIGO) VALUES ('" + color.Nombre + "', '" + color.Codigo + "') ";
            int filas = accesoDatos.EjecutarConsulta(consulta);

            if (filas > 0)
            {
                return true;
            }

            return false;
        }
    }
}
