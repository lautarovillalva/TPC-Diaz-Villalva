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
    public partial class _Default : Page
    {

        public List<Categoria> lista = new List<Categoria>();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        public void cargarCategorias()
        {
            try
            {
                Categoria_neg aux = new Categoria_neg();
                lista = aux.ListarCategorias();
            }
            catch (Exception ex)
            {

                string error = ex.ToString();
                Session["error"] = error;
                Response.Redirect("/Error.aspx");
            }
        }


    }
}