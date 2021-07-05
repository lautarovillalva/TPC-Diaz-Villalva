using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;

namespace DAO
{
    class Medida_dao
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public List<Medida> GetMedidas()
        {
            List<Medida> lista = new List<Medida>();
            string consulta = "SELECT ID, ISNULL(MEDIDAS.NOMBRE, MEDIDAS.ANCHO_CM+'x'+MEDIDAS.LARGO_CM) AS MEDIDA, MEDIDAS.LARGO_CM, MEDIDAS.ANCHO_CM FROM MEDIDAS";
            DataTable tabla = accesoDatos.ObtenerTabla("Medidas", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Medida medida = new Medida
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Nombre = tabla.Rows[i][1].ToString(),
                    Largo = tabla.Rows[i][2].ToString(),
                    Ancho = tabla.Rows[i][3].ToString()
                };


                lista.Add(medida);
            }

            return lista;
        }
    }
}

