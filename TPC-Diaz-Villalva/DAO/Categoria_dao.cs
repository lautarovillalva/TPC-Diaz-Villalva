using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;

namespace DAO
{
    public class Categoria_dao
    {
        AccesoDatos accesoDatos = new AccesoDatos();
        public List<Categoria> GetCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            string consulta = "SELECT CATEGORIAS.ID, CATEGORIAS.NOMBRE FROM CATEGORIAS";
            DataTable tabla = accesoDatos.ObtenerTabla("Categorias", consulta);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Categoria categoria = new Categoria
                {
                    ID = Convert.ToInt32(tabla.Rows[i][0]),
                    Nombre = tabla.Rows[i][1].ToString()
                };

                lista.Add(categoria);
            }

            return lista;
        }

    }
}
