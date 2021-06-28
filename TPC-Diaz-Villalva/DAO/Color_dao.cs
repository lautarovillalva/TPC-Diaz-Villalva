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
            string consulta = "SELECT COLORES.ID, COLORES.NOMBRE FROM COLORES";
            DataTable tabla = accesoDatos.ObtenerTabla("Colores", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Color color = new Color
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Nombre = tabla.Rows[i][1].ToString()
                };


                lista.Add(color);
            }

            return lista;
        }
    }
}
