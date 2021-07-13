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
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarArticulos();
        }

        public void mostrarArticulos()
        {
            Articulo_neg art = new Articulo_neg();
            rpArticulos.DataSource = art.ArticulosFiltrados(Request.QueryString["valor"]);
            rpArticulos.DataBind();
        }
    }
}