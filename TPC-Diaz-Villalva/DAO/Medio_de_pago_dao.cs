using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;

namespace DAO
{
    public class Medio_de_pago_dao
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public List<Medio_de_pago> GetMedio_De_Pagos()
        {
            List<Medio_de_pago> lista = new List<Medio_de_pago>();
            string consulta = "SELECT MEDIOS_DE_PAGO.ID, MEDIOS_DE_PAGO.NOMBRE FROM MEDIOS_DE_PAGO";
            DataTable tabla = accesoDatos.ObtenerTabla("Mpago", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Medio_de_pago medio= new Medio_de_pago
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Nombre = tabla.Rows[i][1].ToString(),
                };


                lista.Add(medio);
            }

            return lista;
        }
    }
}
