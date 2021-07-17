using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DAO;

namespace Negocio
{
    public class Categoria_neg
    {
        public List<Categoria> ListarCategorias()
        {
            Categoria_dao aux = new Categoria_dao();
            return aux.GetCategorias();
        }
        public bool agregarCategoria(Categoria categoria)
        {
            Categoria_dao categoria_Dao = new Categoria_dao();
            return categoria_Dao.setCategoria(categoria);
        }
        public bool modificarCategoria(Categoria categoria)
        {
            Categoria_dao categoria_Dao = new Categoria_dao();
            return categoria_Dao.modCategoria(categoria);
        }
        public bool eliminarCategoria(Categoria categoria)
        {
            Categoria_dao categoria_Dao = new Categoria_dao();
            return categoria_Dao.delCategoria(categoria);
        }

        public string getTotal()
        {
            Categoria_dao categoria_Dao = new Categoria_dao();

            List<int> totales = new List<int>();
            List<Categoria> lista = ListarCategorias();
            
            string porcentajes = "";
            int color = 0;


            foreach (Categoria item in lista)
            {
                totales.Add(categoria_Dao.totalCategoria(item.ID));
            }

            totales.Sort();

            for(int i=0; i< totales.Count; i++)
            {
                color += 100;
            

                if (i == totales.Count - 1)
                {
                    porcentajes += "rgb(72," + color + ", 176) " + totales[i] * 100 / totales.Sum() + "% ";
                }

                else
                {
                    porcentajes += "rgb(72," + color + ", 176) " + totales[i] * 100 / totales.Sum() + "% " + totales[i + 1] * 100 / totales.Sum() + "%, ";
                }
               

            }


            string graficoCircular = "conic-gradient(" + porcentajes + ")";

            return graficoCircular;
        }



    }
}
