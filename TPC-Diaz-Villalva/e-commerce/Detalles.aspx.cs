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
    public partial class Detalles : System.Web.UI.Page
    {

        public Articulo detalleArticulo;
        protected void Page_Load(object sender, EventArgs e)
        {

            buscarArticulo(Convert.ToInt32(Request.QueryString["id"]));
        }

        public void buscarArticulo(int ID)
        {
            Articulo_neg neg = new Articulo_neg();
            List<Articulo> lista = neg.ListarArticulos();

            foreach(Articulo item in lista)
            {
                if(item.ID == ID)
                {
                    this.detalleArticulo = new Articulo();
                    this.detalleArticulo = item;
                }
            }
           
        }

    }
}