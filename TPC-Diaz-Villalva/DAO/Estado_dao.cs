using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;


namespace DAO
{
    public class Estado_dao
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public List<Estado> GetEstados()
        {
            List<Estado> lista = new List<Estado>();
            string consulta = "SELECT ESTADOS.ID, ESTADOS.NOMBRE FROM ESTADOS";
            DataTable tabla = accesoDatos.ObtenerTabla("Estados", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Estado estado= new Estado
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Nombre = tabla.Rows[i][1].ToString()
                };


                lista.Add(estado);
            }

            return lista;
        }
    }
}
