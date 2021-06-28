using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;

namespace DAO
{
    public class Composicion_dao
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public List<Composicion> GetComposiciones()
        {
            List<Composicion> lista = new List<Composicion>();
            string consulta = "SELECT COMPOSICIONES.ID, COMPOSICIONES.NOMBRE FROM COMPOSICIONES";
            DataTable tabla = accesoDatos.ObtenerTabla("Composiciones", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Composicion composicion= new Composicion
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Nombre = tabla.Rows[i][1].ToString()
                };


                lista.Add(composicion);
            }

            return lista;
        }
    }
}
