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
        public List<Carrito> carrito = new List<Carrito>();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarListas();

            if (Session["lista"] != null)
            {
                carrito = Session["lista"] as List<Carrito>;
            }

        }


        public void cargarListas()
        {
            Categoria_neg cat = new Categoria_neg();
            Estilo_neg est = new Estilo_neg();

            listaCategorias = cat.ListarCategorias();
            listaEstilos = est.listarEstilos();

        }

        protected void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            Response.Redirect("Productos.aspx?valor="+ txtFiltrar.Text);
        }
    }
}