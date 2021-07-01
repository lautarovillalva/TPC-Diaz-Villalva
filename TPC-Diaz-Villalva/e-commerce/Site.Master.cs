using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace e_commerce
{
    public partial class SiteMaster : MasterPage
    {
        public List<Categoria> listaCategorias = new List<Categoria>();
        public List<Estilo> listaEstilos = new List<Estilo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarListas();
        }


        public void cargarListas()
        {
            Categoria_neg cat = new Categoria_neg();
            Estilo_neg est = new Estilo_neg();

            listaCategorias = cat.ListarCategorias();
            listaEstilos = est.listarEstilos();

        }

    }
}